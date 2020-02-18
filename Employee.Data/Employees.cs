namespace Employee.Data
{
    public class Employees
    {
        public string EmployeeName { get; set; }
        public float Salary { get; set; }
        public string WorkType { get; set; }
        public string EmployeeId { get; set; }
        public byte Experience { get; set; }
        public Employees(string name, string workType, string id, byte experience,float salary)
        {
            this.EmployeeName = name;
            this.WorkType = workType;
            this.EmployeeId = id;
            this.Experience = experience;
            this.Salary = salary;
        }
        public Employees()
        {

        }
    }
}
