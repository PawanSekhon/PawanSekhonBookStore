using PawanBooks.DataAccess.Repository.IRepository;
using PawanBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PawanSekhonBookStore.DataAccess.Data;

namespace PawanBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(CoverType coverType)
        {
            //us .NET LINQ to retrieve the first or default category object,
            //thn pass the id as a generic entity which matches the category ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //save changes if not null 
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }

            throw new NotImplementedException();
        }
    }
}