namespace TASK_SINIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("mahir", "musayev");
            student.GetInfo();

            Console.WriteLine(" ");
            Group group = new Group( "sdsfdf");
            group.GetGroupInfo();

            group.GetStudent(0);
            group.Search("Musayev Mahir");
            group.Addstudent(student);
            Console.WriteLine("grupdaki adlar");
            group.ShowStudents();
            group.ToString();
        } 
    }
}