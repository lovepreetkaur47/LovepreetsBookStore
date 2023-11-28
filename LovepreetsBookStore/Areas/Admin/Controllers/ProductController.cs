﻿using LovepreetsBooks.Models.ViewModels;
using LovepreetsBooks.DataAccess.Repository.IRepository;
using LovepreetsBooks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace LovepreetsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;  //to upload images on the server inside wwwroot

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)  //action method for upsert
        {
            ProductVM productVM = new ProductVM()   //using LovepreetsBooks.Models
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };
            if (id == null)
            {
                //this is for create
                return View(productVM);
            }
            //this for the edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM == null)
            {
                return NotFound();
            }
            return View(productVM);
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)        //checks all validation in the model(e.g Name Required) to increase security
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\products");
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }
                using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStreams);
                }
                productVM.Product.ImageUrl = @"\images\products\" + fileName + extension;
            }
            else
            {
                // update when they do not change the image
                if (productVM.Product.Id != 0)
                {
                    Product objFromDb = _unitOfWork.Product.Get(productVM.Product.Id);
                    productVM.Product.ImageUrl = objFromDb.ImageUrl;
                }
            }
            if (productVM.Product.Id == 0)
            {
                _unitOfWork.Product.Add(productVM.Product);
            }
            else
            {
                _unitOfWork.Product.Update(productVM.Product);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }
        else
        {
            ProductVM.CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
             productVM.CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
             {
                Text = i.Name,
                Value = i.Id.ToString()
              });
              if (productVM.Product.Id != 0)
              {
                productVM.Product = _unitOfWork.Product.Get(productVM.Product.Id);
              }
         }
         return View(productVM);
     }


        // API CALLS here
        #region API CALLS 
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category, CoverType");
            return Json(new { data = allObj });
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDb.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
