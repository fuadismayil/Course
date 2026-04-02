using CourseSystem.Interfaces;
using CourseSystem.Models;

namespace CourseSystem.Implements
{
    public class GroupAction : IAction<Group>
    {
        List<Group> _groups = new List<Group>();
        public void Create(Group model)
        {
            _groups.Add(model);
            Console.WriteLine($"Group {model.Name} created succesfully.");
        }

        public void Delete(int id)
        {
            Group group = _groups.FirstOrDefault(group => group.Id == id);
            Console.WriteLine($"Group {group.Name} deleted successfully!");
            _groups.Remove(group);
        }

        public List<Group> GetAll()
        {
            return _groups;
        }

        public Group GetById(int id)
        {
            return _groups.FirstOrDefault(g => g.Id == id);
        }
    }
}