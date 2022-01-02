using MediaTrPractises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTrPractises.Service
{
    public class StudentService : IStudentService 
    {
        public List<StudentInformation> GetAllStudent()
        {
            var student1 = new StudentInformation()
            {
                Id = 1,
                Name = "John Wick",
                cgpa = "4.00",
                TeacherId = 1
            };
            var student2 = new StudentInformation()
            {
                Id = 2,
                Name = "Tony Struck",
                cgpa = "3.98",
                TeacherId = 2
            };
            var student3 = new StudentInformation()
            {
                Id = 2,
                Name = "Bappa Raj",
                cgpa = "2.00",
                TeacherId = 3
            };
            List<StudentInformation> list = new List<StudentInformation>();
            list.Add(student1);
            list.Add(student2);
            list.Add(student3);

            return list;

        }
    }
}
