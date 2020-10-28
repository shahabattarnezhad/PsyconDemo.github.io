using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo.web.Models;
using Microsoft.AspNetCore.Authorization;

namespace Demo.web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UserPage()
        {
            return View();
        }

        public IActionResult InPersonConsultation()
        {
            return View();
        }

        public IActionResult OnlineConsultation()
        {
            return View();
        }

        public IActionResult Treatment()
        {
            return View();
        }

        public IActionResult PsyTest()
        {
            return View();
        }

        public IActionResult StartTest()
        {
            return View();
        }

        public IActionResult StartTest1()
        {
            return View();
        }

        public IActionResult StartTest2()
        {
            return View();
        }

        public IActionResult StartTest3()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }

        public IActionResult AppointmentDetails()
        {
            return View();
        }

        public IActionResult Treatments()
        {
            return View();
        }

        public IActionResult TreatmentDetails()
        {
            return View();
        }

        public IActionResult TestResults()
        {
            return View();
        }

        public IActionResult TestResultDetails()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult ReportDetails()
        {
            return View();
        }

        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult NotificationDetails()
        {
            return View();
        }

        public IActionResult Followups()
        {
            return View();
        }

        public IActionResult FollowUpDetails()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
