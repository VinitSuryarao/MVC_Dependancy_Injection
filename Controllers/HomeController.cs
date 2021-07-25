using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace Dependancy_Injection.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _emp = null;

        public HomeController(IEmployee employee)
        {
            _emp = employee;
        }
        public string Index()
        {
            int Count = _emp.GetTotalEmployee();
            return Count.ToString();
        }

    }
}