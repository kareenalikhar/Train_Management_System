using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Train_Management_System.Models
{
    public class TravelDBHandler
    {
        System.Data.SqlClient.
         SqlConnection con;
        private void connection()
        {
            string constring = "server=.\\sqlexpress;database=Trainmanagement;integrated security=true";
            con = new SqlConnection(constring);
        }
        //insert method 
        public bool insertItem(TravelMaster iList)
        {
            connection();

            string query = "INSERT INTO TravelMaster VALUES(" + iList.Travel_ID + "," + iList.Travel_Date + "," + iList.Train_ID + ",'" + iList.Source + "','" + iList.Destination + "'," + iList.Cost + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;

        }


    }
}
