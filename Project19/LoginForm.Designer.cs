namespace Project19
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passTextBox = new TextBox();
            goDashButton = new Button();
            idErrorlabel = new Label();
            passErrorlabel = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(218, 94);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(357, 31);
            idTextBox.TabIndex = 0;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 94);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 1;
            label1.Text = "管理者ID：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 175);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "パスワード：";
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(218, 172);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(357, 31);
            passTextBox.TabIndex = 2;
            passTextBox.TextChanged += passTextBox_TextChanged_1;
            // 
            // goDashButton
            // 
            goDashButton.Location = new Point(240, 269);
            goDashButton.Name = "goDashButton";
            goDashButton.Size = new Size(200, 60);
            goDashButton.TabIndex = 4;
            goDashButton.Text = "ログイン";
            goDashButton.UseVisualStyleBackColor = true;
            goDashButton.Click += goDashButton_Click_1;
            // 
            // idErrorlabel
            // 
            idErrorlabel.AutoSize = true;
            idErrorlabel.Location = new Point(218, 128);
            idErrorlabel.Name = "idErrorlabel";
            idErrorlabel.Size = new Size(212, 25);
            idErrorlabel.TabIndex = 5;
            idErrorlabel.Text = "管理者IDを入力してください";
            idErrorlabel.Visible = false;
            // 
            // passErrorlabel
            // 
            passErrorlabel.AutoSize = true;
            passErrorlabel.Location = new Point(218, 206);
            passErrorlabel.Name = "passErrorlabel";
            passErrorlabel.Size = new Size(207, 25);
            passErrorlabel.TabIndex = 6;
            passErrorlabel.Text = "パスワードを入力してください";
            passErrorlabel.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(218, 50);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(217, 25);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "IDとパスワードが一致しません";
            errorLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 412);
            Controls.Add(errorLabel);
            Controls.Add(passErrorlabel);
            Controls.Add(idErrorlabel);
            Controls.Add(goDashButton);
            Controls.Add(label2);
            Controls.Add(passTextBox);
            Controls.Add(label1);
            Controls.Add(idTextBox);
            Name = "LoginForm";
            Text = "ログイン画面";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextBox;
        private Label label1;
        private Label label2;
        private TextBox passTextBox;
        private Button goDashButton;
        private Label idErrorlabel;
        private Label passErrorlabel;
        private Label errorLabel;
    }
}
