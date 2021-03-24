﻿using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        // Add link to DB using DBContext
        private ApplicationDbContext _db = new ApplicationDbContext();
        
        // GET: Product
        public ActionResult Index()
        {
            return View(_db.Products.ToList());
        }
    }
}