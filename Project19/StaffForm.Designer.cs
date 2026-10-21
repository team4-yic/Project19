namespace Project19
{
    partial class StaffForm
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
            PTJListView = new DataGridView();
            FullNameTextBox = new TextBox();
            seachPTJTextBox = new Button();
            deletePTJTextBox = new Button();
            UserNameTextBox = new TextBox();
            TellTextBox = new TextBox();
            EmailTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PTJListView).BeginInit();
            SuspendLayout();
            // 
            // PTJListView
            // 
            PTJListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PTJListView.Location = new Point(1, 104);
            PTJListView.Name = "PTJListView";
            PTJListView.RowHeadersWidth = 62;
            PTJListView.Size = new Size(1000, 423);
            PTJListView.TabIndex = 0;
            PTJListView.CellContentClick += PTJListView_CellContentClick;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(12, 12);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "氏名";
            FullNameTextBox.Size = new Size(408, 31);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.TextChanged += addNameTextBox_TextChanged;
            // 
            // seachPTJTextBox
            // 
            seachPTJTextBox.Location = new Point(866, 9);
            seachPTJTextBox.Name = "seachPTJTextBox";
            seachPTJTextBox.Size = new Size(124, 75);
            seachPTJTextBox.TabIndex = 5;
            seachPTJTextBox.Text = "検索";
            seachPTJTextBox.UseVisualStyleBackColor = true;
            // 
            // deletePTJTextBox
            // 
            deletePTJTextBox.Location = new Point(866, 533);
            deletePTJTextBox.Name = "deletePTJTextBox";
            deletePTJTextBox.Size = new Size(122, 77);
            deletePTJTextBox.TabIndex = 6;
            deletePTJTextBox.Text = "削除";
            deletePTJTextBox.UseVisualStyleBackColor = true;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(426, 12);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.PlaceholderText = "ユーザーネーム";
            UserNameTextBox.Size = new Size(434, 31);
            UserNameTextBox.TabIndex = 7;
            // 
            // TellTextBox
            // 
            TellTextBox.Location = new Point(426, 53);
            TellTextBox.Name = "TellTextBox";
            TellTextBox.PlaceholderText = "電話番号";
            TellTextBox.Size = new Size(434, 31);
            TellTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(12, 53);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "E-メール";
            EmailTextBox.Size = new Size(408, 31);
            EmailTextBox.TabIndex = 8;
            // 
            // StuffForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 622);
            Controls.Add(TellTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(deletePTJTextBox);
            Controls.Add(seachPTJTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(PTJListView);
            Name = "StuffForm";
            Text = "スタッフ追加・削除";
            Load += PTJForm_Load;
            ((System.ComponentModel.ISupportInitialize)PTJListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PTJListView;
        private TextBox FullNameTextBox;
        private Button seachPTJTextBox;
        private Button deletePTJTextBox;
        private TextBox UserNameTextBox;
        private TextBox TellTextBox;
        private TextBox EmailTextBox;
    }
}