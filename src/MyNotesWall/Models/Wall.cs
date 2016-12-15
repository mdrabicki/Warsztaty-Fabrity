using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Models
{
    public class Wall
    {        
        public int WallId { get; set; }
        [Required]
        public string Name { get; set; }
        
        
    }
}
