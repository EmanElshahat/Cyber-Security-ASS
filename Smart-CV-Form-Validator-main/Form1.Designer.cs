namespace CVValidator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal, txtCV;
        private Button btnValidateForm, btnParseCV, btnSaveResults;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            txtCV = new TextBox();
            btnValidateForm = new Button();
            btnParseCV = new Button();
            lblTitle = new Label();
            btnSaveResults = new Button();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold | FontStyle.Italic);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(130, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 30);
            lblTitle.Text = "CV Smart Checker";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // txtName
            // 
            txtName.Location = new Point(30, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new Size(220, 25);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Your Email";
            txtEmail.Size = new Size(220, 25);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 130);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Mobile Number";
            txtPhone.Size = new Size(220, 25);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Secure Password";
            txtPassword.Size = new Size(220, 25);
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 200);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Your Address";
            txtAddress.Size = new Size(220, 25);
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(30, 235);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "Postal Code";
            txtPostal.Size = new Size(220, 25);
            // 
            // txtCV
            // 
            txtCV.Location = new Point(270, 60);
            txtCV.Multiline = true;
            txtCV.Name = "txtCV";
            txtCV.PlaceholderText = "Paste CV Here...";
            txtCV.Size = new Size(300, 200);
            txtCV.ScrollBars = ScrollBars.Vertical;
            // 
            // btnValidateForm
            // 
            btnValidateForm.Location = new Point(30, 275);
            btnValidateForm.Name = "btnValidateForm";
            btnValidateForm.Size = new Size(220, 35);
            btnValidateForm.Text = "Run Form Check";
            btnValidateForm.BackColor = Color.LightSteelBlue;
            btnValidateForm.Click += btnValidateForm_Click;
            // 
            // btnParseCV
            // 
            btnParseCV.Location = new Point(270, 275);
            btnParseCV.Name = "btnParseCV";
            btnParseCV.Size = new Size(300, 35);
            btnParseCV.Text = "Analyze CV Content";
            btnParseCV.BackColor = Color.LightGoldenrodYellow;
            btnParseCV.Click += btnParseCV_Click;
            // 
            // btnSaveResults
            // 
            btnSaveResults.Location = new Point(30, 320);
            btnSaveResults.Name = "btnSaveResults";
            btnSaveResults.Size = new Size(540, 35);
            btnSaveResults.Text = "Export Results to File";
            btnSaveResults.BackColor = Color.PaleGreen;
            btnSaveResults.Click += btnSaveResults_Click;

            // 
            // Form1
            // 
            ClientSize = new Size(620, 380);
            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtPostal);
            Controls.Add(txtCV);
            Controls.Add(btnValidateForm);
            Controls.Add(btnParseCV);
            Controls.Add(btnSaveResults);
            Name = "Form1";
            Text = "CV Checker Tool";
            BackColor = Color.WhiteSmoke;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
