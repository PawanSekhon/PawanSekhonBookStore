using PawanBooks.DataAccess.Repository;
using PawanBooks.DataAccess.Repository.IRepository;
using PawanBooks.Models;
using PawanSekhonBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PawanBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db; //the using statement

        public UnitOfWork(ApplicationDbContext db)   //constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);

        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }





        IProductRepository IUnitOfWork.Product => throw new NotImplementedException();

        private IProductRepository GetProduct()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()  //all changes will be saved when the save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}