using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckEntryApp
{
    public class DataBaseModels
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Roll {  get; set; }

    }

    public class Data
    {
        public int Id { get; set; }
        public int TransactionNo { get; set; }
        public string TruckNo { get; set; }
        public string DL_No{ get; set; }
        public string PhoneNumber{ get; set; }
        public string AgentName { get; set; }
        public string DriverName { get; set; }
    }

}
