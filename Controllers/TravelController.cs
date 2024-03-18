using Microsoft.AspNetCore.Mvc;
using Train_Management_System.Models;

namespace Train_Management_System.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TravelMaster iList)
        {
            if (ModelState.IsValid)
            {
                TravelDBHandler ihandler = new TravelDBHandler();
                if (ihandler.insertItem(iList))
                {
                    ViewBag.message = "record inserted successfully";
                    ModelState.Clear();
                }
            }

            return View();
        }

    }
}
