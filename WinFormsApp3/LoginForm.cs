using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            using var db = new Ispr2522KonkinMaLibraryDbContext();

            // Ищем пользователя в базе
            var user = await db.Users
                .FirstOrDefaultAsync(u => u.Name == login && u.Password == password);

            string role;
            string userName;

            if (user != null)
            {
                role = user.UserRole?.Trim();
                userName = user.Name;
            }
            else if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
            {
                role = "Гость";
                userName = "Гость";
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            // Передаем роль и имя в главную форму
            MainForm mainForm = new MainForm(role, userName);
            mainForm.Show();
            this.Hide();
        }
    }
}