using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace Train_Management_System.Models
{
    public class TrainDBHandler
    {
        System.Data.SqlClient.
         SqlConnection con;
        private void connection()
        {
            string constring = "server=.\\sqlexpress;database=Trainmanagement;integrated security=true";
            con = new SqlConnection(constring);
        }

        //insert method 
        public bool insertItem(TrainMaster iList)
        {
            connection();

            string query = "INSERT INTO TrainMaster VALUES(" + iList.Train_ID + ",'" + iList.Train_Name + "'," + iList.Train_Capacity + ",'" + iList.Train_Status + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;

        }
        public List<TrainMaster> GetItemList()
        {
            List<TrainMaster> li = new List<TrainMaster>();

            connection();
            con.Open();
            string cmd = "select * from TrainMaster";
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TrainMaster");
            foreach (DataRow dr in ds.Tables["TrainMaster"].Rows)
            {

                li.Add(new TrainMaster
                {
                    Train_ID = Convert.ToInt32(dr["Train_ID"]),
                    Train_Name = Convert.ToString(dr["Train_Name"]),
                    Train_Capacity = Convert.ToInt32(dr["Train_Capacity"]),
                    Train_Status = Convert.ToString(dr["Train_Status"])
                });


            }
            
            return li;
        }

        //update
        public bool UpdateItem(TrainMaster iList)
        {
            connection();
            string query = "UPDATE TrainMaster SET Train_Name = '" + iList.Train_Name + "', Train_Capacity = " + iList.Train_Capacity + ", Train_Status = '" + iList.Train_Status + "' WHERE Train_ID = " + iList.Train_ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool DeleteItem(int Train_ID)
        {
            try
            {
                connection(); // Assuming this method sets up the connection

                string query = "DELETE FROM TrainMaster WHERE Train_ID = @Train_ID";
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for Travel_ID
                cmd.Parameters.AddWithValue("@Train_ID", Train_ID);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                return i > 0; // Return true if at least one row was affected, false otherwise
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error in DeleteItem method: " + ex.Message);
                return false; // Return false to indicate deletion failure
            }
        }



    }
}


