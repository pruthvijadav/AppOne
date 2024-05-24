using AppOne.BusinessEntity;
using AppOne.BusinessService.Interface;
using EmployeeRepositery.Concreate;
using EmployeeRepositery.Repositiry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comman;
using static AppOne.BusinessService.Concret.StateSevice;

namespace AppOne.BusinessService.Concret
{
    public class StateSevice : ISateService
    {
        private readonly IStateDetailsRepositiry _repo;

        public StateSevice()
        {
            _repo = new StateDetailsRepositiry();

        }

        List<StateViewModel> ISateService.GetStateDetail()
        {
            var d = _repo.GetStateDetails();
            return d.ToViewModel();

        }


        StateViewModel ISateService.GetStateDetails(int id)
        {
            var d = _repo.GetStateDetail(id);
            return d.ToViewModel();
        }
    }
}
