using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SteganographyApp
{
    public partial class Form1 : Form
    {
        private Bitmap currentImage = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                    openFileDialog.Title = "Select an Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentImage = new Bitmap(openFileDialog.FileName);
                        pictureBox.Image = currentImage;

                        using (TextInputForm textInputForm = new TextInputForm())
                        {
                            if (textInputForm.ShowDialog() == DialogResult.OK)
                            {
                                string textToEncode = textInputForm.InputText;

                                if (!string.IsNullOrEmpty(textToEncode))
                                {
                                    Bitmap encodedImage = SteganographyHelper.EncodeText(currentImage, textToEncode);

                                    pictureBox.Image = encodedImage;

                                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                                    {
                                        saveFileDialog.Filter = "PNG Image|*.png";
                                        saveFileDialog.Title = "Save Encoded Image";
                                        saveFileDialog.FileName = "encoded_image.png";

                                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                        {
                                            encodedImage.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                                            MessageBox.Show("Text successfully encoded and image saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg";
                    openFileDialog.Title = "Select The Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentImage = new Bitmap(openFileDialog.FileName);
                        pictureBox.Image = currentImage;

                        string decodedText = SteganographyHelper.DecodeText(currentImage);

                        using (TextResultForm resultForm = new TextResultForm(decodedText))
                        {
                            resultForm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class SteganographyHelper
    {
        public static Bitmap EncodeText(Bitmap image, string text)
        {
            Bitmap encodedImage = new Bitmap(image);

            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            int textLength = textBytes.Length;

            if ((image.Width * image.Height) < textLength + 2)
            {
                throw new ArgumentException("The image is too small to store text");
            }

            int x = 0;
            int y = 0;
            Color firstPixel = image.GetPixel(x, y);
            Color newFirstPixel = Color.FromArgb(
                firstPixel.R,
                textLength / 256,
                textLength % 256
            );
            encodedImage.SetPixel(x, y, newFirstPixel);

            for (int i = 0; i < textLength; i++)
            {
                x = (i + 1) % image.Width;
                y = (i + 1) / image.Width;

                Color pixel = image.GetPixel(x, y);

                Color newPixel = Color.FromArgb(
                    pixel.R,
                    (textBytes[i] & 0xF0) >> 4,
                    textBytes[i] & 0x0F
                );

                encodedImage.SetPixel(x, y, newPixel);
            }

            return encodedImage;
        }

        public static string DecodeText(Bitmap image)
        {
            try
            {
                Color firstPixel = image.GetPixel(0, 0);
                int textLength = (firstPixel.G * 256) + firstPixel.B;

                if (textLength <= 0 || textLength > (image.Width * image.Height) - 1)
                {
                    return "No hidden text found or image is corrupted.";
                }

                byte[] textBytes = new byte[textLength];
                for (int i = 0; i < textLength; i++)
                {
                    int x = (i + 1) % image.Width;
                    int y = (i + 1) / image.Width;
                    Color pixel = image.GetPixel(x, y);

                    textBytes[i] = (byte)((pixel.G << 4) | (pixel.B & 0x0F));
                }

                return Encoding.UTF8.GetString(textBytes);
            }
            catch (Exception ex)
            {
                return "Error decoding text: " + ex.Message;
            }
        }
    }

    public class TextInputForm : Form
    {
        private TextBox txtInput;
        private Button btnOK;
        private Button btnCancel;

        public string InputText { get; private set; }

        public TextInputForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Enter Text to Hide";
            this.Size = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            txtInput = new TextBox();
            txtInput.Multiline = true;
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Location = new Point(10, 10);
            txtInput.Size = new Size(365, 150);

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(210, 170);
            btnOK.Size = new Size(75, 30);
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Click += BtnOK_Click;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(300, 170);
            btnCancel.Size = new Size(75, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            this.Controls.Add(txtInput);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            InputText = txtInput.Text;
        }
    }

    public class TextResultForm : Form
    {
        private TextBox txtResult;
        private Button btnOK;

        public TextResultForm(string decodedText)
        {
            InitializeComponents(decodedText);
        }

        private void InitializeComponents(string decodedText)
        {
            this.Text = "Decoded Text";
            this.Size = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            txtResult = new TextBox();
            txtResult.Multiline = true;
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Location = new Point(10, 10);
            txtResult.Size = new Size(365, 150);
            txtResult.Text = decodedText;

            btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(300, 170);
            btnOK.Size = new Size(75, 30);
            btnOK.DialogResult = DialogResult.OK;

            this.Controls.Add(txtResult);
            this.Controls.Add(btnOK);

            this.AcceptButton = btnOK;
        }
    }
}
