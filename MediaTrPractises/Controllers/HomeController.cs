using MediaTrPractises.CommandQuery;
using MediaTrPractises.Media;
using MediaTrPractises.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace MediaTrPractises.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediaTransporter<StudentTeacherQuery, Data> _mediaGetStudentTeacherList;
        private readonly IMediaTransporter<CreateStudentCommand, List<StudentInformation>> _mediaCreateStudent;

        public HomeController(ILogger<HomeController> logger, 
            IMediaTransporter<StudentTeacherQuery, Data> mediaGetStudentTeacherList,
            IMediaTransporter<CreateStudentCommand, List<StudentInformation>> mediaCreateStudent)
        {
            _logger = logger;
            _mediaGetStudentTeacherList = mediaGetStudentTeacherList;
            _mediaCreateStudent = mediaCreateStudent;
        }

        public IActionResult Index()
        {
           
            var result = _mediaGetStudentTeacherList.Send();
            var student = new StudentInformation()
            {
                Id = 4,
                Name = "John Cena",
                cgpa = "2.76",
                TeacherId = 4
            };
           
            var createCommand = _mediaCreateStudent.Send(student);

            return View();
        }

        public IActionResult Privacy()
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
