using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogeyBall.Data
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public int Handicap { get; set; }

        public virtual ICollection<ScoreCard> ScoreCardList { get; set; }

        public Player()
        {
            ScoreCardList = new HashSet<ScoreCard>();
        }

    }
}
