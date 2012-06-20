using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveGrid.App.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeStatus Status { get; set; }
        //public Call LastCallAttended { get; set; }
    }
}