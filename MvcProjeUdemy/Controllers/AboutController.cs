using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeUdemy.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutcontent = abm.GetList();
            return View(aboutcontent);
        }
        [AllowAnonymous]
        public PartialViewResult Footer()
        {
            var aboutContentList=abm.GetList(); 
            return PartialView(aboutContentList);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager autman=new AuthorManager(new EfAuthorDal());
            var authorlist=autman.GetList();
            return PartialView(authorlist);
        }
        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist = abm.GetList(); 
            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            abm.TUpdate(p);
            return RedirectToAction("UpdateAboutList");   
        }
    }
}