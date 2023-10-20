using MediaTrPractises.Media;
using MediaTrPractises.Models;
using MediaTrPractises.Service;
using System.Collections.Generic;

namespace MediaTrPractises.CommandQuery
{
    public class CreateStudentCommand  : IEventHandler
    {
        private readonly IStudentService _studentService;

        public CreateStudentCommand(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public List<StudentInformation> Handler(StudentInformation studentInformation)
        {
            List<StudentInformation> students = _studentService.GetAllStudent();
            students.Add(studentInformation);
            return students;
        }

    }
}
