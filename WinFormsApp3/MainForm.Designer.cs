namespace WinFormsApp3
{
    partial class MainForm
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
            flowLayoutPanel = new FlowLayoutPanel();
            btnAdd = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            txtSearch = new TextBox();
            cmbSort = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btn_Logout = new Button();
            lbl_Role = new Label();
            lbl_Name = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.LavenderBlush;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(4, 113);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(963, 333);
            flowLayoutPanel.TabIndex = 3;
            flowLayoutPanel.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(171, 462);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "➕ Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(4, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "✨ Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 90);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aquamarine;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(cmbSort);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(241, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 33);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Поиск";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(56, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(149, 23);
            txtSearch.TabIndex = 1;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(313, 9);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(142, 23);
            cmbSort.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Сортировка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(512, 9);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 5;
            label3.Text = "РАБОЧАЯ ЗОНА";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Controls.Add(btn_Logout);
            panel2.Controls.Add(lbl_Role);
            panel2.Controls.Add(lbl_Name);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 90);
            panel2.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(12, 64);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(75, 23);
            btn_Logout.TabIndex = 2;
            btn_Logout.Text = "Выйти";
            btn_Logout.UseVisualStyleBackColor = true;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new Point(12, 35);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(37, 15);
            lbl_Role.TabIndex = 1;
            lbl_Role.Text = "Роль:";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(12, 9);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(34, 15);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Имя:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(969, 525);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Name = "MainForm";
            Text = "Библиотека - Главная форма";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button btnAdd;
        private Button btnSave;
        private Panel panel1;
        private Panel panel2;
        private Button btn_Logout;
        private Label lbl_Role;
        private Label lbl_Name;
        private Label label2;
        private Label label1;
        private ComboBox cmbSort;
        private TextBox txtSearch;
        private Panel panel3;
        private Label label3;
    }
}