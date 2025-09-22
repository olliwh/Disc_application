using Disc_API.Models;

namespace Disc_API.Repos
{
    public class DepartmentsRepository
    {
        private List<Department> _departments;
        private int _nextId;
        public DepartmentsRepository()
        {
            _nextId = 1;
            _departments = new List<Department>()
            {
                new Department(_nextId++, "HR"),
                new Department(_nextId++, "IT"),
                new Department(_nextId++, "Customer Service"),
                new Department(_nextId++, "Support"),
            };
        }
        public Department? GetById(int id)
        {
            Department? department = _departments.Find(x => x.Id == id);
            return department;
        }
    }
}
