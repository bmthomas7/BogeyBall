using BogeyBall.Models;
using BogeyBall.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BogeyBall.WebMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new CourseService(userid);
            var model = service.GetCourses();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCourseService();
            if (service.CreateCourse(model))
            {
                TempData["SaveResults"] = "Course has been Created";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Course could not be created.");

            return View(model);


        }

        private CourseService CreateCourseService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new CourseService(userid);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCourseService();
            var model = svc.GetCourseById(id);

            return View(model);

        }

        public ActionResult Edit(int id)
        {
            var service = CreateCourseService();
            var detail = service.GetCourseById(id);
            var model =
                new CourseEdit
                {
                    CourseName = detail.CourseName,
                    CourseId = detail.CourseId,
                    //CourseTeeTime = detail.CourseTeeTime
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CourseEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CourseId != id)
            {
                ModelState.AddModelError("", "Id not matched");
                return View(model);
            }

            var service = CreateCourseService();

            if (service.UpdateCourse(model))
            {
                TempData["saveResult"] = "Your Course was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your course could not be updated");
            return View();

        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {

            var svc = CreateCourseService();
            var model = svc.GetCourseById(id);

            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeletePost(int id)
        //{
        //    var service = CreateCourseService();

        //    service.DeleteCourse(id);

        //    TempData["SaveResult"] = "Course was Deleted";

        //    return RedirectToAction("Index");
        //}

    }
}