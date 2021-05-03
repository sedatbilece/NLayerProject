using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Models
{
    public  class Product
    {


        public int Id { get; set; }
        public String Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public bool IsDelete { get; set; }

        public int CategoryId { get; set; }
        public int InnerBarcode { get; set; }
        

        public virtual Category Category { get; set; }// this virtual for tracking database and one object 
    }
}
