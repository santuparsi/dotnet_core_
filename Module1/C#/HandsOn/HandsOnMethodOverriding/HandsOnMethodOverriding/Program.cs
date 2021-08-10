using System;

namespace HandsOnMethodOverriding
{
    class Employee
    {
        public int eId;
        public string eName;
        public string desingnation;
        public double salary;

        public Employee(int eId, string eName, string desingnation, double salary)
        {
            this.eId = eId;
            this.eName = eName;
            this.desingnation = desingnation;
            this.salary = salary;
        }

        public virtual void Details()
        {
            Console.WriteLine("Eid: " + eId);
            Console.WriteLine("Ename: " + eName);
            Console.WriteLine("Designation:" + desingnation);
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Manager:Employee
    {
        public string level;
        public string[] projects = new string[3];

        public Manager(int eId, string eName, string desingnation, double salary,string level,string[] projects):base(eId,eName,desingnation,salary)
        {
            this.level = level;
            this.projects = projects;
        }

        public override void Details()
        {
            base.Details(); //invokes EMployee Details
            Console.WriteLine("Manager Level Type:" + level);
            Console.WriteLine("Projects: ");
            foreach(var k in projects)
            {
                Console.Write(k + " ");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = null;
            Console.WriteLine("1.Prorammer");
            Console.WriteLine("2.Sr Programmer");
            Console.WriteLine("3.TeamLeader");
            Console.WriteLine("4.Project Manager");
            Console.WriteLine("Select Employee Type");
            int type = int.Parse(Console.ReadLine());
            switch(type)
            {
                case 1:
                case 2:
                case 3:
                    employee = new Employee(1200, "Rohan", "Programmer", 12000);
                    employee.Details(); //invoke details() of EMployee class
                    break;
                case 4:
                    {
                        employee = new Manager(2345, "John", "Project Manager", 34324342, "Level-2",new string[3] { "Project-1","Project-2","Project-3"});
                        employee.Details(); //can access Manger Details()
                    }
                    break;
            }


        }
    }
}
