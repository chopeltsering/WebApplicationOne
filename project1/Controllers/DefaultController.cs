using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using project1.Model;

namespace project1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // post
        public ActionResult Msg(FormCollection formcollection)
        {
            //string path = @"C:\Users\Tsering\documents\visual studio 2015\Projects\WebApplicationOne\project1\msg.txt";
            string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "msg.txt";

            if (!System.IO.File.Exists(path))
            { 
                System.IO.File.Create(path);
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine("the very first line!");
                tw.Close();
            }
            else if (System.IO.File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine("\r\n");
                foreach (string key in formcollection.Keys)
                {
                    tw.WriteLine(key + " : " + formcollection[key]);
                }
                tw.Close();
            }
           
            return RedirectToAction("Index");
        }

        //Get: Resume
        public ActionResult Resume()
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
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

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
