using Microsoft.AspNetCore.Mvc;
using System;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.About;

namespace Task_PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var info = new List<Info>
			{
                new Info { Id = 1 , Title = "Our Vision" , Desc = "Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
                new Info { Id = 2 , Title = "Our Mission" , Desc = "Eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam quis."},
                new Info { Id = 3 , Title = "Our Goal" , Desc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit,sed do eiusmod tempor."}
            };

            var model = new AboutIndexVM
            {
                Infos = info
            };

            return View(model);
        }
    }
}
