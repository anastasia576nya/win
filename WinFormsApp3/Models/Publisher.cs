using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string PublisherName { get; set; } = null!;

    public string? City { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
