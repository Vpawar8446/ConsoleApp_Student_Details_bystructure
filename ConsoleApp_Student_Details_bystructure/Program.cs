using System;

namespace ConsoleApp_Student_Details_bystructure
{
    public struct Student
    {
        public String Stud_Name,Course_Name;
        public int StudentId;
        public int RegistrationId;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Student s1;
            Console.Write("Enter the student name : ");
            s1.Stud_Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the course name : ");
            s1.Course_Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the StudentID : ");
            s1.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the RegistrationID : ");
            s1.RegistrationId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Student details :");
            Console.WriteLine("\n Stud_Name : {0}  \n Cource_Name :  {1}  \n StudentId : {2}  \n RegistrationId : {3} ", s1.Stud_Name, s1.Course_Name, s1.StudentId, s1.RegistrationId);
       }
    }
}
