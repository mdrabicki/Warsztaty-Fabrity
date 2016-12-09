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
            this.Items = new HashSet<Item>();
            this.UsersWithAccess = new HashSet<ApplicationUser>();
        }
        int ID { get; set; }
        [Required]
        string Name { get; set; }
        string OwnerID { get; set; }

        [ForeignKey("OwnerRefId")]
        public virtual ApplicationUser Owner { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<ApplicationUser> UsersWithAccess { get; set; }
        
    }
}
