using CourseSystem.Implements;
using CourseSystem.Models;
using System;

namespace CourseSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeacherAction teacherAction = new TeacherAction();
            StudentAction studentAction = new StudentAction();
            GroupAction groupAction = new GroupAction();

            teacherAction.Create(new Teacher { Id = 1, FirstName = "Tofiq", LastName = "Rustemov", DepartmentName = "Komputer Muhendisliyi", Subject = "Alqoritmler" });
            teacherAction.Create(new Teacher { Id = 2, FirstName = "Leyla", LastName = "Memmedova", DepartmentName = "Fizika", Subject = "Kvant Mexanikasi" });
            Console.WriteLine();
            Console.WriteLine($"Umumi muellim sayi: {teacherAction.GetAll().Count}");
            Console.WriteLine($"Muellim tapildi: {teacherAction.GetById(1).FirstName} {teacherAction.GetById(1).LastName}");
            Console.WriteLine($"Muellim tapildi: {teacherAction.GetById(2).FirstName} {teacherAction.GetById(2).LastName}");
            Console.WriteLine();

            teacherAction.Delete(1);
            teacherAction.Delete(2);
            Console.WriteLine();

            Console.WriteLine($"Silinmeden sonra umumi muellim sayi: {teacherAction.GetAll().Count}");
            Console.WriteLine();


            studentAction.Create(new Student { Id = 1, FirstName = "Ali", LastName = "Hesenov", GroupNumber = "CS-101", Score = 95 });
            studentAction.Create(new Student { Id = 2, FirstName = "Aygun", LastName = "Quliyeva", GroupNumber = "CS-102", Score = 88 });
            Console.WriteLine();

            Console.WriteLine($"Umumi telebe sayi: {studentAction.GetAll().Count}");
            Console.WriteLine($"Telebe tapildi: {studentAction.GetById(1).FirstName} {studentAction.GetById(1).LastName}");
            Console.WriteLine($"Telebe tapildi: {studentAction.GetById(2).FirstName} {studentAction.GetById(2).LastName}");
            Console.WriteLine();

            studentAction.Delete(1);
            studentAction.Delete(2);
            Console.WriteLine();

            Console.WriteLine($"Silinmeden sonra umumi telebe sayi: {studentAction.GetAll().Count}");
            Console.WriteLine();


            groupAction.Create(new Group { Id = 1, Name = "Backend Proqramcilar", Speciality = "Proqram Muhendisliyi" });
            groupAction.Create(new Group { Id = 2, Name = "Data Analitikler", Speciality = "Melumat Elmi" });
            Console.WriteLine();

            Console.WriteLine($"Umumi qrup sayi: {groupAction.GetAll().Count}");
            Console.WriteLine($"Qrup tapildi: {groupAction.GetById(1).Name}");
            Console.WriteLine($"Qrup tapildi: {groupAction.GetById(2).Name}");
            Console.WriteLine();

            groupAction.Delete(1);
            groupAction.Delete(2);
            Console.WriteLine();

            Console.WriteLine($"Silinmeden sonra umumi qrup sayi: {groupAction.GetAll().Count}");
        }
    }
}