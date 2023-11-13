using PawanBooks.DataAccess.Repository.IRepository;
using PawanSekhonBookStore.DataAccess.Data;
using PawanBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PawanBooks.DataAccess.Repository;

namespace PawanBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
        
    }
}