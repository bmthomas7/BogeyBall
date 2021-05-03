using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class ScoreCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Player Player { get; set; }

        //[Required]
        //public int Hole { get; set; }

        //[Required]
        //public string Course { get; set; }

        public virtual Course Course { get; set; }
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
    }
}
