﻿using System;
using System.Collections.Generic;

namespace BookLibrary.DataAccess;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int BookId { get; set; }

    public int Quantity { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
