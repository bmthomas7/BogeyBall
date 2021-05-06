﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models
{
    public class ScoreCardDetail
    {
        [Display(Name = "Id")]
        public int ScoreCardId { get; set; }
        [Display(Name = "Player Name")]
        public string ScoreCardPlayerName { get; set; }
        [Display(Name = "Course Name")]
        public string ScoreCardCourseName { get; set; }
        [Display(Name = "Score Total")]
        public int ScoreCardScoreTotal { get; set; }

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
    }
}
