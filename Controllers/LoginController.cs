using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Train_Management_System.Constants;

namespace Train_Management_System.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con;

        private void connection()
        {
            con = new SqlConnection(ApplicatiuonConstants.ConnectionString);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
