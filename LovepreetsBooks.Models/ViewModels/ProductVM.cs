using LovepreetsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LovepreetsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }   //Displays all the product details
        public IEnumerable<SelectListItem> CategoryList { get; set; }  //install package "Microsoft.AspNetCore.Mvc.ViewFeatures"
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
