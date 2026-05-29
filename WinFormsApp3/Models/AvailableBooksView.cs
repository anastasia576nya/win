using System;
using System.Collections.Generic;

namespace WinFormsApp3.Models;

public partial class AvailableBooksView
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int? AvailableQuantity { get; set; }

    public string? Authors { get; set; }

    public string? GenreName { get; set; }

    public string? PublisherName { get; set; }
}
