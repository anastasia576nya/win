namespace WinFormsApp3
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblAvtor = new Label();
            lblPrice = new Label();
            lblName = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            pbPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // lblAvtor
            // 
            lblAvtor.AutoSize = true;
            lblAvtor.Location = new Point(310, 98);
            lblAvtor.Name = "lblAvtor";
            lblAvtor.Size = new Size(38, 15);
            lblAvtor.TabIndex = 17;
            lblAvtor.Text = "label7";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(310, 149);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 15);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "label6";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(310, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 15;
            lblName.Text = "label5";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(692, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "🗑️ Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(692, 36);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(170, 33);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "🖍️ Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(20, 29);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(234, 239);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 12;
            pbPhoto.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAvtor);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pbPhoto);
            Name = "UserControl1";
            Size = new Size(914, 311);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblAvtor;
        private Label lblPrice;
        private Label lblName;
        private Button btnDelete;
        private Button btnEdit;
        private PictureBox pbPhoto;
    }
}
