using Course.Actions;
using Course.Models;
using Microsoft.Win32;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //================================================================================================================================================
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$--Student--$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            //================================================================================================================================================

            Student student1 = new()
            {
                FirstName = "Murad",
                LastName = "Mammadov",
                GroupNumber = "APA000",
                BirthDate = new DateOnly(2004, 5, 14),
                PhoneNumber = "0501234567",
                Score = 87,
                Address = "Bakı şəhəri, Nərimanov rayonu",
                Email = "murad.mammadov@gmail.com",
                Password = "Murad123!!",
                UserName = "muradmm-dev"
            };
            Student student2 = new()
            {
                FirstName = "Tural",
                LastName = "Muradov",
                GroupNumber = "APA001",
                BirthDate = new DateOnly(2006, 5, 14),
                PhoneNumber = "0501264567",
                Score = 87,
                Address = "Bakı şəhəri, Nərimanov rayonu",
                Email = "tural.muradov@gmail.com",
                Password = "Tural123!!",
                UserName = "Turalmr-dev"
            };
            Register.RegisterStudent(student1);
            Register.RegisterStudent(student2);
            Login.LoginStudent("murad.mammadov@gmail.com", "Murad123!!");
            Console.WriteLine();
            Login.LoginStudent("murad.mammadov@gmail.com", "Murad124!!");

            Teacher teacher = new Teacher()
            {
                FirstName = "Ali",
                LastName = "Memmedov",
                UserName = "ali_mammadov",
                DepartmentName = "Komputer Elmləri",
                Subject = "Proqramlasdırma",
                BirthDate = new DateOnly(2000, 5, 14),
                Address = "Baki səhəri, Azerbaycan",
                Email = "ali.mammadov@example.com",
                Phone = "+994501234567",
                Password = "12345"
            };

            Register.RegisterTeacher(teacher);
            Login.LoginTeacher("ali.mammadov@example.com", "123456");





            //Student student1 = new Student("Murad", "Mammadov", "murad.mammadov@gmail.com", "Murad123!!", "muradmm-dev", 0501234567, new DateOnly(2004, 5, 14), "APA101", 87, "Bakı şəhəri, Nərimanov rayonu");
            //Console.WriteLine(student1.GetName());
            //Console.WriteLine(student1.GetGroup());
            //Console.WriteLine(student1.GetStudent());
            //Console.WriteLine(student1.GetEmail());
            //Console.WriteLine(student1.GetBirthDate());
            //Console.WriteLine(student1.GetContact());

            //Student student2 = new Student("Tural", "Qasımov", "tural.qasimov@gmail.com", "Tural456!!", "turalq-dev", 701112233);
            //Console.WriteLine(student2.GetName());
            //Console.WriteLine(student2.GetGroup());
            //Console.WriteLine(student2.GetStudent());
            //Console.WriteLine(student2.GetEmail());
            //Console.WriteLine(student2.GetBirthDate());
            //Console.WriteLine(student2.GetContact());

            //Student student3 = new Student("Elvin", "Rzayev", "elvin.rzayev@gmail.com", "Elvin2024!!", "elvinr-dev", new DateOnly(2001, 12, 1), "APA103");
            //Console.WriteLine(student3.GetName());
            //Console.WriteLine(student3.GetGroup());
            //Console.WriteLine(student3.GetStudent());
            //Console.WriteLine(student3.GetEmail());
            //Console.WriteLine(student3.GetBirthDate());
            //Console.WriteLine(student3.GetContact());


            //================================================================================================================================================
            //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$--Teacher--$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
            //================================================================================================================================================


            //Teacher teacher1 = new Teacher("Aysel","Hüseynova","ayselh-dev","Computer Science","Programming",new DateOnly(1987, 3, 12),"Bakı şəhəri, Yasamal rayonu","aysel.huseynova@gmail.com","0501234567",12345);
            //Console.WriteLine(teacher1.GetName());
            //Console.WriteLine(teacher1.GetSubject());
            //Console.WriteLine(teacher1.GetTeacher());
            //Console.WriteLine(teacher1.GetEmail());
            //Console.WriteLine(teacher1.GetBirthDate());
            //Console.WriteLine(teacher1.GetContact());

            //Teacher teacher2 = new Teacher("Reşad","Memmedov","rashadm-dev","rashad.mammadov@gmail.com", "0709876543", 54321);
            //Console.WriteLine(teacher2.GetName());
            //Console.WriteLine(teacher2.GetSubject());
            //Console.WriteLine(teacher2.GetTeacher());
            //Console.WriteLine(teacher2.GetEmail());
            //Console.WriteLine(teacher2.GetBirthDate());
            //Console.WriteLine(teacher2.GetContact());

            //Teacher teacher3 = new Teacher("Leyla","Quliyeva","leylaq-dev","leyla.quliyeva@gmail.com","Mathematics",new DateOnly(1990, 11, 25)  );
            //Console.WriteLine(teacher3.GetName());
            //Console.WriteLine(teacher3.GetSubject());
            //Console.WriteLine(teacher3.GetTeacher());
            //Console.WriteLine(teacher3.GetEmail());
            //Console.WriteLine(teacher3.GetBirthDate());
            //Console.WriteLine(teacher3.GetContact());
        }
    }
}