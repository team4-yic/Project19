namespace Project19
{
    partial class ShiftForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            addbutton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTextBox = new TextBox();
            deletebutton = new Button();
            textBox4 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1002, 490);
            dataGridView1.TabIndex = 0;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(819, 12);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(171, 56);
            addbutton.TabIndex = 1;
            addbutton.Text = "追加";
            addbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "氏名";
            textBox1.Size = new Size(644, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 95);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "開始時刻";
            textBox2.Size = new Size(320, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 95);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "終了時刻";
            textBox3.Size = new Size(320, 31);
            textBox3.TabIndex = 4;
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(12, 54);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.PlaceholderText = "日付";
            dateTextBox.Size = new Size(800, 31);
            dateTextBox.TabIndex = 5;
            dateTextBox.Click += dateTextBox_OnClick;
            dateTextBox.TextChanged += dateTextBox_TextChanged;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(819, 70);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(171, 56);
            deletebutton.TabIndex = 7;
            deletebutton.Text = "削除";
            deletebutton.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(662, 95);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "勤続月数";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(515, 85);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox5
            // 
            textBox5.ImeMode = ImeMode.Disable;
            textBox5.Location = new Point(662, 12);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "ID";
            textBox5.Size = new Size(151, 31);
            textBox5.TabIndex = 9;
            // 
            // ShiftForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 622);
            Controls.Add(textBox5);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox4);
            Controls.Add(deletebutton);
            Controls.Add(dateTextBox);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(addbutton);
            Controls.Add(dataGridView1);
            Name = "ShiftForm";
            Text = "シフト管理";
            Load += ShiftForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Button addbutton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox dateTextBox;
        private Button deletebutton;
        private TextBox textBox4;
        private MonthCalendar monthCalendar1;
        private TextBox textBox5;
    }
}