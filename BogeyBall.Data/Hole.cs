﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class Hole
    {
        public enum NameOfScoring
        {
            Eagle = -2,
            Birdy = -1,
            Par = 0,
            Bogey = 1,
            DoubleBogey = 2
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Stroke { get; set; }

        public NameOfScoring Scoring { get; set; }

    }
}
