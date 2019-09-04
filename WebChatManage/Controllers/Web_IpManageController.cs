using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebChatManage.Controllers
{
    public class Web_IpManageController : Controller
    {
        // GET: Web_IpManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: Web_IpManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Web_IpManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web_IpManage/Create
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

        // GET: Web_IpManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Web_IpManage/Edit/5
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

        // GET: Web_IpManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Web_IpManage/Delete/5
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