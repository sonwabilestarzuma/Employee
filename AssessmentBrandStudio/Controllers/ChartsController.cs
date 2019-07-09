using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentBrandStudio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AssessmentBrandStudio.Controllers
{
    public class ChartsController : Controller
    {
        private IEmployeeRepository _repository;
        private ILogger<EmployeeRepository> _logger;

        public ChartsController(IEmployeeRepository repository, ILogger<EmployeeRepository> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult GetData()
        //{
        //    int firstname = _repository.HighCharts.Count();
        //}
    }
}

