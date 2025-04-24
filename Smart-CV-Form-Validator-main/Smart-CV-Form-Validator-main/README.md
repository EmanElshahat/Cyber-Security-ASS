# Smart CV & Form Validator


https://github.com/user-attachments/assets/23b39504-a1cc-4486-ac77-3e8035ca7295


A C# Windows Forms application for validating user form input and parsing CV content using Regular Expressions (Regex).

## 🚀 Features

### 1. Manual Form Entry
- User can enter:
  - Name
  - Email
  - Phone Number
  - Password
  - Address
  - Postal Code
- Each input is validated using Regex
- Feedback is shown in a message box

### 2. CV Text Parsing
- Paste or upload plain-text CV content
- Automatically extracts:
  - Full Name
  - Email Address
  - Phone Number
  - Skills (e.g., C#, Java, SQL)
  - Years of Experience (e.g., "3 years")
- Results are displayed in a message box

## 💻 Tech Stack

- C#
- .NET Windows Forms
- Regex (System.Text.RegularExpressions)

## 📂 How to Use

1. Clone the repository
2. Open the solution in Visual Studio
3. Run the project
4. Test form validation and CV parsing

## ✅ Example CV Input
```
Name: Sarah Johnson  
Email: sarah@example.com  
Phone: +12345678901  

Professional Summary:  
A highly motivated software engineer with 3 years of experience in developing enterprise-level applications. 

Skills:  
Java,, Python,, JavaScript  

Work Experience:  
Software Developer at Tech Solutions Inc.  
March 2021 – Present  
- Managed databases using SQL Server  
- Collaborated with cross-functional teams  

Education:  
Bachelor of Computer Science  
University of Technology – 2018

Languages:  
English, French
```
