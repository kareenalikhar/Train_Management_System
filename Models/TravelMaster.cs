using Microsoft.VisualBasic;
using System.Runtime.Serialization;

namespace Train_Management_System.Models
{
    public class TravelMaster
    {
        public int Travel_ID { get; set; }
        public DateTime Travel_Date { get; set; }
        public int Train_ID {  get; set; }
        public string Source {  get; set; }
        public string Destination { get; set; }

        public string Class {  get; set; }
        public int Cost {  get; set; }

    }
}
