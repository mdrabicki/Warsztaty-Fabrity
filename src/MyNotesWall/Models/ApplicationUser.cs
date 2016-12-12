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
            UserWallItems = new HashSet<UserWallItem>();
        }

        public virtual UserWallItem UserWallItem { get; set; }
        public ICollection<UserWallItem> UserWallItems { get; set; }
 

    }
}
