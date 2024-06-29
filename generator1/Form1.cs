using generator1.Core;
using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace generator1
{
    public partial class Generator : Form
    {
        private static readonly string[] Domains = { "demo.com" };

        public Generator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var fingerprint = FakeProfileFactory.Generate();
            MessageBox.Show(fingerprint.ToString(), "Generated Fingerprint");
        }

        private void btnGenerateEmail_Click(object sender, EventArgs e)
        {
            string randomEmail = GenerateRandomEmail();
            MessageBox.Show(randomEmail, "Generated Random Email");
        }

        private static string GenerateRandomEmail()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder localPart = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                localPart.Append(chars[random.Next(chars.Length)]);
            }

            string hashedLocalPart = GetMd5Hash(localPart.ToString());
            string domain = Domains[0];
            return $"{hashedLocalPart}@{domain}";
        }

        private static string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2")); // Converts to hexadecimal string
                }
                return sb.ToString().ToLower(); // Lowercase for email compatibility
            }
        }
    }
}
