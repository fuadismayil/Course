using CourseSystem.Interfaces;
using CourseSystem.Models;

namespace CourseSystem.Implements
{
    public class StudentAction : IAction<Student>
    {
        List<Student> _students = new List<Student>();
        public void Create(Student model)
        {
            _students.Add(model);
            Console.WriteLine($"Student {model.FirstName} {model.LastName} created successfully!");
        }

        public void Delete(int id)
        {
            Student student = _students.FirstOrDefault(student => student.Id == id);
            Console.WriteLine($"Student with {student.FirstName} {student.LastName} deleted successfully!");
            _students.Remove(student);
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }
}