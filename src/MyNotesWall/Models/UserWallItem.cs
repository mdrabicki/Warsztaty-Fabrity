using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Models
{
    public class UserWallItem
    {
        
        public int UserWallItemId { get; set; }

        public UserWallItem()
        {
            Wall = new Wall();
            User = new ApplicationUser();
            Item = new Item();
        }
      /*  public int WallId { get; set; }
        public int ItemId { get; set; }
        public string UserId { get; set; }*/

        public virtual Wall Wall { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Item Item { get; set; }

        public virtual ICollection<Wall> Walls { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
