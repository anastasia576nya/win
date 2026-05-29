using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class User
{
    public int IdUsers { get; set; }
    public string Name { get; set; } = null!;
    public string? Password { get; set; }
    public string UserRole { get; set; } = "Гость";  // ← значение по умолчанию
}