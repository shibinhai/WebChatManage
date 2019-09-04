using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebChatManage.Controllers
{
    public class Web_BatchManageController : Controller
    {
        // GET: Web_BatchManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: Web_BatchManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Web_BatchManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web_BatchManage/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Web_BatchManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Web_BatchManage/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Web_BatchManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Web_BatchManage/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}