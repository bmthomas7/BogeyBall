using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models
{
    public class ScoreCardListItem
    {
        public int ScoreCardId { get; set; }

        public string ScoreCardCourseName { get; set; }

        public string ScoreCardPlayerName { get; set; }

        public int ScoreCardScoreTotal { get; set; }

        public int ScoreCardHandicap { get; set; }

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









        [Display(Name = "Player Stroke Hole 1")]
        public int ScoreCardHoleOne { get; set; }

        [Display(Name = "Player Stroke Hole 2")]
        public int ScoreCardHoleTwo { get; set; }

        [Display(Name = "Player Stroke Hole 3")]
        public int ScoreCardHoleThree { get; set; }

        [Display(Name = "Player Stroke Hole 4")]
        public int ScoreCardHoleFour { get; set; }

        [Display(Name = "Player Stroke Hole 5")]
        public int ScoreCardHoleFive { get; set; }

        [Display(Name = "Player Stroke Hole 6")]
        public int ScoreCardHoleSix { get; set; }

        [Display(Name = "Player Stroke Hole 7")]
        public int ScoreCardHoleSeven { get; set; }

        [Display(Name = "Player Stroke Hole 8")]
        public int ScoreCardHoleEight { get; set; }

        [Display(Name = "Player Stroke Hole 9")]
        public int ScoreCardHoleNine { get; set; }

        [Display(Name = "Player Stroke Hole 10")]
        public int ScoreCardHoleTen { get; set; }

        [Display(Name = "Player Stroke Hole 11")]
        public int ScoreCardHoleEleven { get; set; }

        [Display(Name = "Player Stroke Hole 12")]
        public int ScoreCardHoleTwelve { get; set; }

        [Display(Name = "Player Stroke Hole 13")]
        public int ScoreCardHoleThirteen { get; set; }

        [Display(Name = "Player Stroke Hole 14")]
        public int ScoreCardHoleFourteen { get; set; }

        [Display(Name = "Player Stroke Hole 15")]
        public int ScoreCardHoleFifteen { get; set; }

        [Display(Name = "Player Stroke Hole 16")]
        public int ScoreCardHoleSixteen { get; set; }

        [Display(Name = "Player Stroke Hole 17")]
        public int ScoreCardHoleSeventeen { get; set; }

        [Display(Name = "Player Stroke Hole 18")]
        public int ScoreCardHoleEighteen { get; set; }



    }
}
