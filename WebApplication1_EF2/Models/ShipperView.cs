using System;
using System.Collections.Generic;

namespace WebApplication1_EF2.Models;

public partial class ShipperView
{
    public int Id { get; set; }

    public string ŞirketAdı { get; set; } = null!;

    public string? Telefon { get; set; }
}
