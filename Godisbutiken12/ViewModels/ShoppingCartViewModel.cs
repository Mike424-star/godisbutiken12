﻿using Godisbutiken12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart  ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
