using PawanBooks.DataAccess.Repository.IRepository;
using PawanBooks.Models;
using PawanSekhonBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PawanBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private class ApplicationDbContext_db
        {

            public CategoryRepository(ApplicationDbContext db) : base(db)
            {
                _db = db;
            }
        }
    }
}
