namespace ImageGeneratorDalle
{
    partial class ImageGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            Generate = new Button();
            label1 = new Label();
            ConditionBox = new TextBox();
            ImageBox = new PictureBox();
            SetAPIBox = new Button();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // Generate
            // 
            Generate.Location = new Point(403, 693);
            Generate.Name = "Generate";
            Generate.Size = new Size(94, 29);
            Generate.TabIndex = 0;
            Generate.Text = "生成";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += GenerateImage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "条件";
            // 
            // ConditionBox
            // 
            ConditionBox.Location = new Point(80, 38);
            ConditionBox.MaximumSize = new Size(512, 100);
            ConditionBox.MinimumSize = new Size(512, 100);
            ConditionBox.Name = "ConditionBox";
            ConditionBox.Size = new Size(512, 100);
            ConditionBox.TabIndex = 2;
            // 
            // ImageBox
            // 
            ImageBox.BackColor = SystemColors.ControlLight;
            ImageBox.Location = new Point(80, 159);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(512, 512);
            ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageBox.TabIndex = 3;
            ImageBox.TabStop = false;
            // 
            // SetAPIBox
            // 
            SetAPIBox.Location = new Point(137, 693);
            SetAPIBox.Name = "SetAPIBox";
            SetAPIBox.Size = new Size(94, 29);
            SetAPIBox.TabIndex = 4;
            SetAPIBox.Text = "APIキー設定";
            SetAPIBox.UseVisualStyleBackColor = true;
            SetAPIBox.Click += GetAPIKey;
            // 
            // ImageGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 748);
            Controls.Add(SetAPIBox);
            Controls.Add(ImageBox);
            Controls.Add(ConditionBox);
            Controls.Add(label1);
            Controls.Add(Generate);
            Name = "ImageGeneratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DALLEGenerator";
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generate;
        private Label label1;
        private TextBox ConditionBox;
        private PictureBox ImageBox;
        private Button SetAPIBox;
    }
}
