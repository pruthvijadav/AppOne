using AppOne.BusinessService.Interface;
using AppOne.BusinessService.Concret;
using EmployeeRepositery.Concreate;
using EmployeeRepositery.Repositiry;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class StateController : Controller
    {


        private readonly ISateService sateService;

        public StateController()
        {
            sateService = new StateSevice();
        }

        public IActionResult StateDetails()
        {
            return View(sateService.GetStateDetail());
        }

       

        public IActionResult Index()
        {
            return View(sateService.GetStateDetail());
        }
    }
}
