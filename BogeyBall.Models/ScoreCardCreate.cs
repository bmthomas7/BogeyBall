using BogeyBall.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models
{
    public class ScoreCardCreate
    {
        

        public int ScoreCardId { get; set; }

        public string ScoreCardCourseName { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        //public ICollection<Player> PlayerList { get; set; }

        //public ICollection<Course> TeeTimeList { get; set }


        public string ScoreCardPlayerName { get; set; }

        public int ScoreCardHandiCap { get; set; }


        [Display(Name = "Hole 1")]
        public int ScoreCardScoreOne { get; set; }

        [Display(Name = "Hole 2")]
        public int ScoreCardScoreTwo { get; set; }

        [Display(Name = "Hole 3")]
        public int ScoreCardScoreThree { get; set; }

        [Display(Name = "Hole 4")]
        public int ScoreCardScoreFour { get; set; }

        [Display(Name = "Hole 5")]
        public int ScoreCardScoreFive { get; set; }

        [Display(Name = "Hole 6")]
        public int ScoreCardScoreSix { get; set; }

        [Display(Name = "Hole 7")]
        public int ScoreCardScoreSeven { get; set; }

        [Display(Name = "Hole 8")]
        public int ScoreCardScoreEight { get; set; }

        [Display(Name = "Hole 9")]
        public int ScoreCardScoreNine { get; set; }

        [Display(Name = "Hole 10")]
        public int ScoreCardScoreTen { get; set; }

        [Display(Name = "Hole 11")]
        public int ScoreCardScoreEleven { get; set; }

        [Display(Name = "Hole 12")]
        public int ScoreCardScoreTwelve { get; set; }

        [Display(Name = "Hole 13")]
        public int ScoreCardScoreThirteen { get; set; }

        [Display(Name = "Hole 14")]
        public int ScoreCardScoreFourteen { get; set; }

        [Display(Name = "Hole 15")]
        public int ScoreCardScoreFifteen { get; set; }

        [Display(Name = "Hole 16")]
        public int ScoreCardScoreSixteen { get; set; }

        [Display(Name = "Hole 17")]
        public int ScoreCardScoreSeventeen { get; set; }

        [Display(Name = "Hole 18")]
        public int ScoreCardScoreEighteen { get; set; }



        [Display(Name = "HoleTotal")]
        public int CourseHoleTotal { get; set; }

        [Display(Name = "Player Stroke Hole 1")]
        public int CourseHoleOne { get; set; }

        [Display(Name = "Player Stroke Hole 2")]
        public int CourseHoleTwo { get; set; }

        [Display(Name = "Player Stroke Hole 3")]
        public int CourseHoleThree { get; set; }

        [Display(Name = "Player Stroke Hole 4")]
        public int CourseHoleFour { get; set; }

        [Display(Name = "Player Stroke Hole 5")]
        public int CourseHoleFive { get; set; }

        [Display(Name = "Player Stroke Hole 6")]
        public int CourseHoleSix { get; set; }

        [Display(Name = "Player Stroke Hole 7")]
        public int CourseHoleSeven { get; set; }

        [Display(Name = "Player Stroke Hole 8")]
        public int CourseHoleEight { get; set; }

        [Display(Name = "Player Stroke Hole 9")]
        public int CourseHoleNine { get; set; }

        [Display(Name = "Player Stroke Hole 10")]
        public int CourseHoleTen { get; set; }

        [Display(Name = "Player Stroke Hole 11")]
        public int CourseHoleEleven { get; set; }

        [Display(Name = "Player Stroke Hole 12")]
        public int CourseHoleTwelve { get; set; }

        [Display(Name = "Player Stroke Hole 13")]
        public int CourseHoleThirteen { get; set; }

        [Display(Name = "Player Stroke Hole 14")]
        public int CourseHoleFourteen { get; set; }

        [Display(Name = "Player Stroke Hole 15")]
        public int CourseHoleFifteen { get; set; }

        [Display(Name = "Player Stroke Hole 16")]
        public int CourseHoleSixteen { get; set; }

        [Display(Name = "Player Stroke Hole 17")]
        public int CourseHoleSeventeen { get; set; }

        [Display(Name = "Player Stroke Hole 18")]
        public int CourseHoleEighteen { get; set; }


    }
}
