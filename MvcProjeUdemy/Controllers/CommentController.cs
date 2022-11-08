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
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm=new CommentManager(new EfCommentDal());
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var commentList = cm.CommentByBlog(id);
            return PartialView(commentList);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id=id;  
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult LeaveComment(Comment p)
        {
            p.CommentStatus = true;
            cm.TAdd(p);
            return PartialView();
        }
        public ActionResult AdminCommentListTrue()
        {
            var commentlist=cm.CommentByStatusTrue();   
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = cm.CommentByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }

    }
}