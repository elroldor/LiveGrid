using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveGrid.App.Models
{
    //DONT ASK _________  This is &*^*$#$%#@
    public class CallCenterRepository
    {
        private List<Agent> agents = new List<Agent>
            {
                new Agent{Id=1, FirstName="Andrew",LastName="Fuller", Status=EmployeeStatus.Free},
                new Agent{Id=2, FirstName="Nancy",LastName="Davolio", Status=EmployeeStatus.Free},
                new Agent{Id=3, FirstName="Janet",LastName="Leverling", Status=EmployeeStatus.Free},
                new Agent{Id=4, FirstName="Steven",LastName="Buchanan", Status=EmployeeStatus.Free}
            };

        private List<Call> calls;

        public CallCenterRepository()
        {
            calls = new List<Call>
            {
                new Call { Id = 1, Agent=GetAgent(1), CustomerId=1, StartDateTime=DateTime.Now.AddDays(-1), EndDateTime=DateTime.Now, Status=CallStatus.Pending },
                new Call { Id = 2, Agent=GetAgent(2), CustomerId=2, StartDateTime=DateTime.Now.AddDays(-2.2), EndDateTime=DateTime.Now, Status=CallStatus.Pending },
                new Call { Id = 3, Agent=GetAgent(3), CustomerId=3, StartDateTime=DateTime.Now.AddDays(-1.5), EndDateTime=DateTime.Now, Status=CallStatus.Resolved },
                new Call { Id = 4, Agent=GetAgent(4), CustomerId=4, StartDateTime=DateTime.Now.AddDays(-1.1), EndDateTime=DateTime.Now, Status=CallStatus.Resolved }
            };
        }

        public List<Agent> GetAllAgents()
        {
            return agents;
        }

        public Agent GetAgent(int id)
        {
            return agents.FirstOrDefault(a => a.Id == id);
        }

        public List<Call> GetAllCalls()
        {
            return calls;
        }

        public Call GetCall(int id)
        {
            return calls.FirstOrDefault(a => a.Id == id);
        }
    }
}