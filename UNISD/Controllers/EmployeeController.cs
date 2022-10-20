using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UNISD.Entities;
using UNISD.IServices;

namespace UNISD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #region EMPLOYEE

        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await _employeeService.GetAllEmployee().ConfigureAwait(true);
            return Ok(result);
        }

        [HttpGet("Get-By-Id")]
        public async Task<IActionResult> GetEmp(Guid id)
        {


            var result = await _employeeService.GetEmpById(id).ConfigureAwait(true);
            //if (result == null)
            //{
            //    return NotFound();
            //}
            return Ok(result);
        }

        [HttpPut("New-emp")]
        public async Task<IActionResult> NewEmp(Employee employee)
        {
            var result = await _employeeService.NewEmp(employee);
            return Ok(result);
        }

        [HttpPost("update-emp")]
        public async Task<IActionResult> UpdateEmp(Guid id, Employee updated)
        {
            var result = await _employeeService.UpdateEmp(id, updated);
            return Ok(result);
        }

        [HttpDelete("emp-delete")]
        public async Task<IActionResult> DeleteEmp(Guid id)
        {
            var result = await _employeeService.DeleteEmp(id);
            return Ok(result);
        }

        #endregion




    }
}
