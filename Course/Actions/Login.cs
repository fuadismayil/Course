using Course.Models;
namespace Course.Actions
{
    public class Login
    {
        public static void LoginStudent(string email, string password)
        {
            foreach (var student in Register.students)
            {
                if (student.Email == email && student.Password == password)
                {
                    Console.WriteLine($"Welcome, {student.FirstName} {student.LastName}!");
                    return;
                }
            }
            Console.WriteLine("\nEmail or password is incorrect.");
        }

        public static void LoginTeacher(string inputEmail, string inputPassword)
        {
            foreach (var teacher in Register.teachers)
            {
                if (teacher.Email == inputEmail && teacher.Password == inputPassword)
                {
                    Console.WriteLine($"\nXos geldiniz {teacher.Email}   {teacher.Password}!");
                    return;
                }
            }
            Console.WriteLine("\nEmail ve ya sifre yanlisdir!");
        }

    }
}