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

        public virtual ScoreCard ScoreCard { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTime TeeTime { get; set; }

        public int HoleTotal { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleOne { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleTwo { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleThree { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleFour { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleFive { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleSix { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleSeven { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleEight { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleNine { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleTen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleEleven { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleTwelve { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleThirteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleFourteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleFifteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleSixteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleSeventeen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int HoleEighteen { get; set; }
    }
}
