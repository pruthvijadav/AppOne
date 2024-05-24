using Employee.DataEntity;
using AppOne.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    static public class Helper
    {
        public static StateViewModel ToViewModel(this StateDetail state)
        {
            return new StateViewModel
            {
                StateId = state.StateId,
                StateName = state.StateName
            };
        }

        public static List<StateViewModel> ToViewModel(this List<StateDetail> states)
        {
          
          return states.Select(x => ToViewModel(x)).ToList();
        }

    }
}
