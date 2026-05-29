using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public int BookId { get; set; }

    public int ReaderId { get; set; }

    public DateOnly LoanDate { get; set; }

    public DateOnly DueDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Reader Reader { get; set; } = null!;
}
