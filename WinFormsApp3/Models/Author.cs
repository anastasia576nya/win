using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public short? BirthYear { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public string FullName => $"{LastName} {FirstName}";
}
