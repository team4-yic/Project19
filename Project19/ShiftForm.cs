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
    public partial class ShiftForm : Form
    {
        public ShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void dateTextBox_OnClick(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTextBox.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
