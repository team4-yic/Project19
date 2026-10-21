namespace Project19
{
    partial class DashForm
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
            panel1 = new Panel();
            backLoginButton = new Button();
            goStuffButton = new Button();
            goShiftButton = new Button();
            goWSButton = new Button();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(backLoginButton);
            panel1.Controls.Add(goStuffButton);
            panel1.Controls.Add(goShiftButton);
            panel1.Controls.Add(goWSButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1344, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 994);
            panel1.TabIndex = 0;
            // 
            // backLoginButton
            // 
            backLoginButton.Location = new Point(40, 825);
            backLoginButton.Name = "backLoginButton";
            backLoginButton.Size = new Size(237, 94);
            backLoginButton.TabIndex = 3;
            backLoginButton.Text = "ログアウト";
            backLoginButton.UseVisualStyleBackColor = true;
            backLoginButton.Click += backLoginButton_Click;
            // 
            // goStuffButton
            // 
            goStuffButton.Location = new Point(40, 546);
            goStuffButton.Name = "goStuffButton";
            goStuffButton.Size = new Size(237, 178);
            goStuffButton.TabIndex = 2;
            goStuffButton.Text = "スタッフ追加・削除\r\n画面を開く";
            goStuffButton.UseVisualStyleBackColor = true;
            goStuffButton.Click += goPTJButton_Click;
            // 
            // goShiftButton
            // 
            goShiftButton.Location = new Point(40, 300);
            goShiftButton.Name = "goShiftButton";
            goShiftButton.Size = new Size(237, 178);
            goShiftButton.TabIndex = 1;
            goShiftButton.Text = "シフト管理を開く";
            goShiftButton.UseVisualStyleBackColor = true;
            goShiftButton.Click += goShiftButton_Click;
            // 
            // goWSButton
            // 
            goWSButton.Location = new Point(40, 50);
            goWSButton.Name = "goWSButton";
            goWSButton.Size = new Size(237, 178);
            goWSButton.TabIndex = 0;
            goWSButton.Text = "勤務状況画面を開く";
            goWSButton.UseVisualStyleBackColor = true;
            goWSButton.Click += goWSButton_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(1, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 492);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(599, 502);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(602, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(744, 486);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(602, 492);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(744, 502);
            dataGridView3.TabIndex = 4;
            // 
            // DashForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 994);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(panel1);
            Name = "DashForm";
            Text = "ダッシュボード";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button goStuffButton;
        private Button goShiftButton;
        private Button goWSButton;
        private Button backLoginButton;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}