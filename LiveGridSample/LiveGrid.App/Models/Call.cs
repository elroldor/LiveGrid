using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveGrid.App.Models
{
    public class Call
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Agent Agent { get; set; }
        public CallStatus Status { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
