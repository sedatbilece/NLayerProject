using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IProcuctService :IService<Product>
    {

        Task<Product> GetWithCategoryByIdAsync(int productid);



        //for other operations func maybe( not database )
        // bool ControlInnerBarcode(Product prd);


    }
}
