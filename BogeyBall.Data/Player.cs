using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public virtual ScoreCard ScoreCard { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int Handicap { get; set; }

        [Required]
        public string FullName { get; set; }


    }
}
