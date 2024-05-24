using Employee.DataEntity;
using EmployeeRepositery.Repositiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace EmployeeRepositery.Concreate
{
    public class StateDetailsRepositiry : IStateDetailsRepositiry
    {
        private readonly EmployeedbContext context;

        public StateDetailsRepositiry()
        {
            context = new EmployeedbContext();
        }

        public StateDetail GetStateDetails(int id)
        {
            return context.StateDetails.Find(id);
        }

        StateDetail IStateDetailsRepositiry.GetStateDetail(int id)
        {
            return context.StateDetails.Find(id);
        }

        List<StateDetail> IStateDetailsRepositiry.GetStateDetails()
        {
            return context.StateDetails.ToList();
        }
    }
}
