using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CaptchaGenerator
{
    public partial class Form1 : Form
    {
        private string currentCaptchaText = "";
        private int currentMathResult = 0;
        private bool checkboxCaptchaChecked = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            InitializeCaptchas();
        }

        private void InitializeCaptchas()
        {
            // Initialize all CAPTCHAs when the form loads
            GenerateTextCaptcha();
            GenerateImageCaptcha();
            GenerateMathCaptcha();
            checkboxCaptchaChecked = false;
            chkRecaptcha.Checked = false;
        }

        private void TabControl1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Reset result labels when switching tabs
            lblTextResult.Text = "";
            lblImageResult.Text = "";
            lblMathResult.Text = "";
            lblCheckboxResult.Text = "";

            // Clear user inputs
            txtTextCaptchaInput.Clear();
            txtImageCaptchaInput.Clear();
            txtMathCaptchaInput.Clear();

            // Reset checkbox
            if (tabControl1.SelectedIndex == 3)
            {
                checkboxCaptchaChecked = false;
                chkRecaptcha.Checked = false;
            }
        }

        #region Text CAPTCHA Methods
        private void GenerateTextCaptcha()
        {
            // Generate random text for CAPTCHA
            currentCaptchaText = GenerateRandomText(6);

            // Create an image with the text
            Bitmap captchaImage = CreateTextCaptchaImage(currentCaptchaText);

            // Display the image in the PictureBox
            pictureTextCaptcha.Image = captchaImage;

            // Clear result and input
            lblTextResult.Text = "";
            txtTextCaptchaInput.Clear();
        }

        private string GenerateRandomText(int length)
        {
            // Characters to use in CAPTCHA (exclude similar-looking characters)
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        private Bitmap CreateTextCaptchaImage(string text)
        {
            int width = 180;
            int height = 60;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background with random light color
                g.Clear(Color.FromArgb(random.Next(180, 255), random.Next(180, 255), random.Next(180, 255)));

                // Add noise (random lines)
                for (int i = 0; i < 10; i++)
                {
                    int x1 = random.Next(width);
                    int y1 = random.Next(height);
                    int x2 = random.Next(width);
                    int y2 = random.Next(height);

                    using (Pen pen = new Pen(Color.FromArgb(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100))))
                    {
                        g.DrawLine(pen, x1, y1, x2, y2);
                    }
                }

                // Configure font and formatting for the text
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    using (StringFormat format = new StringFormat())
                    {
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        // Create a path for warped text
                        GraphicsPath path = new GraphicsPath();
                        path.AddString(text, font.FontFamily, (int)font.Style,
                            font.Size, new Rectangle(0, 5, width, height - 10), format);

                        // Warp the text slightly
                        Matrix matrix = new Matrix();
                        matrix.Shear((float)random.NextDouble() * 0.3f, 0);
                        path.Transform(matrix);

                        // Draw the warped text
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.DrawPath(Pens.Black, path);
                        g.FillPath(Brushes.Black, path);
                    }
                }
            }

            return bitmap;
        }

        private void btnRefreshTextCaptcha_Click(object? sender, EventArgs e)
        {
            GenerateTextCaptcha();
        }

        private void btnValidateTextCaptcha_Click(object? sender, EventArgs e)
        {
            // Validate text CAPTCHA
            string userInput = txtTextCaptchaInput.Text.Trim().ToUpper();

            if (userInput == currentCaptchaText)
            {
                lblTextResult.ForeColor = Color.Green;
                lblTextResult.Text = "CAPTCHA Verified Successfully!";
            }
            else
            {
                lblTextResult.ForeColor = Color.Red;
                lblTextResult.Text = "Invalid CAPTCHA! Try again.";
            }
        }
        #endregion

        #region Image CAPTCHA Methods
        private List<int> selectedImageIndices = new List<int>();
        private List<int> correctImageIndices = new List<int>();
        private string targetCategory = "";

        private void GenerateImageCaptcha()
        {
            // Reset selections
            selectedImageIndices.Clear();
            correctImageIndices.Clear();

            // Define categories
            string[] categories = { "Cars", "Trees", "Buildings", "Traffic Lights" };

            // Randomly select a category for this CAPTCHA
            targetCategory = categories[random.Next(categories.Length)];

            // Create a grid panel with images
            Panel gridPanel = new Panel();
            gridPanel.Size = new Size(300, 300);
            gridPanel.Location = new Point(pictureImageCaptcha.Location.X, pictureImageCaptcha.Location.Y);
            gridPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create a 3x3 grid of checkbox-image pairs
            int imageSize = 90;
            int padding = 10;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    int index = row * 3 + col;

                    // Determine if this image should be from the target category
                    // Roughly 40% chance for each image to be correct
                    bool isTargetCategory = random.Next(100) < 40;

                    // Create a checkbox for selection
                    CheckBox checkbox = new CheckBox();
                    checkbox.Location = new Point(col * imageSize + 5, row * imageSize + 5);
                    checkbox.Size = new Size(20, 20);
                    checkbox.Tag = index; // Store the index in Tag for later reference
                    checkbox.CheckedChanged += ImageCheckbox_CheckedChanged;

                    // Create a "fake" image (colored panel with label)
                    Panel imagePanel = new Panel();
                    imagePanel.Location = new Point(col * imageSize + padding, row * imageSize + padding);
                    imagePanel.Size = new Size(imageSize - padding, imageSize - padding);
                    imagePanel.BackColor = Color.FromArgb(random.Next(100, 240), random.Next(100, 240), random.Next(100, 240));

                    // Add a label to represent what's in the image
                    Label imageLabel = new Label();
                    string category = isTargetCategory ? targetCategory : categories[random.Next(categories.Length)];
                    while (category == targetCategory && !isTargetCategory)
                    {
                        category = categories[random.Next(categories.Length)];
                    }

                    imageLabel.Text = category;
                    imageLabel.TextAlign = ContentAlignment.MiddleCenter;
                    imageLabel.Dock = DockStyle.Fill;

                    // Keep track of correct indices
                    if (isTargetCategory)
                    {
                        correctImageIndices.Add(index);
                    }

                    // Add label to panel
                    imagePanel.Controls.Add(imageLabel);

                    // Add controls to grid
                    gridPanel.Controls.Add(checkbox);
                    gridPanel.Controls.Add(imagePanel);
                }
            }

            // Replace the existing pictureImageCaptcha with our grid panel
            if (tabImageCaptcha.Controls.Contains(pictureImageCaptcha))
            {
                tabImageCaptcha.Controls.Remove(pictureImageCaptcha);
            }

            if (!tabImageCaptcha.Controls.Contains(gridPanel))
            {
                tabImageCaptcha.Controls.Add(gridPanel);
                gridPanel.Name = "gridImageCaptcha";

                // Adjust the location of other controls if needed
                txtImageCaptchaInput.Visible = false; // We don't need text input anymore
            }

            // Update instructions
            lblImageInstruction.Text = $"Select all images containing {targetCategory}:";

            // Clear result text
            lblImageResult.Text = "";
        }

        private void ImageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                int index = (int)checkBox.Tag;

                if (checkBox.Checked && !selectedImageIndices.Contains(index))
                {
                    selectedImageIndices.Add(index);
                }
                else if (!checkBox.Checked && selectedImageIndices.Contains(index))
                {
                    selectedImageIndices.Remove(index);
                }
            }
        }

        private void btnRefreshImageCaptcha_Click(object sender, EventArgs e)
        {
            // Clean up existing grid panel
            Control gridPanel = tabImageCaptcha.Controls["gridImageCaptcha"];
            if (gridPanel != null)
            {
                tabImageCaptcha.Controls.Remove(gridPanel);
            }

            GenerateImageCaptcha();
        }

        private void btnValidateImageCaptcha_Click(object sender, EventArgs e)
        {
            // Check if selected images match the correct images
            bool isCorrect = true;

            // Check if all correct images are selected
            foreach (int correctIndex in correctImageIndices)
            {
                if (!selectedImageIndices.Contains(correctIndex))
                {
                    isCorrect = false;
                    break;
                }
            }

            // Check if any incorrect images are selected
            foreach (int selectedIndex in selectedImageIndices)
            {
                if (!correctImageIndices.Contains(selectedIndex))
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                lblImageResult.ForeColor = Color.Green;
                lblImageResult.Text = "CAPTCHA Verified Successfully!";
            }
            else
            {
                lblImageResult.ForeColor = Color.Red;
                lblImageResult.Text = "Incorrect selection! Try again.";
            }
        }
        #endregion

        #region Math CAPTCHA Methods
        private void GenerateMathCaptcha()
        {
            // Generate a simple math problem
            int num1 = random.Next(1, 20);
            int num2 = random.Next(1, 20);
            string operation = "";

            // Pick a random operation
            switch (random.Next(4))
            {
                case 0:
                    operation = "+";
                    currentMathResult = num1 + num2;
                    break;
                case 1:
                    operation = "-";
                    // Ensure positive result
                    if (num1 < num2)
                    {
                        int temp = num1;
                        num1 = num2;
                        num2 = temp;
                    }
                    currentMathResult = num1 - num2;
                    break;
                case 2:
                    operation = "×";
                    // Use smaller numbers for multiplication
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                    currentMathResult = num1 * num2;
                    break;
                case 3:
                    operation = "÷";
                    // Ensure division results in whole number
                    num2 = random.Next(1, 10);
                    currentMathResult = random.Next(1, 10);
                    num1 = num2 * currentMathResult;
                    break;
            }

            // Create the math problem text
            string mathProblem = $"{num1} {operation} {num2} = ?";

            // Create an image with the math problem
            Bitmap captchaImage = CreateMathCaptchaImage(mathProblem);

            // Display the image
            pictureMathCaptcha.Image = captchaImage;

            // Clear result and input
            lblMathResult.Text = "";
            txtMathCaptchaInput.Clear();
        }

        private Bitmap CreateMathCaptchaImage(string mathProblem)
        {
            int width = 180;
            int height = 60;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background with random light color
                g.Clear(Color.FromArgb(random.Next(220, 256), random.Next(220, 256), random.Next(220, 256)));

                // Add noise (random dots)
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(width);
                    int y = random.Next(height);
                    bitmap.SetPixel(x, y, Color.FromArgb(random.Next(100, 200), random.Next(100, 200), random.Next(100, 200)));
                }

                // Add random curved lines
                for (int i = 0; i < 5; i++)
                {
                    using (Pen pen = new Pen(Color.FromArgb(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)), 1))
                    {
                        int x1 = random.Next(width / 4);
                        int y1 = random.Next(height);
                        int x2 = random.Next(width / 4, width / 2);
                        int y2 = random.Next(height);
                        int x3 = random.Next(width / 2, width * 3 / 4);
                        int y3 = random.Next(height);
                        int x4 = random.Next(width * 3 / 4, width);
                        int y4 = random.Next(height);

                        Point[] points = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4) };
                        g.DrawCurve(pen, points);
                    }
                }

                // Configure font and draw the math problem
                using (Font font = new Font("Arial", 22, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.DrawString(mathProblem, font, brush, new Rectangle(0, 0, width, height), format);
                }
            }

            return bitmap;
        }

        private void btnRefreshMathCaptcha_Click(object? sender, EventArgs e)
        {
            GenerateMathCaptcha();
        }

        private void btnValidateMathCaptcha_Click(object? sender, EventArgs e)
        {
            // Validate math CAPTCHA
            if (int.TryParse(txtMathCaptchaInput.Text.Trim(), out int userAnswer))
            {
                if (userAnswer == currentMathResult)
                {
                    lblMathResult.ForeColor = Color.Green;
                    lblMathResult.Text = "CAPTCHA Verified Successfully!";
                }
                else
                {
                    lblMathResult.ForeColor = Color.Red;
                    lblMathResult.Text = "Invalid CAPTCHA! Try again.";
                }
            }
            else
            {
                lblMathResult.ForeColor = Color.Red;
                lblMathResult.Text = "Please enter a valid number.";
            }
        }
        #endregion

        #region Checkbox CAPTCHA Methods
        private void chkRecaptcha_CheckedChanged(object? sender, EventArgs e)
        {
            // If checkbox is checked, show the verification dialog after a short delay
            if (chkRecaptcha.Checked)
            {
                timerCheckbox.Start();
            }
            else
            {
                checkboxCaptchaChecked = false;
                lblCheckboxResult.Text = "";
            }
        }

        private void timerCheckbox_Tick(object? sender, EventArgs e)
        {
            timerCheckbox.Stop();

            // Simulate a verification process
            using (Form verifyForm = new Form())
            {
                verifyForm.Text = "Verification";
                verifyForm.Size = new Size(300, 150);
                verifyForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                verifyForm.StartPosition = FormStartPosition.CenterParent;
                verifyForm.MaximizeBox = false;
                verifyForm.MinimizeBox = false;

                Label label = new Label
                {
                    Text = "Verifying you are human...",
                    AutoSize = true,
                    Location = new Point(50, 30)
                };

                ProgressBar progressBar = new ProgressBar
                {
                    Location = new Point(50, 60),
                    Size = new Size(200, 20),
                    Maximum = 100,
                    Value = 0
                };

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
                {
                    Interval = 30
                };

                timer.Tick += (s, args) =>
                {
                    progressBar.Value = Math.Min(progressBar.Value + 5, 100);

                    if (progressBar.Value >= 100)
                    {
                        timer.Stop();
                        verifyForm.DialogResult = DialogResult.OK;
                        verifyForm.Close();
                    }
                };

                verifyForm.Controls.Add(label);
                verifyForm.Controls.Add(progressBar);

                timer.Start();

                if (verifyForm.ShowDialog() == DialogResult.OK)
                {
                    checkboxCaptchaChecked = true;
                    lblCheckboxResult.ForeColor = Color.Green;
                    lblCheckboxResult.Text = "Verification successful. You are human!";
                }
                else
                {
                    chkRecaptcha.Checked = false;
                    checkboxCaptchaChecked = false;
                }
            }
        }

        private void btnValidateCheckboxCaptcha_Click(object? sender, EventArgs e)
        {
            // Validate checkbox CAPTCHA
            if (checkboxCaptchaChecked)
            {
                lblCheckboxResult.ForeColor = Color.Green;
                lblCheckboxResult.Text = "CAPTCHA Verified Successfully!";
            }
            else
            {
                lblCheckboxResult.ForeColor = Color.Red;
                lblCheckboxResult.Text = "Please check the box to verify you're not a robot.";
            }
        }

        private void btnRefreshCheckboxCaptcha_Click(object? sender, EventArgs e)
        {
            // Reset checkbox CAPTCHA
            checkboxCaptchaChecked = false;
            chkRecaptcha.Checked = false;
            lblCheckboxResult.Text = "";
        }
        #endregion

        private void tabTextCaptcha_Click(object sender, EventArgs e)
        {

        }
    }
}