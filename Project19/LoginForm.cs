using Microsoft.Data.SqlClient;
using Project19.dao;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Project19
{
    public partial class LoginForm : Form
    {
        LoginSelectDBAccess loginSelect = new LoginSelectDBAccess();

        int numTime;
        private string inputId;
        private string inputPass;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idErrorlabel.ForeColor = Color.Red;
            passErrorlabel.ForeColor = Color.Red;
        }

        private void goDashButton_Click(object sender, EventArgs e)
        {
            DashForm dashForm = new DashForm();
            dashForm.StartPosition = FormStartPosition.Manual;
            dashForm.Location = this.Location;
            this.Hide();
            dashForm.ShowDialog();
            this.Show();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            inputId = idTextBox.Text;
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            inputPass = passTextBox.Text;
        }

        private void goDashButton_Click_1(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            idErrorlabel.Visible = false;
            passErrorlabel.Visible = false;
            
            inputPass = passTextBox.Text;
            inputId = idTextBox.Text;
            string passHash = HashPassword(inputPass);

            string pass = loginSelect.PasswordSelect(inputId);

            Debug.WriteLine(passHash);



            if (idTextBox.Text.Equals("") || passErrorlabel.Text.Equals(""))
            {
                if (idTextBox.Text.Equals(""))
                {
                    idErrorlabel.Visible = true;
                }
                if (passTextBox.Text.Equals(""))
                {
                    passErrorlabel.Visible = true;
                }
            }
            else if (pass.Equals(passHash)){
                DashForm dashForm = new DashForm();
                dashForm.StartPosition = FormStartPosition.Manual;
                dashForm.Location = this.Location;
                this.Hide();
                dashForm.ShowDialog();
                this.Show();
            }
            else
            {
                numTime++;
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                if (numTime >= 3)
                {
                    ErrorForm errorForm = new ErrorForm();
                    errorForm.MainForm = this;
                    errorForm.ShowDialog();
                }
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idTextBox.Text.Equals(""))
            {
                idErrorlabel.Visible = true;
            }
            else
            {
                idErrorlabel.Visible = false;
            }
        }

        private void passTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (passTextBox.Text.Equals(""))
            {
                passErrorlabel.Visible = true;
            }
            else
            {
                passErrorlabel.Visible = false;
            }
        }


        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
