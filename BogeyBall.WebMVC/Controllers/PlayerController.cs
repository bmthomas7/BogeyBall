using BogeyBall.Models;
using BogeyBall.Models.PlayerModel;
using BogeyBall.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;

namespace BogeyBall.WebMVC.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlayerService (userId);
            var model = service.GetPlayers();

            return View(model);
        }

        //add method here vvvv
        //get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreatePlayerService();

            if (service.CreatePlayer(model))
            {
                TempData["SaveResult"] = "Player has been Created";
                //ViewBag.SaveResult = "Player has been Created";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Player could not be created.");

            return View(model);

            
        }

        private PlayerService CreatePlayerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PlayerService(userId);
            return service;
        }

        public ActionResult Details(int id)
        {

            var svc = CreatePlayerService();
            var model = svc.GetPlayerById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePlayerService();
            var detail = service.GetPlayerById(id);
            var model =
                new PlayerEdit
                {
                    PlayerId = detail.PlayerId,
                    PlayerName = detail.PlayerName
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PlayerEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.PlayerId != id)
            {
                ModelState.AddModelError("", "Id not matched");
                return View(model);
            }


            var service = CreatePlayerService();

            if (service.UpdatePlayer(model))
            {
                TempData["SaveResult"] = "your palyer was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your player could not be updated");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {

            var svc = CreatePlayerService();
            var model = svc.GetPlayerById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {

            var service = CreatePlayerService();

            service.DeletePlayer(id);

            TempData["SaveResult"] = "Player was deleted";

            return RedirectToAction("Index");
        }

    }
}