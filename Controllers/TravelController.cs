using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Train_Management_System.Models;

namespace Train_Management_System.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Index()
        {
            TravelDBHandler IHandler = new TravelDBHandler();
            ModelState.Clear();
            return View(IHandler.GetItemList());

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
                    ViewBag.Travel = "Record inserted successfully";
                    ModelState.Clear();

                    return RedirectToAction("Index"); // Redirect to Index action after successful insertion
                }
                else
                {
                    ViewBag.Travel = "Error inserting record"; // Set an error message if insertion fails
                }
            }

            return View(iList); // Return the view with the model if ModelState is not valid or insertion fails
        }
        

        


        [HttpGet]
        public ActionResult Edit(int id)
        {
            TravelDBHandler ItemHandler = new TravelDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.Travel_ID == id));
        }


        [HttpPost]
        public ActionResult Edit(int id, TravelMaster iList)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TravelDBHandler ItemHandler = new TravelDBHandler();
                    ItemHandler.UpdateItem(iList);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while updating the item."); // Add a generic error message
                    return View(iList);
                }
            }
            return View(iList); // Return the view with validation errors if ModelState is not valid
        }


        public ActionResult Details(int id)
        {
            TravelDBHandler ItemHandler = new TravelDBHandler();
            return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.Travel_ID == id));
        }

        // 4. *********** Delete Item Details ***********
        public ActionResult Delete(int id)
        {
            try
            {
                TravelDBHandler ItemHandler = new TravelDBHandler();
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

