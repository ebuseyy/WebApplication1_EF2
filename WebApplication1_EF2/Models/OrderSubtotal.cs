﻿using System;
using System.Collections.Generic;

namespace WebApplication1_EF2.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
