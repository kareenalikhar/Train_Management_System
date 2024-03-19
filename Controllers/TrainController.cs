using Microsoft.AspNetCore.Mvc;
using System.Data;
using Train_Management_System.Models;
using System.Data;
using System.Data.SqlClient;

namespace Train_Management_System.Controllers
{
    public class TrainController : Controller
    {
        SqlConnection con;

        private void connection()
        {
            string strcon = "server=HP\\SQLEXPRESS;database=Trainmanagement;integrated security=true;";
            con = new SqlConnection(strcon);
        }

       public IActionResult Index()
        {
            TrainDBHandler handler = new TrainDBHandler();  
            return View(handler.GetItemList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TrainMaster iList)
        {
            if (ModelState.IsValid)
            {
                TrainDBHandler ihandler = new TrainDBHandler();
                if (ihandler.insertItem(iList))
                {
                    ViewBag.message = "record inserted successfully";
                    ModelState.Clear();
                }
            }

            return View();


        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            TrainDBHandler ItemHandler = new TrainDBHandler();
            return View(ItemHandler.GetItemList().Find(TrainMaster => TrainMaster.Train_ID == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, TrainMaster iList)
        {
            try
            {
                TrainDBHandler ItemHandler = new TrainDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }


        public IActionResult Details(int id)
        {
            TrainDBHandler itemhandler = new TrainDBHandler();
            return View(itemhandler.GetItemList().Find(TrainMaster => TrainMaster.Train_ID == id));
        }

        public IActionResult Delete(int id)
        {
            try
            {
                TrainDBHandler ItemHandler = new TrainDBHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                }
                else
                {
                    ViewBag.AlertMsg = "Error deleting item"; // Set an error message if deletion fails
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.AlertMsg = "An error occurred: " + ex.Message; // Display a generic error message
                return View(); // You might want to return to a specific view for error handling
            }
        }



    }
}