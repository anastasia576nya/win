namespace WinFormsApp3
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
          
            // 
            // button1
            // 
            button1.Location = new Point(130, 100);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 14;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Пароль:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(92, 17);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(270, 23);
            textBoxUsername.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(92, 57);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 23);
            textBoxPassword.TabIndex = 13;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(19, 154);
            label3.Name = "label3";
            label3.Size = new Size(343, 15);
            label3.TabIndex = 15;
            label3.Text = "Для входа как гость нажмите кнопку войти не заполняя поля";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 184);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
    }
}
