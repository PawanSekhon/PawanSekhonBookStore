using PawanBooks.DataAccess.Repository.ICoverTypeRepository;
using PawanBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PawanBooks.DataAccess.Repository.IRepository
{
    public interface ICoverType
    {
        void Update(CoverType coverType);
    }
}
