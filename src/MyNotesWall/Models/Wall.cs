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
        public Wall()
        {
          
            UserWallItems = new HashSet<UserWallItem>();
        }

        
        public int WallId { get; set; }

        public string Name { get; set; }
        public string OwnerID { get; set; }


        public virtual UserWallItem UserWallItem { get; set; }
        public virtual ICollection<UserWallItem> UserWallItems { get; set; }
        
    }
}
