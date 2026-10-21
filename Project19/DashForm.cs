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
    public partial class DashForm : Form
    {
        ShiftForm shiftForm = new ShiftForm();
        WorkStatusForm workStatusForm = new WorkStatusForm();
        StaffForm staffForm = new StaffForm();

        public DashForm()
        {
            InitializeComponent();
        }

        private void goWSButton_Click(object sender, EventArgs e)
        {
            if (workStatusForm == null || workStatusForm.IsDisposed)
            {
                workStatusForm = new WorkStatusForm();
                workStatusForm.TopMost = true;
                workStatusForm.Show();
                goWSButton.Text = "勤務状況画面を閉じる";
            }
            else
            {
                workStatusForm.Close();
                goWSButton.Text = "勤務状況画面を開く";
            }
        }
        private void goShiftButton_Click(object sender, EventArgs e)
        {
            if (shiftForm == null || shiftForm.IsDisposed)
            {
                shiftForm = new ShiftForm();
                shiftForm.TopMost = true;
                shiftForm.Show();
                goShiftButton.Text = "シフト管理画面を閉じる";
            }
            else 
            {
                shiftForm.Close();
                goShiftButton.Text = "シフト管理画面を開く";
            }
        }
        private void goPTJButton_Click(object sender, EventArgs e)
        {
            if (staffForm == null || staffForm.IsDisposed)
            {
                staffForm = new StaffForm();
                staffForm.TopMost = true;
                staffForm.Show();
                staffForm.Text = "アルバイト追加・削除\r\n画面を閉じる";
            }
            else
            {
                staffForm.Close();
                staffForm.Text = "アルバイト追加・削除\r\n画面を開く";
            }
        }

        private void backLoginButton_Click(object sender, EventArgs e)
        {
            if (workStatusForm != null)
            {
                workStatusForm.Close();
            }
            if (shiftForm != null)
            {
                shiftForm.Close();
            }
            if (staffForm != null)
            {
                staffForm.Close();
            }
            this.Close();
        }
    }
}
