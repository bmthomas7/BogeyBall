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
        [Required]
        public string PlayerName { get; set; }
        

    }
}
