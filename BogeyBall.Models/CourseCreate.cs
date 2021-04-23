using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models
{
    public class CourseCreate
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseLocation { get; set; }
        public DateTime CourseTeeTime { get; set; }

    }
}
