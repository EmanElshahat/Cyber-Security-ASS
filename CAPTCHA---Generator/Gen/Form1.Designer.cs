namespace CaptchaGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabTextCaptcha = new TabPage();
            lblTextResult = new Label();
            btnValidateTextCaptcha = new Button();
            btnRefreshTextCaptcha = new Button();
            txtTextCaptchaInput = new TextBox();
            lblTextInstructions = new Label();
            pictureTextCaptcha = new PictureBox();
            tabImageCaptcha = new TabPage();
            lblImageResult = new Label();
            btnValidateImageCaptcha = new Button();
            btnRefreshImageCaptcha = new Button();
            txtImageCaptchaInput = new TextBox();
            lblImageInstruction = new Label();
            pictureImageCaptcha = new PictureBox();
            tabMathCaptcha = new TabPage();
            lblMathResult = new Label();
            btnValidateMathCaptcha = new Button();
            btnRefreshMathCaptcha = new Button();
            txtMathCaptchaInput = new TextBox();
            lblMathInstructions = new Label();
            pictureMathCaptcha = new PictureBox();
            tabCheckboxCaptcha = new TabPage();
            lblCheckboxResult = new Label();
            btnValidateCheckboxCaptcha = new Button();
            btnRefreshCheckboxCaptcha = new Button();
            chkRecaptcha = new CheckBox();
            lblCheckboxInstructions = new Label();
            timerCheckbox = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabTextCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTextCaptcha).BeginInit();
            tabImageCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureImageCaptcha).BeginInit();
            tabMathCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMathCaptcha).BeginInit();
            tabCheckboxCaptcha.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabTextCaptcha);
            tabControl1.Controls.Add(tabImageCaptcha);
            tabControl1.Controls.Add(tabMathCaptcha);
            tabControl1.Controls.Add(tabCheckboxCaptcha);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(832, 604);
            tabControl1.TabIndex = 0;
            // 
            // tabTextCaptcha
            // 
            tabTextCaptcha.Controls.Add(lblTextResult);
            tabTextCaptcha.Controls.Add(btnValidateTextCaptcha);
            tabTextCaptcha.Controls.Add(btnRefreshTextCaptcha);
            tabTextCaptcha.Controls.Add(txtTextCaptchaInput);
            tabTextCaptcha.Controls.Add(lblTextInstructions);
            tabTextCaptcha.Controls.Add(pictureTextCaptcha);
            tabTextCaptcha.Location = new Point(4, 29);
            tabTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            tabTextCaptcha.Name = "tabTextCaptcha";
            tabTextCaptcha.Padding = new Padding(4, 5, 4, 5);
            tabTextCaptcha.Size = new Size(824, 571);
            tabTextCaptcha.TabIndex = 0;
            tabTextCaptcha.Text = "Text CAPTCHA";
            tabTextCaptcha.UseVisualStyleBackColor = true;
            tabTextCaptcha.Click += tabTextCaptcha_Click;
            // 
            // lblTextResult
            // 
            lblTextResult.AutoSize = true;
            lblTextResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextResult.Location = new Point(197, 397);
            lblTextResult.Margin = new Padding(4, 0, 4, 0);
            lblTextResult.Name = "lblTextResult";
            lblTextResult.Size = new Size(0, 20);
            lblTextResult.TabIndex = 5;
            lblTextResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidateTextCaptcha
            // 
            btnValidateTextCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidateTextCaptcha.Location = new Point(418, 338);
            btnValidateTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnValidateTextCaptcha.Name = "btnValidateTextCaptcha";
            btnValidateTextCaptcha.Size = new Size(100, 46);
            btnValidateTextCaptcha.TabIndex = 4;
            btnValidateTextCaptcha.Text = "Validate";
            btnValidateTextCaptcha.UseVisualStyleBackColor = true;
            btnValidateTextCaptcha.Click += btnValidateTextCaptcha_Click;
            // 
            // btnRefreshTextCaptcha
            // 
            btnRefreshTextCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshTextCaptcha.Location = new Point(300, 338);
            btnRefreshTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnRefreshTextCaptcha.Name = "btnRefreshTextCaptcha";
            btnRefreshTextCaptcha.Size = new Size(100, 46);
            btnRefreshTextCaptcha.TabIndex = 3;
            btnRefreshTextCaptcha.Text = "Refresh";
            btnRefreshTextCaptcha.UseVisualStyleBackColor = true;
            btnRefreshTextCaptcha.Click += btnRefreshTextCaptcha_Click;
            // 
            // txtTextCaptchaInput
            // 
            txtTextCaptchaInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTextCaptchaInput.Location = new Point(300, 276);
            txtTextCaptchaInput.Margin = new Padding(4, 5, 4, 5);
            txtTextCaptchaInput.Name = "txtTextCaptchaInput";
            txtTextCaptchaInput.Size = new Size(216, 30);
            txtTextCaptchaInput.TabIndex = 2;
            txtTextCaptchaInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTextInstructions
            // 
            lblTextInstructions.AutoSize = true;
            lblTextInstructions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextInstructions.Location = new Point(265, 39);
            lblTextInstructions.Margin = new Padding(4, 0, 4, 0);
            lblTextInstructions.Name = "lblTextInstructions";
            lblTextInstructions.Size = new Size(316, 20);
            lblTextInstructions.TabIndex = 1;
            lblTextInstructions.Text = "Enter the characters shown in the image:";
            // 
            // pictureTextCaptcha
            // 
            pictureTextCaptcha.BorderStyle = BorderStyle.FixedSingle;
            pictureTextCaptcha.Location = new Point(302, 83);
            pictureTextCaptcha.Margin = new Padding(4, 5, 4, 5);
            pictureTextCaptcha.Name = "pictureTextCaptcha";
            pictureTextCaptcha.Size = new Size(202, 79);
            pictureTextCaptcha.TabIndex = 0;
            pictureTextCaptcha.TabStop = false;
            // 
            // tabImageCaptcha
            // 
            tabImageCaptcha.Controls.Add(lblImageResult);
            tabImageCaptcha.Controls.Add(btnValidateImageCaptcha);
            tabImageCaptcha.Controls.Add(btnRefreshImageCaptcha);
            tabImageCaptcha.Controls.Add(txtImageCaptchaInput);
            tabImageCaptcha.Controls.Add(lblImageInstruction);
            tabImageCaptcha.Controls.Add(pictureImageCaptcha);
            tabImageCaptcha.Location = new Point(4, 29);
            tabImageCaptcha.Margin = new Padding(4, 5, 4, 5);
            tabImageCaptcha.Name = "tabImageCaptcha";
            tabImageCaptcha.Padding = new Padding(4, 5, 4, 5);
            tabImageCaptcha.Size = new Size(824, 571);
            tabImageCaptcha.TabIndex = 1;
            tabImageCaptcha.Text = "Image CAPTCHA";
            tabImageCaptcha.UseVisualStyleBackColor = true;
            // 
            // lblImageResult
            // 
            lblImageResult.AutoSize = true;
            lblImageResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImageResult.Location = new Point(197, 397);
            lblImageResult.Margin = new Padding(4, 0, 4, 0);
            lblImageResult.Name = "lblImageResult";
            lblImageResult.Size = new Size(0, 20);
            lblImageResult.TabIndex = 11;
            lblImageResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidateImageCaptcha
            // 
            btnValidateImageCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidateImageCaptcha.Location = new Point(423, 515);
            btnValidateImageCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnValidateImageCaptcha.Name = "btnValidateImageCaptcha";
            btnValidateImageCaptcha.Size = new Size(100, 46);
            btnValidateImageCaptcha.TabIndex = 10;
            btnValidateImageCaptcha.Text = "Validate";
            btnValidateImageCaptcha.UseVisualStyleBackColor = true;
            btnValidateImageCaptcha.Click += btnValidateImageCaptcha_Click;
            // 
            // btnRefreshImageCaptcha
            // 
            btnRefreshImageCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshImageCaptcha.Location = new Point(305, 515);
            btnRefreshImageCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnRefreshImageCaptcha.Name = "btnRefreshImageCaptcha";
            btnRefreshImageCaptcha.Size = new Size(100, 46);
            btnRefreshImageCaptcha.TabIndex = 9;
            btnRefreshImageCaptcha.Text = "Refresh";
            btnRefreshImageCaptcha.UseVisualStyleBackColor = true;
            btnRefreshImageCaptcha.Click += btnRefreshImageCaptcha_Click;
            // 
            // txtImageCaptchaInput
            // 
            txtImageCaptchaInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImageCaptchaInput.Location = new Point(305, 460);
            txtImageCaptchaInput.Margin = new Padding(4, 5, 4, 5);
            txtImageCaptchaInput.Name = "txtImageCaptchaInput";
            txtImageCaptchaInput.Size = new Size(216, 30);
            txtImageCaptchaInput.TabIndex = 8;
            txtImageCaptchaInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblImageInstruction
            // 
            lblImageInstruction.AutoSize = true;
            lblImageInstruction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImageInstruction.Location = new Point(284, 19);
            lblImageInstruction.Margin = new Padding(4, 0, 4, 0);
            lblImageInstruction.Name = "lblImageInstruction";
            lblImageInstruction.Size = new Size(274, 20);
            lblImageInstruction.TabIndex = 7;
            lblImageInstruction.Text = "Type the name of the shape shown:";
            // 
            // pictureImageCaptcha
            // 
            pictureImageCaptcha.BorderStyle = BorderStyle.FixedSingle;
            pictureImageCaptcha.Location = new Point(284, 55);
            pictureImageCaptcha.Margin = new Padding(4, 5, 4, 5);
            pictureImageCaptcha.Name = "pictureImageCaptcha";
            pictureImageCaptcha.Size = new Size(266, 153);
            pictureImageCaptcha.TabIndex = 6;
            pictureImageCaptcha.TabStop = false;
            // 
            // tabMathCaptcha
            // 
            tabMathCaptcha.Controls.Add(lblMathResult);
            tabMathCaptcha.Controls.Add(btnValidateMathCaptcha);
            tabMathCaptcha.Controls.Add(btnRefreshMathCaptcha);
            tabMathCaptcha.Controls.Add(txtMathCaptchaInput);
            tabMathCaptcha.Controls.Add(lblMathInstructions);
            tabMathCaptcha.Controls.Add(pictureMathCaptcha);
            tabMathCaptcha.Location = new Point(4, 29);
            tabMathCaptcha.Margin = new Padding(4, 5, 4, 5);
            tabMathCaptcha.Name = "tabMathCaptcha";
            tabMathCaptcha.Size = new Size(824, 571);
            tabMathCaptcha.TabIndex = 2;
            tabMathCaptcha.Text = "Math CAPTCHA";
            tabMathCaptcha.UseVisualStyleBackColor = true;
            // 
            // lblMathResult
            // 
            lblMathResult.AutoSize = true;
            lblMathResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMathResult.Location = new Point(197, 397);
            lblMathResult.Margin = new Padding(4, 0, 4, 0);
            lblMathResult.Name = "lblMathResult";
            lblMathResult.Size = new Size(0, 20);
            lblMathResult.TabIndex = 11;
            lblMathResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidateMathCaptcha
            // 
            btnValidateMathCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidateMathCaptcha.Location = new Point(418, 339);
            btnValidateMathCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnValidateMathCaptcha.Name = "btnValidateMathCaptcha";
            btnValidateMathCaptcha.Size = new Size(100, 46);
            btnValidateMathCaptcha.TabIndex = 10;
            btnValidateMathCaptcha.Text = "Validate";
            btnValidateMathCaptcha.UseVisualStyleBackColor = true;
            btnValidateMathCaptcha.Click += btnValidateMathCaptcha_Click;
            // 
            // btnRefreshMathCaptcha
            // 
            btnRefreshMathCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshMathCaptcha.Location = new Point(300, 339);
            btnRefreshMathCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnRefreshMathCaptcha.Name = "btnRefreshMathCaptcha";
            btnRefreshMathCaptcha.Size = new Size(100, 46);
            btnRefreshMathCaptcha.TabIndex = 9;
            btnRefreshMathCaptcha.Text = "Refresh";
            btnRefreshMathCaptcha.UseVisualStyleBackColor = true;
            btnRefreshMathCaptcha.Click += btnRefreshMathCaptcha_Click;
            // 
            // txtMathCaptchaInput
            // 
            txtMathCaptchaInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMathCaptchaInput.Location = new Point(302, 250);
            txtMathCaptchaInput.Margin = new Padding(4, 5, 4, 5);
            txtMathCaptchaInput.Name = "txtMathCaptchaInput";
            txtMathCaptchaInput.Size = new Size(216, 30);
            txtMathCaptchaInput.TabIndex = 8;
            txtMathCaptchaInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMathInstructions
            // 
            lblMathInstructions.AutoSize = true;
            lblMathInstructions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMathInstructions.Location = new Point(265, 34);
            lblMathInstructions.Margin = new Padding(4, 0, 4, 0);
            lblMathInstructions.Name = "lblMathInstructions";
            lblMathInstructions.Size = new Size(291, 20);
            lblMathInstructions.TabIndex = 7;
            lblMathInstructions.Text = "Solve the math problem shown below:";
            // 
            // pictureMathCaptcha
            // 
            pictureMathCaptcha.BorderStyle = BorderStyle.FixedSingle;
            pictureMathCaptcha.Location = new Point(291, 80);
            pictureMathCaptcha.Margin = new Padding(4, 5, 4, 5);
            pictureMathCaptcha.Name = "pictureMathCaptcha";
            pictureMathCaptcha.Size = new Size(239, 153);
            pictureMathCaptcha.TabIndex = 6;
            pictureMathCaptcha.TabStop = false;
            // 
            // tabCheckboxCaptcha
            // 
            tabCheckboxCaptcha.Controls.Add(lblCheckboxResult);
            tabCheckboxCaptcha.Controls.Add(btnValidateCheckboxCaptcha);
            tabCheckboxCaptcha.Controls.Add(btnRefreshCheckboxCaptcha);
            tabCheckboxCaptcha.Controls.Add(chkRecaptcha);
            tabCheckboxCaptcha.Controls.Add(lblCheckboxInstructions);
            tabCheckboxCaptcha.Location = new Point(4, 29);
            tabCheckboxCaptcha.Margin = new Padding(4, 5, 4, 5);
            tabCheckboxCaptcha.Name = "tabCheckboxCaptcha";
            tabCheckboxCaptcha.Size = new Size(824, 571);
            tabCheckboxCaptcha.TabIndex = 3;
            tabCheckboxCaptcha.Text = "Checkbox CAPTCHA";
            tabCheckboxCaptcha.UseVisualStyleBackColor = true;
            // 
            // lblCheckboxResult
            // 
            lblCheckboxResult.AutoSize = true;
            lblCheckboxResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCheckboxResult.Location = new Point(197, 397);
            lblCheckboxResult.Margin = new Padding(4, 0, 4, 0);
            lblCheckboxResult.Name = "lblCheckboxResult";
            lblCheckboxResult.Size = new Size(0, 20);
            lblCheckboxResult.TabIndex = 18;
            lblCheckboxResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidateCheckboxCaptcha
            // 
            btnValidateCheckboxCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidateCheckboxCaptcha.Location = new Point(435, 319);
            btnValidateCheckboxCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnValidateCheckboxCaptcha.Name = "btnValidateCheckboxCaptcha";
            btnValidateCheckboxCaptcha.Size = new Size(100, 46);
            btnValidateCheckboxCaptcha.TabIndex = 17;
            btnValidateCheckboxCaptcha.Text = "Validate";
            btnValidateCheckboxCaptcha.UseVisualStyleBackColor = true;
            btnValidateCheckboxCaptcha.Click += btnValidateCheckboxCaptcha_Click;
            // 
            // btnRefreshCheckboxCaptcha
            // 
            btnRefreshCheckboxCaptcha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefreshCheckboxCaptcha.Location = new Point(317, 319);
            btnRefreshCheckboxCaptcha.Margin = new Padding(4, 5, 4, 5);
            btnRefreshCheckboxCaptcha.Name = "btnRefreshCheckboxCaptcha";
            btnRefreshCheckboxCaptcha.Size = new Size(100, 46);
            btnRefreshCheckboxCaptcha.TabIndex = 16;
            btnRefreshCheckboxCaptcha.Text = "Reset";
            btnRefreshCheckboxCaptcha.UseVisualStyleBackColor = true;
            btnRefreshCheckboxCaptcha.Click += btnRefreshCheckboxCaptcha_Click;
            // 
            // chkRecaptcha
            // 
            chkRecaptcha.AutoSize = true;
            chkRecaptcha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRecaptcha.Location = new Point(362, 169);
            chkRecaptcha.Margin = new Padding(4, 5, 4, 5);
            chkRecaptcha.Name = "chkRecaptcha";
            chkRecaptcha.Size = new Size(138, 24);
            chkRecaptcha.TabIndex = 14;
            chkRecaptcha.Text = "I'm not a robot";
            chkRecaptcha.UseVisualStyleBackColor = true;
            chkRecaptcha.CheckedChanged += chkRecaptcha_CheckedChanged;
            // 
            // lblCheckboxInstructions
            // 
            lblCheckboxInstructions.AutoSize = true;
            lblCheckboxInstructions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheckboxInstructions.Location = new Point(263, 62);
            lblCheckboxInstructions.Margin = new Padding(4, 0, 4, 0);
            lblCheckboxInstructions.Name = "lblCheckboxInstructions";
            lblCheckboxInstructions.Size = new Size(342, 20);
            lblCheckboxInstructions.TabIndex = 13;
            lblCheckboxInstructions.Text = "Please check the box to verify you're human:";
            // 
            // timerCheckbox
            // 
            timerCheckbox.Interval = 500;
            timerCheckbox.Tick += timerCheckbox_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 604);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAPTCHA Generator";
            tabControl1.ResumeLayout(false);
            tabTextCaptcha.ResumeLayout(false);
            tabTextCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTextCaptcha).EndInit();
            tabImageCaptcha.ResumeLayout(false);
            tabImageCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureImageCaptcha).EndInit();
            tabMathCaptcha.ResumeLayout(false);
            tabMathCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMathCaptcha).EndInit();
            tabCheckboxCaptcha.ResumeLayout(false);
            tabCheckboxCaptcha.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTextCaptcha;
        private System.Windows.Forms.TabPage tabImageCaptcha;
        private System.Windows.Forms.TabPage tabMathCaptcha;
        private System.Windows.Forms.TabPage tabCheckboxCaptcha;
        private System.Windows.Forms.PictureBox pictureTextCaptcha;
        private System.Windows.Forms.Label lblTextInstructions;
        private System.Windows.Forms.TextBox txtTextCaptchaInput;
        private System.Windows.Forms.Button btnRefreshTextCaptcha;
        private System.Windows.Forms.Button btnValidateTextCaptcha;
        private System.Windows.Forms.Label lblTextResult;
        private System.Windows.Forms.Label lblImageResult;
        private System.Windows.Forms.Button btnValidateImageCaptcha;
        private System.Windows.Forms.Button btnRefreshImageCaptcha;
        private System.Windows.Forms.TextBox txtImageCaptchaInput;
        private System.Windows.Forms.Label lblImageInstruction;
        private System.Windows.Forms.PictureBox pictureImageCaptcha;
        private System.Windows.Forms.Label lblMathResult;
        private System.Windows.Forms.Button btnValidateMathCaptcha;
        private System.Windows.Forms.Button btnRefreshMathCaptcha;
        private System.Windows.Forms.TextBox txtMathCaptchaInput;
        private System.Windows.Forms.Label lblMathInstructions;
        private System.Windows.Forms.PictureBox pictureMathCaptcha;
        private System.Windows.Forms.Label lblCheckboxResult;
        private System.Windows.Forms.Button btnValidateCheckboxCaptcha;
        private System.Windows.Forms.Button btnRefreshCheckboxCaptcha;
        private System.Windows.Forms.CheckBox chkRecaptcha;
        private System.Windows.Forms.Label lblCheckboxInstructions;
        private System.Windows.Forms.Timer timerCheckbox;
    }
}