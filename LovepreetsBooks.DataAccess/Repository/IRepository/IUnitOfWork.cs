using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetsBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork
    {
        CategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}
