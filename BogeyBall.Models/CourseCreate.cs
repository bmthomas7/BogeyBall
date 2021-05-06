using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models
{
    public class CourseCreate
    {
        [Display(Name = "Id")]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        [Display(Name = "Location")]
        public string CourseLocation { get; set; }
        [Display(Name = "Tee time")]
        public DateTime CourseTeeTime { get; set; }

        //[Display(Name = "Hole 1")]
        //public int CourseHoleOne { get; set; }

        //[Display(Name = "Hole 2")]
        //public int CourseHoleTwo { get; set; }

        //[Display(Name = "Hole 3")]
        //public int CourseHoleThree { get; set; }

        //[Display(Name = "Hole 4")]
        //public int CourseHoleFour { get; set; }

        //[Display(Name = "Hole 5")]
        //public int CourseHoleFive { get; set; }

        //[Display(Name = "Hole 6")]
        //public int CourseHoleSix { get; set; }

        //[Display(Name = "Hole 7")]
        //public int CourseHoleSeven { get; set; }

        //[Display(Name = "Hole 8")]
        //public int CourseHoleEight { get; set; }

        //[Display(Name = "Hole 9")]
        //public int CourseHoleNine { get; set; }

        //[Display(Name = "Hole 10")]
        //public int CourseHoleTen { get; set; }

        //[Display(Name = "Hole 11")]
        //public int CourseHoleEleven { get; set; }

        //[Display(Name = "Hole 12")]
        //public int CourseHoleTwelve { get; set; }

        //[Display(Name = "Hole 13")]
        //public int CourseHoleThirteen { get; set; }

        //[Display(Name = "Hole 14")]
        //public int CourseHoleFourteen { get; set; }

        //[Display(Name = "Hole 15")]
        //public int CourseHoleFifteen { get; set; }

        //[Display(Name = "Hole 16")]
        //public int CourseHoleSixteen { get; set; }

        //[Display(Name = "Hole 17")]
        //public int CourseHoleSeventeen { get; set; }

        //[Display(Name = "Hole 18")]
        //public int CourseHoleEighteen { get; set; }

    }
}
