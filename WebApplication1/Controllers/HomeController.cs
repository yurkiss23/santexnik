using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        EFContext _context = new EFContext();

        [HttpPost]
        public void Add(string Email, string Password, string Name, string Phone, string Address)
        {
            User u = new User() { Name = Name, Email = Email, Password = Password, Phone = Phone, Address = Address, DoneServices = 0 };
            _context.Users.Add(u);
            _context.SaveChanges();
        }



        public ViewResult Index()
        {
            
            return View();
        }

        public ViewResult RegArea()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}