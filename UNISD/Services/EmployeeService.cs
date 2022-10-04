using UNISD.Entities;
using UNISD.IRepo;
using UNISD.IServices;

namespace UNISD.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<object> GetAllEmployee()
        {
            var res =await _employeeRepo.GetAllEmp().ConfigureAwait(true);
            return res;
        }


        public async Task<object> GetEmpById(Guid id)
        {
            var emp = await _employeeRepo.GetempById(id).ConfigureAwait(true);
            return emp;
        }


        public async Task<object> NewEmp(Employee employee)
        {
            return await _employeeRepo.NewEmp(employee).ConfigureAwait(true);

        }

        public async Task<object> UpdateEmp(Guid id, Employee updated)
        {
           return await _employeeRepo.UpdateEmp(id, updated).ConfigureAwait(true);
           
        }
        public async Task<object> DeleteEmp(Guid id)
        {
            return await _employeeRepo.DeleteEmp(id).ConfigureAwait(true);
        }
    }
}
