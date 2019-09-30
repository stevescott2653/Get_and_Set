using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_and_Set
{
    public class Employee
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        class TestEmployee
        {
            public static void Main(string[] args)
            {
                Employee e1 = new Employee();
                e1.Name = "John Doe";
                Console.WriteLine("Employee Name: " + e1.Name);
            }
        }
    }
}
