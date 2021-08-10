using System;

namespace HandsOnProperties
{
    class Employee
    {
        private int eId;
        private string eName;
        public int EID
        {
            get { return eId; } //getter
            set { eId = value; } //setter
        }
        public string ENAME
        {
            get { return eName; }
            set { eName = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.EID = 1345; //setter is invoke
            e1.ENAME = "Roahn";
            Console.WriteLine("Eid:{0} Ename:{1}", e1.EID, e1.ENAME);//getter invokes
        }
    }
}
