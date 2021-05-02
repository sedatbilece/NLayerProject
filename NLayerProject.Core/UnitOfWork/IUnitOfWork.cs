using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.UnitOfWork
{
    interface IUnitOfWork
    {
        // this about your wish
        IProductRepository products { get; }

        ICategoryRepository categories { get; }





        // this is our func interface
        Task CommitAsync();

        void Commit();

    }
}
