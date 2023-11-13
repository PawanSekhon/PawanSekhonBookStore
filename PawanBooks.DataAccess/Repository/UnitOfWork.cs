using System;
using PawanBooks.DataAccess.Repository.IRepository;
using PawanSekhonBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Text;

namespace PawanBooks.DataAccess.Repository
{
    public class UnitOfWork       //make the method public to access the class
    {
        private readonly ApplicationDbContext _db;        //the using statement
        public UnitOfWork(ApplicationDbContext db)        // constructor to use DI and inject in to the repositories
        {
            _db = db;
            CategoryRepository = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
    }
}
