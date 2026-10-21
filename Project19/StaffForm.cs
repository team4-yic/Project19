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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void PTJListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PTJForm_Load(object sender, EventArgs e)
        {
            var list = new List<Person>
                {
                    new Person { Name = "田中", Age = 30 },
                    new Person { Name = "佐藤", Age = 25 }
                };
            PTJListView.DataSource = list;
        }

        private void addNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
