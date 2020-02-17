using System.Collections.Generic;
using Employee.Data;
namespace Employee.Repository
{
    public class EmployeeRepository
    {
        public static List<Employees> employees = new List<Employees>();
        static EmployeeRepository()
        {
            employees.Add(new Employees("Rohini", "fulltime", "E001", 2,12000));
            employees.Add(new Employees("Megala", "fulltime", "E002", 3,20000));
            employees.Add(new Employees("Adhav", "parttime", "E003", 1,8000));
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return employees;
        }
        public void AddEmployee(Employees employee)
        {
            employees.Add(employee);
        }
        public Employees GetEmployee(string employeeId)
        {
            return employees.Find(id => id.EmployeeId == employeeId);
        }
        public void DeleteEmployee(string employeeId)
        {
            Employees employee = GetEmployee(employeeId);
            if (employee != null)
                employees.Remove(employee);
        }
    }
}
