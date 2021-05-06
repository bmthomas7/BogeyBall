using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class ScoreCard
    {
     
        public int ScoreCardId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int Handicap { get; set; }

        //public virtual ICollection<Player> PlayerList { get; set; }

        //public virtual ICollection<Course> CourseList { get; set; }

        public int ScoreTotal { get; set; }

        public int HoleTotal { get; set; }

        //public ScoreCard()
        //{
        //    PlayerList = new HashSet<Player>();
        //    CourseList = new HashSet<Course>();
        //}

        //[Required]
        //public int Hole { get; set; }

        //[Required]
        //public string Course { get; set; }

        // this is where alot of foreign keys come into place

        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreOne { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreTwo { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreThree { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreFour { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreFive { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreSix { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreSeven { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreEight { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreNine { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreTen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreEleven { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreTwelve { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreThirteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreFourteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreFifteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreSixteen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreSeventeen { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Please Enter a Number between 1 and 100")]
        public int ScoreEighteen { get; set; }







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
