using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Train_Management_System.Models
{
    public class LoginDBHandler : Controller
    {
        SqlConnection con;

        private void connection()
        {
            string constring = "server=.\\sqlexpress;database=Trainmanagement;integrated security=true";
            con = new SqlConnection(constring);
        }
        public void Registation(Login reg)
        {
            try
            {
                connection();
                string query = "INSERT +INTO TrainMaster VALUES(" + reg.Name + ",'" + reg.Email + "'," + reg.Contact + ",'" + reg.Password + "','" + reg.ConfirmPassword + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
