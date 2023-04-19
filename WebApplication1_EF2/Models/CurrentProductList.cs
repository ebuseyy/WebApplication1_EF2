using System;
using System.Collections.Generic;

namespace WebApplication1_EF2.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
