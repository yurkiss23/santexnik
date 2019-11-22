using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        EFContext _context = new EFContext();

        [HttpPost]
        public void Add(string Email, string Password, string Name, string Phone, string Address)
        {
            Users u = new Users() { Name = Name, Email = Email, Password = Password, Phone = Phone, Address = Address};
            _context.Users.Add(u);
            _context.SaveChanges();
        }

        [HttpGet]
        public ActionResult SignIn(string Email, string Password)
        {

            var res = _context.Users.FirstOrDefault((x) => x.Email == Email && x.Password == Password);
            if (res != null)
                return Json(Url.Action("Index", "Kabinet", new { id = res.Id }));
            else
                return null;
        }

        public ViewResult Kabinet(string Email, string Password)
        {

            var res = _context.Users.FirstOrDefault((x) => x.Email == Email && x.Password == Password);
            if (res != null)
            {
                ViewBag.obj = res;
                return View();
            }
            else return null;
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