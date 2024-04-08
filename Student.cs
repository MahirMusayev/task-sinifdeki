using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_SINIF
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        static int Count = 0;
        public Student(string name, string surname)
        {
            Name = Captilaze(name);
            Surname = Captilaze(surname);
            ID = Count++;
        }
        string Captilaze(string txt)
        {
            return txt.Substring(0, 1).ToUpper() + txt.Substring(1).ToLower();
        }
        public void GetInfo()
        {
            Console.WriteLine($"name :{Name}");
            Console.WriteLine($"surname :{Surname}");
            Console.WriteLine($"id :{ID}");
        }

    }
}
