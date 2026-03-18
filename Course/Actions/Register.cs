using Course.Models;
namespace Course.Actions
{
    public class Register
    {
        public static List<Student> students = new List<Student>();
        public static void RegisterStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"\nEmail: {student.Email} \nPassword: {student.Password}\n");
        }

        public static List<Teacher> teachers = new List<Teacher>();

        public static void RegisterTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
            Console.WriteLine($"\nEmail: {teacher.Email} \nPassword: {teacher.Password} \nUgurla qeydiyyatdan keçdi!\n");
        }

    }
}
