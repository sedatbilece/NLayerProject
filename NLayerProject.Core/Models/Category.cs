using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Models
{
    public class Category
    {


        public Category()
        {
            Products = new Collection<Product>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public bool IsDelete { get; set; }

        public ICollection<Product> Products { get; set; }// this here is emurable list 
    }
}
