using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CVValidator
{
    public partial class Form1 : Form
    {
        string extractedName = "", extractedEmail = "", extractedPhone = "", extractedSkills = "", extractedExperience = "", extractedEducation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private int HighlightField(TextBox field, Func<string, bool> isValid, string fieldName)
        {
            if (!isValid(field.Text))
            {
                field.BackColor = Color.MistyRose;
                return 0;
            }
            else
            {
                field.BackColor = Color.Honeydew;
                return 1;
            }
        }

        private void btnValidateForm_Click(object sender, EventArgs e)
        {
            int score = 0;
            score += HighlightField(txtName, s => !string.IsNullOrWhiteSpace(s), "Name");
            score += HighlightField(txtEmail, s => Regex.IsMatch(s, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"), "Email");
            score += HighlightField(txtPhone, s => Regex.IsMatch(s, @"^\d{10,15}$"), "Phone");
            score += HighlightField(txtPassword, s => s.Length >= 6, "Password");
            score += HighlightField(txtAddress, s => !string.IsNullOrWhiteSpace(s), "Address");
            score += HighlightField(txtPostal, s => Regex.IsMatch(s, @"^\d{5,}$"), "Postal Code");

            string message = score switch
            {
                6 => "كل البيانات ممتازة! ✅",
                >= 4 => "أغلب البيانات صحيحة، راجع الباقي 💡",
                _ => "في بيانات ناقصة أو غير صحيحة ❌"
            };

            MessageBox.Show(message, "نتيجة الفحص", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnParseCV_Click(object sender, EventArgs e)
        {
            string cvText = txtCV.Text;
            if (string.IsNullOrWhiteSpace(cvText))
            {
                MessageBox.Show("Enter your cv frist!!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string language = DetectLanguage(cvText);

            if (language == "English")
            {
                extractedName = Regex.Match(cvText, @"(?:Name)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
                extractedEmail = Regex.Match(cvText, @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+").Value;
                extractedPhone = Regex.Match(cvText, @"(\+?\d{10,15})").Value;
                extractedSkills = Regex.Match(cvText, @"(?:Skills)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
                extractedExperience = "Experience: " + Regex.Match(cvText, @"(\d+)\s*(?:years)").Groups[1].Value;
                extractedEducation = Regex.Match(cvText, @"(?:Education)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
            }
            else if (language == "Arabic")
            {
                extractedName = Regex.Match(cvText, @"(?:الاسم)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
                extractedEmail = Regex.Match(cvText, @"[a-zAZ0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+").Value;
                extractedPhone = Regex.Match(cvText, @"(\+?\d{10,15})").Value;
                extractedSkills = Regex.Match(cvText, @"(?:المهارات)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
                extractedExperience = "سنوات الخبرة: " + Regex.Match(cvText, @"(\d+)\s*(?:سنوات|عام)").Groups[1].Value;
                extractedEducation = Regex.Match(cvText, @"(?:التعليم)[:：]?\s*(.+)", RegexOptions.IgnoreCase).Groups[1].Value;
            }
            else
            {
                MessageBox.Show("لم يتم تحديد اللغة بدقة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string summary = language == "English"
                ? $"Name: {extractedName}\nEmail: {extractedEmail}\nPhone: {extractedPhone}\nSkills: {extractedSkills}\nExperience: {extractedExperience}\nEducation: {extractedEducation}"
                : $"📄 الاسم: {extractedName}\n📧 البريد الإلكتروني: {extractedEmail}\n📞 الهاتف: {extractedPhone}\n🛠 المهارات: {extractedSkills}\n📅 سنوات الخبرة: {extractedExperience}\n🎓 التعليم: {extractedEducation}";

            MessageBox.Show(summary, language == "English" ? "CV Summary" : "ملخص السيرة الذاتية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string DetectLanguage(string text)
        {
            if (Regex.IsMatch(text, @"[\u0600-\u06FF]"))
            {
                return "Arabic";
            }
            else if (Regex.IsMatch(text, @"[a-zA-Z]"))
            {
                return "English";
            }
            else
            {
                return "Unknown";
            }
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(extractedName) || string.IsNullOrEmpty(extractedEmail) || string.IsNullOrEmpty(extractedPhone))
            {
                MessageBox.Show("Enter your cv frist!!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "احفظ ملخص السيرة الذاتية"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("📄 الاسم: " + extractedName);
                    writer.WriteLine("📧 البريد الإلكتروني: " + extractedEmail);
                    writer.WriteLine("📞 الهاتف: " + extractedPhone);
                    writer.WriteLine("🛠 المهارات: " + extractedSkills);
                    writer.WriteLine("📅 سنوات الخبرة: " + extractedExperience);
                    writer.WriteLine("🎓 التعليم: " + extractedEducation);
                }

                MessageBox.Show("✅ تم حفظ البيانات بنجاح في ملف .txt", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
