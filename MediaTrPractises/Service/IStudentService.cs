using MediaTrPractises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTrPractises.Service
{
    public interface IStudentService
    {
        public List<StudentInformation> GetAllStudent();
    }
}
