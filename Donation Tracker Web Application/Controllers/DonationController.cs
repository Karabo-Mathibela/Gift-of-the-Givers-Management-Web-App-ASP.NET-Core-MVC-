using LoginAndRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class DonationController : Controller
    {
        //THE STATIC CLASS THAT CONTAINS THE LIST:
        public static class DataRepository 
        {
            public static List<Donate> donations { get; } = new List<Donate>();
        }


        //THIS FIRST GET ACTION METHOD DISPLAYS THE FORM: 
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //HERE, THE FORM DATA IS PROCESSED:
        [HttpPost]
        public IActionResult Index(Donate donate)
        {
            //HERE, THE LIST IS INJECTED:
            DataRepository.donations.Add(donate);

            //HERE, THE LOGIC IS REDIRECTED TO THE SPECIFIED VIEW, AN OBJECT
            //CONTAINING THE SUBMITTED FORM DATA IS ALSO PROVIDED
            return RedirectToAction("DonationReport", donate);
        }

        //THIS NEXT ACTION METHOD WILL RETURN THE DONATION REPORT VIEW:
        [HttpGet]
        public IActionResult DonationReport(Donate donate) 
        {
            //A VIEW CONTAINING THE DONATE OBJECT DATA IS RETURNED:
            return View(donate);
        }

        //DISPLAYS THE VIEW CONTAINING THE LIST OF ALL THE DONORS:
        [HttpGet]
        public IActionResult List()
        {
            //WITH THIS LAST ACTION METHOD, THE LIST CONTAINING THE DONORS IS PASSED TO THE LIST VIEW:
            return View(DataRepository.donations);
        }
    }
}
