using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Index()
        {
            return View();
        }

        // GET: Games/game1
        public ActionResult twoFourEight()
        {
            return PartialView("_twoFourEight");
        }

        // GET: Games/Create
        public ActionResult Tetris()
        {
            return PartialView("_Tetris");

        }

        public ActionResult aboutRepo()
        {
            return PartialView("_aboutRepo");

        }

        public ActionResult Pong()
        {
            int i = 1, j = 4;

            return PartialView("_Pong");

        }

        // POST: Games/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Games/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Games/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
