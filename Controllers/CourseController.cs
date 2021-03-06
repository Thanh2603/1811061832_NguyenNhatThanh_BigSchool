using _1811061832_NguyenNhatThanh_BigSchool.Models;
using _1811061832_NguyenNhatThanh_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811061832_NguyenNhatThanh_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Course
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
            {

                var course  = new Course
                {
                    LecturerId = User.Identity.GetUserId(),
                    DateTime = viewModel.GetDateTime(),
                    CategoryId = viewModel.Category,
                    Place = viewModel.Place
                };
                _dbContext.Courses.Add(course);
                _dbContext.SaveChanges();
                return View();
            }
  
    }
}