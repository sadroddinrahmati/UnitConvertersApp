using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using UnitConverters.Models.Base;
using UnitConvertersApp.Web.Models;
using UnitConvertersApp.Web.Service;

namespace UnitConvertersApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ConverterService _converterService;

        public HomeController(ILogger<HomeController> logger, ConverterService converterService)
        {
            _logger = logger;
            this._converterService = converterService;
        }

        public IActionResult Index([FromQuery]UnitOfMeasurement unit = UnitOfMeasurement.Length)
        {
            var unitsList = _converterService.PopulateUnitsLists(unit);

            ViewData["unitsList"] = unitsList
                .Select(x => new SelectListItem { Text = x, Value = x })
                .ToList();

            ViewData["Title"] = $"Convert {unit}";
            return View();
        }

        [HttpPost]
        public IActionResult Convert(ConvertModel model)
        {
            var result = _converterService.ConvertUnits(model);
            return View("Convert",result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
