using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class EmployeeService
    {
        private readonly Repository<EmpProfile> _empRepository;

        public EmployeeService()
        {
            // Initialize the repository with the DAL context
            var context = new ContextClass();
            _empRepository = new Repository<EmpProfile>(context);
        }

        public void AddEmployee(EmpProfile employee)
        {
            _empRepository.Add(employee);
        }

        public EmpProfile GetEmployeeById(int empCode)
        {
            return _empRepository.GetById(empCode);
        }

        public void UpdateEmployee(EmpProfile employee)
        {
            _empRepository.Update(employee);
        }

        public void DeleteEmployee(EmpProfile employee)
        {
            _empRepository.Delete(employee);
        }

        public List<EmpProfile> GetAllEmployees()
        {
            // Implement logic to get all employees from the repository
            return _empRepository.GetAll().ToList();
        }
    }
}
