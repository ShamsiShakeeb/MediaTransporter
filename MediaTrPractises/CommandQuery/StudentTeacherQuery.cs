using MediaTrPractises.Media;
using MediaTrPractises.Service;
using System.Linq;

namespace MediaTrPractises.CommandQuery
{
    public class StudentTeacherQuery :  IEventHandler
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public StudentTeacherQuery(IStudentService studentService , ITeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
        
        public Data Handler()
        {
            var data = from a in _studentService.GetAllStudent()
                       join b in _teacherService.GetAllTeacher()
                       on a.Id equals b.Id
                       select new
                       {
                           a.Name,
                           a.cgpa,
                           b.TeacherName
                       };
            Data ds = new Data();
            ds.Object = data;
            return ds;
        }
    }
}
public class Data
{
    public object Object { set; get; }
}
