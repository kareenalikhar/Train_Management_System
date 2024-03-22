using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Train_Management_System.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con;

        private void connection()
        {
            string strcon = "server=HP\\SQLEXPRESS;database=Trainmanagement;integrated security=true;";
            con = new SqlConnection(strcon);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
