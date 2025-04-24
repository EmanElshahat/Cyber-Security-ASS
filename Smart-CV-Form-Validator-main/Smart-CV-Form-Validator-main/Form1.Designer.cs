namespace CVValidator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal, txtCV;
        private Button btnValidateForm, btnParseCV, btnSaveResults;
        private Label lblTitle;
        private GroupBox groupUserData;

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
            groupUserData = new GroupBox();
            groupUserData.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 30);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Full Name";
            txtName.Size = new Size(210, 30);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(210, 30);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(15, 90);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(210, 30);
            txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(210, 30);
            txtPassword.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(15, 150);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(210, 30);
            txtAddress.TabIndex = 4;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(15, 180);
            txtPostal.Name = "txtPostal";
            txtPostal.PlaceholderText = "Postal Code";
            txtPostal.Size = new Size(210, 30);
            txtPostal.TabIndex = 5;
            // 
            // txtCV
            // 
            txtCV.Location = new Point(290, 70);
            txtCV.Multiline = true;
            txtCV.Name = "txtCV";
            txtCV.PlaceholderText = "Insert your CV here...";
            txtCV.ScrollBars = ScrollBars.Vertical;
            txtCV.Size = new Size(280, 170);
            txtCV.TabIndex = 2;
            // 
            // btnValidateForm
            // 
            btnValidateForm.BackColor = Color.LightCyan;
            btnValidateForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnValidateForm.Location = new Point(20, 311);
            btnValidateForm.Name = "btnValidateForm";
            btnValidateForm.Size = new Size(250, 30);
            btnValidateForm.TabIndex = 3;
            btnValidateForm.Text = "Validate Information";
            btnValidateForm.UseVisualStyleBackColor = false;
            btnValidateForm.Click += btnValidateForm_Click;
            // 
            // btnParseCV
            // 
            btnParseCV.BackColor = Color.LemonChiffon;
            btnParseCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnParseCV.Location = new Point(290, 246);
            btnParseCV.Name = "btnParseCV";
            btnParseCV.Size = new Size(280, 30);
            btnParseCV.TabIndex = 4;
            btnParseCV.Text = "Parse CV Details";
            btnParseCV.UseVisualStyleBackColor = false;
            btnParseCV.Click += btnParseCV_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(85, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart CV and Info Validator";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // btnSaveResults
            // 
            btnSaveResults.BackColor = Color.Honeydew;
            btnSaveResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveResults.Location = new Point(20, 409);
            btnSaveResults.Name = "btnSaveResults";
            btnSaveResults.Size = new Size(550, 35);
            btnSaveResults.TabIndex = 5;
            btnSaveResults.Text = "Save Summary";
            btnSaveResults.UseVisualStyleBackColor = false;
            btnSaveResults.Click += btnSaveResults_Click;
            // 
            // groupUserData
            // 
            groupUserData.Controls.Add(txtName);
            groupUserData.Controls.Add(txtEmail);
            groupUserData.Controls.Add(txtPhone);
            groupUserData.Controls.Add(txtPassword);
            groupUserData.Controls.Add(txtAddress);
            groupUserData.Controls.Add(txtPostal);
            groupUserData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupUserData.ForeColor = Color.DarkSlateGray;
            groupUserData.Location = new Point(20, 65);
            groupUserData.Name = "groupUserData";
            groupUserData.Size = new Size(250, 240);
            groupUserData.TabIndex = 1;
            groupUserData.TabStop = false;
            groupUserData.Text = "Your Information";
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(600, 466);
            Controls.Add(lblTitle);
            Controls.Add(groupUserData);
            Controls.Add(txtCV);
            Controls.Add(btnValidateForm);
            Controls.Add(btnParseCV);
            Controls.Add(btnSaveResults);
            Name = "Form1";
            Text = "CV & Data Analyzer";
            groupUserData.ResumeLayout(false);
            groupUserData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
