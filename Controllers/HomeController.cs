using FilegaJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilegaJobs.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobsRepository _JobsRepository;
        private readonly IUsersRepository _UsersRepository;
        private readonly IApplicantsRepository _ApplicantsRepository;
        public HomeController(IJobsRepository jobsRepository, 
                              IApplicantsRepository applicantsRepository,
                              IUsersRepository usersRepository
                              )
        {
            _JobsRepository = jobsRepository;
            _UsersRepository = usersRepository;
            _ApplicantsRepository = applicantsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Listing()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Listing(Jobs job)
        {
            _JobsRepository.Add(job);
            return RedirectToAction("ActiveJobs");
        }
        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Profile(UserProfiles user)
        {
            _UsersRepository.Add(user);
            return RedirectToAction("ActiveUsers");
        }
        public IActionResult ActiveJobs()
        {
            var model = _JobsRepository.GetAllJobs();
            return View(model);
        }
        public IActionResult ActiveUsers()
        {
            var model = _UsersRepository.GetAllUsers();
            return View(model);
        }
        public IActionResult Search()
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
