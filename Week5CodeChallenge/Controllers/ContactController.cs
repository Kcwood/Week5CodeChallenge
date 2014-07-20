using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week5CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            //Create a new contact form object
            // pass to our view
            Models.ContactInfo cf = new Models.ContactInfo();
            return View(cf);
        }

        [HttpPost]
        public ActionResult Index(Models.ContactInfo cf)
        {
            //Create a new connection to our database
            Models.KyleEntities db = new Models.KyleEntities();
            //Add the contact info to the database
            db.ContactInfoes.Add(cf);
            //save changes to the database
            db.SaveChanges();
            //Redirect user to the thank you page
            return RedirectToAction("ThankYou");
        }

        // GET: /Home/ThankYou
        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
