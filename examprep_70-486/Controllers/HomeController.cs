using examprep_70_486.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examprep_70_486.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(new PartialModel2() { partialModel = Sampledetails() });
            //            return View();
        }

        private List<PartialModel2> Sampledetails()
        {
            List<PartialModel2> model = new List<PartialModel2>();

            model.Add(new PartialModel2()
            {
                Name = "Rima",
                Age = 20,
                Address = "Kannur"
            });

            model.Add(new PartialModel2()
            {
                Name = "Rohan",
                Age = 23,
                Address = "Ernakulam"
            });
            model.Add(new PartialModel2()
            {
                Name = "Reshma",
                Age = 22,
                Address = "Kannur"
            });

            return model;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Your users page.";

            var users = new List<User>
            {
                new Models.User
                {
                    FirstName = "Dries",
                    MiddleInitial = "",
                    LastName = "Peeters",
                    DateOfBirth = new DateTime(1990,9,11),
                    UserName = "d.peeters",
                    IsAdmin = true,
                    Roles = new List<Role> { new Role { Name = "Software Engineer" } },
                    Addresses = new List<Address> {
                        new Address { StreetAddress = "Langstraat", PostalCode = "2260", State = "Antwerp", City = "Westerlo"},
                        new Address2 { StreetAddress = "Jenny Tanghe", PostalCode = "9005", State = "Eatern Flanders", City = "Ledeberg", IsBuitenverblijf=true}
                    }
                },
                new Models.User
                {
                    FirstName = "Sam",
                    MiddleInitial = "",
                    LastName = "Segers",
                    DateOfBirth = new DateTime(1989,5,31),
                    UserName = "s.segers",
                    IsAdmin = true,
                    Roles = new List<Role> { new Role { Name = "Software Engineer" } },
                    Addresses = new List<Address> { new Address { StreetAddress = "Wilgenweg", PostalCode = "2890", State = "Antwerp", City = "Oppuurs"} }
                }
            };

            return View(users);
        }
    }
}