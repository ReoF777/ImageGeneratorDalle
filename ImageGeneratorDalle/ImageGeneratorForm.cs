using OpenAI.Images;
namespace ImageGeneratorDalle
{
    public partial class ImageGeneratorForm : Form
    {
        private ImageClient? _client;
        private bool _isApiSet = false;
        private string _apiKey = string.Empty;

        public ImageGeneratorForm () {
            InitializeComponent();
        }

        private void GetAPIKey (object sender, EventArgs e) {
            if (_isApiSet)
            {
                MessageBox.Show("API�L�[�͂��łɐݒ肳��Ă��܂��B");
                return;
            }

            MessageBox.Show("API�L�[�̕ۑ�����Ă���t�@�C����I�����Ă��������B");

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "API�L�[�̕ۑ�����Ă���t�@�C�����J��";
                dialog.Filter = "�e�L�X�g�t�@�C��(*.txt)|*.txt|���ׂẴt�@�C��(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _apiKey = File.ReadAllText(dialog.FileName);
                    _isApiSet = true;
                    _client = new("dall-e-3", _apiKey);
                }
            }

            SetAPIBox.Enabled = false;
        }

        private async void GenerateImage (object sender, EventArgs e) {
            if (_client == null)
            {
                return;
            }

            Generate.Enabled = false;
            string prompt = ConditionBox.Text;

            ImageGenerationOptions options = new()
            {
                Quality = GeneratedImageQuality.High,
                Size = GeneratedImageSize.W1024xH1024,
                Style = GeneratedImageStyle.Vivid,
                ResponseFormat = GeneratedImageFormat.Bytes,
            };

            GeneratedImage image = await _client.GenerateImageAsync(prompt, options);
            BinaryData bytes = image.ImageBytes;

            using (MemoryStream stream = new(bytes.ToArray()))
            {
                ImageBox.Image = Image.FromStream(stream);
            }

            using FileStream fileStream = File.OpenWrite($"{Guid.NewGuid()}.png");
            bytes.ToStream().CopyTo(fileStream);
            Generate.Enabled = true;
        }
    }
}
