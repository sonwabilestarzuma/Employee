using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentBrandStudio.Data;
using AssessmentBrandStudio.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AssessmentBrandStudio.Controllers.Api
{
    [Route("api/employees")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _repository;
        private ILogger<EmployeeRepository> _logger;

        public EmployeeController(IEmployeeRepository repository, ILogger<EmployeeRepository> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var results = _repository.GetAllEmployees();
                return Ok(Mapper.Map<IEnumerable<EmployeeViewModel>>(results));
            }
            catch (Exception ex)
            {
                //TODO logging
                _logger.LogError($"Failed to get all Employees:{ex}");

                return BadRequest("Error Occured");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]EmployeeViewModel theEmployee)
        {
            if (ModelState.IsValid)
            {
                // save to the database automap
                var newEmployee= Mapper.Map<Employee>(theEmployee);
                _repository.AddEmployee(newEmployee);
                if (await _repository.SaveChangesAsync())
                {
                    return Created($"api/employees/{theEmployee.EmployeeStatuses}", Mapper.Map<EmployeeViewModel>(newEmployee));
                }

            }
            return BadRequest("Failed to save the Employee");
        }
    }
}