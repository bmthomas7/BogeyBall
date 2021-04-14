using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        
        public string CourseName { get; set; }

        public string Location { get; set; }

        [Required]
        public DateTime TeeTime { get; set; }
    }
}
