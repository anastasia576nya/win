using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        private Ispr2522KonkinMaLibraryDbContext context;
        private string userRole;
        private string userName;

        public MainForm(string role, string name = "")
        {
            InitializeComponent();
            userRole = role?.Trim();
            userName = string.IsNullOrEmpty(name) ? GetDefaultName(role) : name;

            lbl_Name.Text = $"Пользователь: {userName}";
            lbl_Role.Text = $"Роль: {userRole}";

            // Подписываем события
            txtSearch.TextChanged += (s, e) => LoadBooks();
            cmbSort.SelectedIndexChanged += (s, e) => LoadBooks();
            btnAdd.Click += BtnAdd_Click;
            btnSave.Click += BtnSave_Click;
            btn_Logout.Click += Btn_Logout_Click;

            LoadBooks();
        }

        private string GetDefaultName(string role) => role == "Гость" ? "Гость" : role;

        private void LoadBooks()
        {
            flowLayoutPanel.Controls.Clear();
            context = new Ispr2522KonkinMaLibraryDbContext();

            // Базовый запрос с подгрузкой данных
            var query = context.Books
                .Include(b => b.Authors)
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .AsQueryable();

            // ПОИСК (без кнопки, по всем полям)
            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(b =>
                    b.Title.ToLower().Contains(search) ||
                    b.PublicationYear.ToString().Contains(search) ||
                    b.Authors.Any(a => a.LastName.ToLower().Contains(search)) ||
                    b.Authors.Any(a => a.FirstName.ToLower().Contains(search)) ||
                    (b.Genre != null && b.Genre.GenreName.ToLower().Contains(search)) ||
                    (b.Publisher != null && b.Publisher.PublisherName.ToLower().Contains(search))
                );
            }

            // СОРТИРОВКА
            switch (cmbSort.SelectedItem?.ToString())
            {
                case "По автору":
                    query = query.OrderBy(b => b.Authors.FirstOrDefault().LastName);
                    break;
                case "По году":
                    query = query.OrderBy(b => b.PublicationYear);
                    break;
                default: // "По названию"
                    query = query.OrderBy(b => b.Title);
                    break;
            }

            var books = query.ToList();

            foreach (var book in books)
            {
                var control = new UserControl1();
                control.LoadBook(book, userRole);
                control.BookDeleted += (s, e) => LoadBooks();
                flowLayoutPanel.Controls.Add(control);
            }

            // Ограничение кнопок по ролям
            bool canEdit = (userRole == "Админ");
            btnAdd.Enabled = canEdit;
            btnSave.Enabled = canEdit;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var form = new EditBookForm();
            form.SetContext(context, null);
            if (form.ShowDialog() == DialogResult.OK)
                LoadBooks();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Сохранено!");
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}