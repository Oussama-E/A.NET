using ExerciceRecap.Entities;
using ExerciceRecap.ModelDTO;
using ExerciceRecap.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceRecap.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly NorthwindContext _dbcontext;
        private readonly IUnitOfWorkNorthwind _unitOfWorkNorthwind;

        public EmployeeController()
        {
            _dbcontext = new NorthwindContext();
            _unitOfWorkNorthwind = new UnitOfWorkNorthwindSQL(_dbcontext);
        }

        [HttpGet]
        public async Task<IList<EmployeeDTO>> GetEmployeeAsync()
        {
           IList<Employee> list = await _unitOfWorkNorthwind.EmployeeRepository.GetAllAsync();
            return list.Select(e=>EmployeeToDTO(e)).ToList();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Employee? e = await _unitOfWorkNorthwind.EmployeeRepository.GetByIdAsync(id);
            if(e== null)
            {
                return NotFound();
            }
            return Ok(EmployeeToDTO(e));
        }

        [HttpPost]
        public async Task Post(EmployeeDTO employeeDTO)
        {
            employeeDTO.EmployeeId = 0;
            Employee e = DTOToEmployee(employeeDTO);
            await _unitOfWorkNorthwind.EmployeeRepository.InsertAsync(e);
           
        }

        [HttpPut]
        public async Task Put(EmployeeDTO employeeDTO)
        {
            Employee e = DTOToEmployee(employeeDTO);
            await _unitOfWorkNorthwind.EmployeeRepository.SaveAsync(e);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Employee? e = await _unitOfWorkNorthwind.EmployeeRepository.GetByIdAsync(id);
            if (e == null)
                return NotFound();
            else
            {
                await _unitOfWorkNorthwind.EmployeeRepository.DeleteAsync(e);
                return Ok();
            }
        }

        private static EmployeeDTO EmployeeToDTO(Employee emp) =>
            new EmployeeDTO
            {
                EmployeeId = emp.EmployeeId,
                LastName = emp.LastName,
                FirstName = emp.FirstName,
                BirthDate = emp.BirthDate,
                HireDate = emp.HireDate,
                Title = emp.Title,
                TitleOfCourtesy = emp.TitleOfCourtesy

            };

        private static Employee DTOToEmployee(EmployeeDTO emp) =>
            new Employee
            {
                EmployeeId = emp.EmployeeId,
                LastName = emp.LastName,
                FirstName = emp.FirstName,
                BirthDate = emp.BirthDate,
                HireDate = emp.HireDate,
                Title = emp.Title,
                TitleOfCourtesy = emp.TitleOfCourtesy
            };

    }
}
