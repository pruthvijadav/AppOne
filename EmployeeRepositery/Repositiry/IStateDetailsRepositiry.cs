using Employee.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.DataEntity;

namespace EmployeeRepositery.Repositiry
{
    public  interface IStateDetailsRepositiry
    {
        List<StateDetail> GetStateDetails();

        StateDetail GetStateDetail(int id);
    }
}
