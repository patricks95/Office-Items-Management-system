using UNISD.DbCont;
using UNISD.Entities;
using UNISD.IRepo;

namespace UNISD.Repo
{
    public class EmployeeRepo:IEmployeeRepo
    {
        private readonly UContext _employeeContext;

        public EmployeeRepo(UContext employeeContext)
        {
            _employeeContext = employeeContext;
        }


        public async Task<object> GetAllEmp()
        {
            var result = _employeeContext.Employees.ToList();
            return result;
        }

       public async Task<object>GetempById(Guid id)
        {
            var res=_employeeContext.Employees.FirstOrDefault(x => x.Id == id);
            return res;
        }

        public async Task<object>NewEmp(Employee employee)
        {
            employee.Id=Guid.NewGuid();
            await _employeeContext.Employees.AddAsync(employee);
            await _employeeContext.SaveChangesAsync();
            return employee;
        }

        public async Task<object>UpdateEmp(Guid id ,Employee updated)
        {
            var olddetails= _employeeContext.Employees.FirstOrDefault(x=>x.Id==id);
                           
                olddetails.Name=updated.Name;
                olddetails.Mobile=updated.Mobile;
                olddetails.Nic=updated.Nic;
                olddetails.TeamName=updated.TeamName;
                await _employeeContext.SaveChangesAsync();
                return updated;
                        
        }

        public async Task<object>DeleteEmp(Guid id)
        {
            var getdetails= _employeeContext.Employees.FirstOrDefault(x=>x.Id==id);
            _employeeContext.Employees.Remove(getdetails);
            await _employeeContext.SaveChangesAsync();
            return getdetails;
        }
    }
}
