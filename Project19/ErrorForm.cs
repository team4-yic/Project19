using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19
{
    public partial class ErrorForm : Form
    {
        private LoginForm loginForm;
        public LoginForm MainForm { set { this.loginForm = value; } }
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            loginForm.Close();
            this.Close();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            error.ForeColor = Color.Red;
        }
    }
}
