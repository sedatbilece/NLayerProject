﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Models
{
    class Product
    {


        public int Id { get; set; }
        public int Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public bool IsDelete { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }// this virtual for tracking database and one object 
    }
}
