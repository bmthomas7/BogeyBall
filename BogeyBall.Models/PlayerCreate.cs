using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Models.PlayerModel
{
    public class PlayerCreate
    {
        public int PlayerId { get; set; }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int ScoreCardId { get; set; }




        //public int CourseId { get; set; }


    }
}
