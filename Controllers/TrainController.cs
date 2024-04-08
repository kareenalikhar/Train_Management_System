using Microsoft.AspNetCore.Mvc;
using System.Data;
using Train_Management_System.Models;
using Train_Management_System.Dto;
using Train_Management_System.Services;
using Train_Management_System.Services.ServiceImpl;
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
            TravelDBHandler handler = new TravelDBHandler();  
            return View(handler.GetItemList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TrainMasterRequestDto iList)
        {
            TrainServiceInterface trainServiceInterface = new TrainServiceImpl();
            trainServiceInterface.AddTrain(iList);

            return View();


        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            TravelDBHandler ItemHandler = new TravelDBHandler();
            return View(ItemHandler.GetItemList().Find(TrainMaster => TrainMaster.Train_ID == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, TrainMaster iList)
        {
            /* try
             {
                 TravelDBHandler ItemHandler = new TravelDBHandler();
                 ItemHandler.UpdateItem(iList);
                 return RedirectToAction("Index");
             }
             catch { return View(); }*/
            return View();
        }


        public IActionResult Details(int id)
        {
            TravelDBHandler itemhandler = new TravelDBHandler();
            return View(itemhandler.GetItemList().Find(TrainMaster => TrainMaster.Train_ID == id));
        }

        public IActionResult Delete(int id)
        {
            try
            {
                TravelDBHandler ItemHandler = new TravelDBHandler();
                if (ItemHandler.DeleteItem(id))
                {
                    ViewBag.AlertMsg = "Item Deleted Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.AlertMsg = "Error deleting item"; // Set an error message if deletion fails
                }
                
            }
            catch (Exception ex)
            {
                ViewBag.AlertMsg = "An error occurred: " + ex.Message; // Display a generic error message
                // You might want to return to a specific view for error handling
            }
            return View();
        }
    }
}