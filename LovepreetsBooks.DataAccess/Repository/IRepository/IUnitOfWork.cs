using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetsBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        CategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
                void Save();

    }
}
