using CourseSystem.Interfaces;
using CourseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem.Implements
{
    public class TeacherAction : IAction<Teacher>
    {
        List<Teacher> _teachers = new List<Teacher>();

        public void Create(Teacher model)
        {
            _teachers.Add(model);
            Console.WriteLine($"Teacher {model.FirstName} {model.LastName} created successfully!");
        }

        public void Delete(int id)
        {
            Teacher teacher = _teachers.FirstOrDefault(t => t.Id == id);
            if (teacher != null)
            {
                Console.WriteLine($"Teacher {teacher.FirstName} {teacher.LastName} deleted successfully!");
                _teachers.Remove(teacher);
            }
            else
            {
                Console.WriteLine($"Teacher with Id {id} not found!");
            }
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public Teacher GetById(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }
    }
}
