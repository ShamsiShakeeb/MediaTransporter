using MediaTrPractises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTrPractises.Service
{
    public class TeacherService : ITeacherService 
    {
        public List<TeacherInformation> GetAllTeacher()
        {
            var teacher1 = new TeacherInformation()
            {
                Id = 1,
                TeacherName = "A"
            };
            var teacher2 = new TeacherInformation()
            {
                Id = 2,
                TeacherName = "B"
            };
            var teacher3 = new TeacherInformation()
            {
                Id = 3,
                TeacherName = "C"
            };
            List<TeacherInformation> teachers = new List<TeacherInformation>();
            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);

            return teachers;
        }
    }
}
