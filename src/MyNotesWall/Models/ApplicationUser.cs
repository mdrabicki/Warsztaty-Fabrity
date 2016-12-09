using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyNotesWall.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Walls = new HashSet<Wall>();
            Items = new HashSet<Item>();
        }
        public virtual ICollection<Wall> Walls { get; set; }
        public virtual ICollection<Item> Items { get; set; }

    }
}
