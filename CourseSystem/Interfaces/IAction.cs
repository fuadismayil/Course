namespace CourseSystem.Interfaces
{
    public interface IAction<T> where T : class
    {
        void Create(T model);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}