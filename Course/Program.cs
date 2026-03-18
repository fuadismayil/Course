using Course.Actions;
using Course.Models;
using Microsoft.Win32;
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                PhoneNumber = "+994501234567",
                Password = "12345"
            };

            Register.RegisterTeacher(teacher);
            Login.LoginTeacher("ali.mammadov@example.com", "123456");


        }
    }
}