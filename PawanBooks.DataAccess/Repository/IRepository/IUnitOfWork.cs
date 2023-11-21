using System;

namespace PawanBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call {get;}

        ICoverTypeRepository CoverType { get; }

        void Save();
    }

    
}
