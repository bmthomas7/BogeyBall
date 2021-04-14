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
        public string Player { get; set; }

        [Required]
        public int Hole { get; set; }

        [Required]
        public string Course { get; set; }

        // this is where alot of foreign keys come into place
    }
}
