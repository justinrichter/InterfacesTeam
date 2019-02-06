using InterfacesTeam.Models;
using InterfacesTeam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterfacesTeam.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeRepository _employeeRepository = null;

        public EmployeesController()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public ActionResult Index()
        {
            var Employees = _employeeRepository.GetEmployees();

            return View(Employees);
        }

        public ActionResult Detail(int? id)  //Base class is shared Result Type for ContentResult and RedirectResult
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var Employee = _employeeRepository.GetEmployee((int)id);

            return View(Employee);
        }

        public ActionResult EmployeeConsole()  //Base class is shared Result Type for ContentResult and RedirectResult
        {
            return View();
        }
    }
}