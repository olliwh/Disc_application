using Disc_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Disc_API.Repos
{
    public class EmployeesRepository
    {
        private List<Employee> _employees;
        private int _nextId;
        private readonly DiscTypesRepository _discTypesRepository;
        private readonly DepartmentsRepository _departmentsRepository;
        private string _baseImgUrl = "Disc_API/Images";

        public EmployeesRepository(DiscTypesRepository discTypesRepository, DepartmentsRepository departmentsRepository)
        {
            _nextId = 1;
            _discTypesRepository = discTypesRepository;
            _departmentsRepository = departmentsRepository;

            _employees = new List<Employee>()
            {
                new Employee(_nextId++, "Morten Olsen", "m@m.dk", _departmentsRepository.GetById(1), _discTypesRepository.GetById(1),  _baseImgUrl + "Morten_Olsen.jpg"),
                new Employee(_nextId++, "Kanye West", "K@m.dk", _departmentsRepository.GetById(1), _discTypesRepository.GetById(1),  _baseImgUrl + "Kanye_West.jpg"),
                new Employee(_nextId++, "Jay Z", "J@m.dk", _departmentsRepository.GetById(1), _discTypesRepository.GetById(4),  _baseImgUrl + "Jay_Z.jpg"),
                new Employee(_nextId++, "Venus Williams", "J@m.dk", _departmentsRepository.GetById(2), _discTypesRepository.GetById(4),  _baseImgUrl + "Venus_williams.jpg"),
                new Employee(_nextId++, "Tom Hansen", "T@m.dk", _departmentsRepository.GetById(2), _discTypesRepository.GetById(3),  _baseImgUrl + "Tom_hansen.jpg"),
                new Employee(_nextId++, "Nadia Nadim", "N@m.dk", _departmentsRepository.GetById(3), _discTypesRepository.GetById(3),  _baseImgUrl + "Nadia_Nadim.jpg"),
                new Employee(_nextId++, "Bob Dylan", "B@m.dk", _departmentsRepository.GetById(3), _discTypesRepository.GetById(2),  _baseImgUrl + "Bob_Dylan.jpg"),
                new Employee(_nextId++, "Lional Messi", "L@m.dk", _departmentsRepository.GetById(3), _discTypesRepository.GetById(2),  _baseImgUrl + "Lionel_Messi.jpg")
            };
        }
        public Employee? GetById(int id)
        {
            Employee? poke = _employees.Find(x => x.Id == id);
            return poke;
        }
        public Employee Add(Employee employee)
        {
            employee.Id = _nextId++;

            _employees.Add(employee);
            return employee;
        }
        public Employee? Delete(int id)
        {
            Employee? pokeToDelete = GetById(id);
            if (pokeToDelete == null) return null;
            _employees.Remove(pokeToDelete);
            return pokeToDelete;
        }
        public Employee? Update(int id, Employee employee)
        {
            Employee? employeeToUpdate = GetById(id);

            if (employeeToUpdate == null) return null;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.DiscType = employee.DiscType;
            employeeToUpdate.Department = employee.Department;
            employeeToUpdate.ImgUrl = employee.ImgUrl;
            return employeeToUpdate;
        }
        public List<Employee> GetAll(int? amount = null, string? namefilter = null, int? minLevel = null)
        {
            List<Employee> result = new List<Employee>(_employees);

            return result;
        }

    }
}
