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
        //[ForeignKey("ScoreCard")]
        [Key]
        public int PlayerId { get; set; }
        //public virtual ScoreCard ScoreCard { get; set; }

        //[ForeignKey("ForeignHoleTotal")]
        //public int CourseId { get; set; }
        //public virtual ICollection<Course> CourseList { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        //public int Handicap { get; set; }

        public string FullName { get; set; }

        //public virtual ICollection<ScoreCard> ScoreCardList { get; set; }
        

        //public Player()
        //{
        //    ScoreCardList = new HashSet<ScoreCard>();
        //    CourseList = new HashSet<Course>();
        //}

    }
}
