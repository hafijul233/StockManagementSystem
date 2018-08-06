﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Item
    {
        public string Category { get; set; }
        public string Company { get; set; }
        public string Name{ get; set; }
        public double ReorderLevel{ get; set; }
        public double AvaliableQty { get; set;}

    }
}
