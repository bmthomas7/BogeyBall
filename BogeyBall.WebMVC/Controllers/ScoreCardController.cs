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
    public class ScoreCardController : Controller
    {
        // GET: ScoreCard
        public ActionResult Index()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new ScoreCardService(userid);
            var model = service.GetScoreCard();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ScoreCardCreate model, int playerId)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateScoreCardService();
            if (service.CreateScoreCard(model, playerId))
            {
                TempData["SaveResults"] = "Score Card has been Created";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Score Card could not be created.");

            return View(model);


        }

        private ScoreCardService CreateScoreCardService()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new ScoreCardService(userid);
            return service;
        }

        public ActionResult Details(int id)
        {
            var svc = CreateScoreCardService();
            var model = svc.GetScoreCardById(id);

            return View(model);

        }

        public ActionResult Edit(int id)
        {
            var service = CreateScoreCardService();
            var detail = service.GetScoreCardById(id);
            var model =
                new ScoreCardEdit
                {
                    ScoreCardCourseName = detail.ScoreCardCourseName,
                    ScoreCardPlayerName = detail.ScoreCardPlayerName,
                    //CourseTeeTime = detail.CourseTeeTime
                };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ScoreCardEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.ScoreCardId != id)
            {
                ModelState.AddModelError("", "Id not matched");
                return View(model);
            }

            var service = CreateScoreCardService();

            if (service.UpdateScoreCard(model))
            {
                TempData["saveResult"] = "Your Score Card was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Score Card could not be updated");
            return View();

        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {

            var svc = CreateScoreCardService();
            var model = svc.GetScoreCardById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]  
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateScoreCardService();

            service.DeleteScoreCard(id);

            TempData["SaveResult"] = "Score Card was Deleted";

            return RedirectToAction("Index");
        }
    }
}