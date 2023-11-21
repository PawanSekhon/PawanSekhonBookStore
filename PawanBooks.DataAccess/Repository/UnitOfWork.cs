﻿using PawanBooks.DataAccess.Repository;
using PawanBooks.DataAccess.Repository.ICoverTypeRepository;
using PawanBooks.DataAccess.Repository.IRepository;
using PawanSekhonBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace PawanBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork     //make the method public to access the class
    {
        private readonly ApplicationDbContext _db;        //the using statement
        public UnitOfWork(ApplicationDbContext db)        // constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()     //all changes will be saved when the save method is called at the 'parent' level 
        {
            _db.SaveChanges();
        }
    }
}
