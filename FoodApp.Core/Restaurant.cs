﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodApp.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CousineType Cousine { get; set; }
    }
}
