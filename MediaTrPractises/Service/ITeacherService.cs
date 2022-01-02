using MediaTrPractises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTrPractises.Service
{
    public interface ITeacherService 
    {
        public List<TeacherInformation> GetAllTeacher();
    }
}
