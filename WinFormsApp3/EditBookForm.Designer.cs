namespace WinFormsApp3
{
    partial class EditBookForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            comboBoxAuthor = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 212);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 14;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 13;
            label1.Text = "Название";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(47, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 37);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "ОТМЕНА";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(47, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "СОХРАНИТЬ";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(35, 230);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(165, 23);
            comboBoxAuthor.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(33, 140);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(167, 23);
            textBoxPrice.TabIndex = 9;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(33, 63);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(167, 23);
            textBoxName.TabIndex = 8;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 445);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboBoxAuthor);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "EditBookForm";
            Text = "EditBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox comboBoxAuthor;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
    }
}