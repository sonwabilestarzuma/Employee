using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentBrandStudio.Data;
using AssessmentBrandStudio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AssessmentBrandStudio.Controllers
{
    public class AppController : Controller
    {
        private IEmployeeRepository _repository;
        private ILogger<EmployeeRepository> _logger;

        public AppController(IEmployeeRepository repository, ILogger<EmployeeRepository> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employees()
        {
            try
            {
                var employees = _repository.GetAllEmployees();
                return View(employees);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get employees in database:{ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEmployee(EmployeeViewModel model)
        {
            try
            {
                if (model.Employee != null)
                {
                    await _repository.Add(model.Employee);
                }
                else
                {
                    await _repository.Update(model.Employee);
                }
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                return View("Error");
            }

            return View("AddEmployee");
        }
    }
}


