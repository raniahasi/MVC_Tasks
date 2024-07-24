using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeCart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }


        public ActionResult Wishlist()
        {
            return View();
        }

        public ActionResult PCBuilder()
        {
            return View();
        }


        public ActionResult SubmitContact(FormCollection input)
        {

            ViewBag.Name = input["Name"];
            ViewBag.Age = input["Age"];
            ViewBag.Gender = input["Gender"];
            ViewBag.Country = input["Country"];
            ViewBag.Hobbies = input["Hobbies"];



            return RedirectToAction("ContactConfirmation", new
            {
                Name = ViewBag.Name,
                Age = ViewBag.Age,
                Gender = ViewBag.Gender,
                Country = ViewBag.Country,
                Hobbies = ViewBag.Hobbies
            });
        }
        public ActionResult ContactConfirmation(string Name, string Age, string Gender, string Country, string Hobbies)
        {
            ViewBag.Name = Name;
            ViewBag.Age = Age;
            ViewBag.Gender = Gender;
            ViewBag.Country = Country;
            ViewBag.Hobbies = Hobbies;
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (email == "raniahasi@gmail.com" && password == "12345678")
            {
                // Set session variable
                Session["UserName"] = "Rania";
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Message = "Invalid email or password";
                return View();
            }
        }

        public ActionResult Logout()
        {
            // Clear session
            Session["UserName"] = null;
            return RedirectToAction("Home");
        }

    }
    }
