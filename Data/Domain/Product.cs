﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }
}
