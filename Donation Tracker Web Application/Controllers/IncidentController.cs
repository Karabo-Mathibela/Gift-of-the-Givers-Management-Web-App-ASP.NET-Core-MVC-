using LoginAndRegistration.Models;
using LoginAndRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class IncidentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IncidentR incidentR)
        {
            TempData["Incident"] = incidentR.incident;
            TempData["Location"] = incidentR.location;
            TempData["ItemsRequired"] = incidentR.itemsRequired;

            return RedirectToAction("Details", incidentR);
        }

        [HttpGet]
        public IActionResult Details(IncidentR incidentR) 
        {
            var IncidentReport = new IncidentR
            {
                incident = incidentR.incident,
                location = incidentR.location,
                itemsRequired = incidentR.itemsRequired
            };

            return View(IncidentReport);
        }
    }
}
