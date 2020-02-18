using System.Collections.Generic;
using Employee.Repository;
using Employee.Data;
using System.Web.Mvc;

namespace EmployeeManagements.Controllers
{
    public class IndexController : Controller
    {
        EmployeeRepository employeeRepository;
        public IndexController()
        {
            employeeRepository = new EmployeeRepository();
        }
        // GET: Index
        public ActionResult Index()
        {
            IEnumerable<Employees> employees = employeeRepository.GetAllEmployees();
            return View(employees);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employees employee)
        {
            employeeRepository.AddEmployee(employee);
            TempData["Message"] = "Employee Added Successfully!";
            return RedirectToAction("Index");
        }
       
        public ActionResult Delete(string id)
        {
            employeeRepository.DeleteEmployee(id);
            TempData["Message"] = "Employee Deleted Successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            Employees employees = employeeRepository.GetEmployee(id);
            return View(employees);
        }
        [HttpPost]
        public ActionResult Update(Employees employee)
        {
            employeeRepository.UpdateEmployee(employee);
            TempData["Message"] = "Employee Details Updated Successfully";
            return RedirectToAction("Index");
        }
    }
}