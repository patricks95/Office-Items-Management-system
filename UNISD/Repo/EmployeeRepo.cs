using UNISD.DbCont;
using UNISD.Entities;
using UNISD.IRepo;

namespace UNISD.Repo
{

    public class EmployeeRepo:IEmployeeRepo
    {
        private readonly EmployeeContext _uContext;

        public EmployeeRepo(EmployeeContext uContext)
        {
            _uContext = uContext;
        }


        public async Task<object> GetAllEmp()
            {
            var result = _uContext.Employees.ToList();
            return result;
        }

       public async Task<object>GetempById(Guid id)
        {
            var res= _uContext.Employees.FirstOrDefault(x => x.Id == id);
            return res;
        }

        public async Task<object>NewEmp(Employee employee)
        {
            employee.Id=Guid.NewGuid();
            await _uContext.Employees.AddAsync(employee);
            await _uContext.SaveChangesAsync();
            return employee;
        }

        public async Task<object>UpdateEmp(Guid id ,Employee updated)
        {
            var olddetails= _uContext.Employees.FirstOrDefault(x=>x.Id==id);
                           
                olddetails.Name=updated.Name;
                olddetails.Mobile=updated.Mobile;
                olddetails.Nic=updated.Nic;
                olddetails.TeamName=updated.TeamName;
                await _uContext.SaveChangesAsync();
                return updated;
                        
        }


        public async Task<object>DeleteEmp(Guid id)
        {
            var getdetails= _uContext.Employees.FirstOrDefault(x=>x.Id==id);
            _uContext.Employees.Remove(getdetails);
            await _uContext.SaveChangesAsync();
            return getdetails;
        }
    }
}
