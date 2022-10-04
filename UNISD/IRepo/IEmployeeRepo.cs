using UNISD.Entities;

namespace UNISD.IRepo
{
    public interface IEmployeeRepo
    {
        Task<object> GetAllEmp();
        Task<object> GetempById(Guid id);
        Task<object> NewEmp(Employee employee);
        Task<object> UpdateEmp(Guid id, Employee updated);
        Task<object> DeleteEmp(Guid id);
    }
}
