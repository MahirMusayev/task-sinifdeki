using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_SINIF
{
    internal class Group
    {
        public static Group[] Groups;
        public static int GroupCount { get; set; }
        public int GroupId { get; set; }
        static int Count = 0;

        public string GroupName { get; set; }
        public Student[] Students = new Student[0];

        public Group(string groupName)
        {
            GroupId = Count++;
            GroupName = groupName;

        }

        public void GetGroupInfo()
        {
            Console.WriteLine("GRUP ADI " + GroupName);
            Console.WriteLine("ID " + GroupId);
        }
        public string GetStudent(int id)
        {
            if (id == GroupId)
            {

                Console.WriteLine(GroupName);
            }
            return null;
        }
        public void Addstudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
        public void Search(string text)
        {
            if (text == GroupName)
            {
                Console.WriteLine("bu add vardir " + GroupName);
            }
            else
            {
                Console.WriteLine("bele biri yoxdu");
            }
        }
        public void ShowStudents()
        {
            foreach (var student in Students)
            {
                student.GetInfo();
            }
        }
        public override string ToString()
        {
            return $"group id: {GroupId} group adi {GroupName} group count {Students.Length}";
        }
    }
}