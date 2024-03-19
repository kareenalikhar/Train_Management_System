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
            connection(); // Assuming this method sets up the connection

            string query = "INSERT INTO TravelMaster VALUES(@TravelID, @TravelDate, @TrainID, @Source, @Destination,@Class, @Cost)";
            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@TravelID", iList.Travel_ID);
            cmd.Parameters.AddWithValue("@TravelDate", iList.Travel_Date);
            cmd.Parameters.AddWithValue("@TrainID", iList.Train_ID);
            cmd.Parameters.AddWithValue("@Source", iList.Source);
            cmd.Parameters.AddWithValue("@Destination", iList.Destination);
            cmd.Parameters.AddWithValue("@Class",iList.Class);
            cmd.Parameters.AddWithValue("@Cost", iList.Cost);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i >= 1; // Return true if at least one row was affected, false otherwise
        }

        //get all items from itemlist table 
        public List<TravelMaster> GetItemList()
        {
            connection();
            List<TravelMaster> li = new List<TravelMaster>();
            string cmd = "select * from TravelMaster";
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TravelMaster");
            foreach (DataRow dr in ds.Tables["TravelMaster"].Rows)
            {

                li.Add(new TravelMaster
                {
                    Travel_ID = Convert.ToInt32(dr["Travel_ID"]),
                    Travel_Date = Convert.ToDateTime(dr["Travel_Date"]),
                    Train_ID = Convert.ToInt32(dr["Train_ID"]),
                    Source = Convert.ToString(dr["Source"]),
                    Destination = Convert.ToString(dr["Destination"]),
                    Class = Convert.ToString(dr["Class"]),
                    Cost = Convert.ToInt32(dr["Cost"])
                });


            }


            return li;

        }


        //update method
        // 3. ********** Update Item Details **********
        public bool UpdateItem(TravelMaster iList)
        {
            connection(); // Assuming this method sets up the connection

            string query = "UPDATE TravelMaster SET Travel_Date = @TravelDate, Train_ID = @TrainID, Source = @Source, Destination = @Destination,Class=@Class, Cost = @Cost WHERE Travel_ID = @TravelID";
            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@TravelDate", iList.Travel_Date);
            cmd.Parameters.AddWithValue("@TrainID", iList.Train_ID);
            cmd.Parameters.AddWithValue("@Source", iList.Source);
            cmd.Parameters.AddWithValue("@Destination", iList.Destination);
            cmd.Parameters.AddWithValue("@Class",iList.Class);
            cmd.Parameters.AddWithValue("@Cost", iList.Cost);
            cmd.Parameters.AddWithValue("@TravelID", iList.Travel_ID);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i >= 1; // Return true if at least one row was affected, false otherwise
        }


        // 4. ********** Delete Item **********
        public bool DeleteItem(int Travel_ID)
        {
            try
            {
                connection(); // Assuming this method sets up the connection

                string query = "DELETE FROM TravelMaster WHERE Travel_ID = @TravelID";
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for Travel_ID
                cmd.Parameters.AddWithValue("@TravelID", Travel_ID);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                return i >= 1; // Return true if at least one row was affected, false otherwise
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("Error in DeleteItem method: " + ex.Message);
                return false; // Return false to indicate deletion failure
            }
        }
        public decimal GetCost(string source, string destination, string travelClass)
        {
            connection(); // Assuming this method sets up the connection

            string query = "SELECT Cost FROM Cost WHERE Source = @Source AND Destination = @Destination AND Class = @Class";
            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@Source", source);
            cmd.Parameters.AddWithValue("@Destination", destination);
            cmd.Parameters.AddWithValue("@Class", travelClass);

            con.Open();
            decimal cost = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();

            return cost;
        }


    }
}
