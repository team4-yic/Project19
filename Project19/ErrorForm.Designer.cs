namespace Project19
{
    partial class ErrorForm
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
            error = new Label();
            close = new Button();
            SuspendLayout();
            // 
            // error
            // 
            error.AutoSize = true;
            error.Location = new Point(33, 46);
            error.Name = "error";
            error.Size = new Size(245, 25);
            error.TabIndex = 0;
            error.Text = "3回連続でログインに失敗しました";
            // 
            // close
            // 
            close.Location = new Point(97, 74);
            close.Name = "close";
            close.Size = new Size(112, 34);
            close.TabIndex = 2;
            close.Text = "閉じる";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 148);
            Controls.Add(close);
            Controls.Add(error);
            Name = "ErrorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Error";
            Load += ErrorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label error;
        private Button close;
    }
}