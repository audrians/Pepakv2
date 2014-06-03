using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppsTest
{
    public class HanacarakaUserController : Controller
    {
        private DigitalPepakEntities db = new DigitalPepakEntities();
        //
        // GET: /HanacarakaUser/
        public ActionResult Index()
        {
            var hanacaraka = db.Hanacaraka.Include(h => h.Kategori);
            return View(hanacaraka.ToList());
        }
	}
}