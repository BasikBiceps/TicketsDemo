﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsDemo.Domain.DefaultImplementations
{
    public class Prices
    {
        static public decimal Tea { get; set; } = 10.50M;
        static public decimal Coffee { get; set; } = 12.30M;
        static public decimal CashDeskLimit { get; set; } = 30M;
        static public decimal CashDeskMultiplier { get; set; } = 0.2m;
    }
}
