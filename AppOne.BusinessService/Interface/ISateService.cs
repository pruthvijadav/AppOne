using AppOne.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOne.BusinessService.Interface
{
    public interface ISateService
    {
        List<StateViewModel> GetStateDetail();

        StateViewModel GetStateDetails(int id);
       
    }
}
