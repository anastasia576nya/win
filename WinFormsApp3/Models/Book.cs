using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Isbn { get; set; }

    public short? PublicationYear { get; set; }

    public int? Quantity { get; set; }

    public int? AvailableQuantity { get; set; }

    public int? GenreId { get; set; }

    public int? PublisherId { get; set; }

    public virtual Genre? Genre { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual Publisher? Publisher { get; set; }

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
