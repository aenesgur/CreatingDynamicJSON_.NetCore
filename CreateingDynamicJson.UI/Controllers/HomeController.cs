using CreatingDynamicJson.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CreatingDynamicJson.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var author = CreateDummyData();
            return View(author);
        }

        private Author CreateDummyData()
        {
            return new Author()
            {

                Id = 1,
                Name = "Dan Brown",
                Citizen = "USA",
                Novels = new List<Novel>
                {
                    new Novel
                    {
                        Id = 1,
                        Name = "The Da Vinci Code",
                        NumberOfPage = 475
                    },
                    new Novel
                    {
                        Id = 2,
                        Name = "Inferno",
                        NumberOfPage = 300
                    },
                    new Novel
                    {
                        Id = 3,
                        Name = "The LAst Symbol",
                        NumberOfPage = 257
                    },
                    new Novel
                    {
                        Id = 3,
                        Name = "Angels And Demons",
                        NumberOfPage = 541
                    }
                }
            };
        }

    }
}
