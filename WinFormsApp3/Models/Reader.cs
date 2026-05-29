using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Reader
{
    public int ReaderId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
