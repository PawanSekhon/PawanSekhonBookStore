using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PawanBooks.DataAccess.Repository.IRepository;
using PawanBooks.Models;

namespace PawanSekhonBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)      // action method for Upsert 
        {
            Category category = new Category();    // using PawanBooks.Models 
            if (id == null)
            {
                // this is for create
                return View(category);
            }
            // this for the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View();
        }

        // use HTTPS POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid)      // checks all validations in the model(e.g. Name required) to increase security
            {
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.Category.Update(category);
            }
            return View(category);
        }

        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion

    }
}
