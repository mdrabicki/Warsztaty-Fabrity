using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Models

{
    public class Item
    {
        
        public int ItemId { get; set; }
        [StringLength(160),MinLength(5), Required(ErrorMessage = "Pole nie może zostać puste"),Display(Name = "Title")]
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }
        public int CategoryId { get; set; }




        public string OwnerId { get; set; }
        public int WallID { get; set; }


        //    public virtual Wall Wall { get; set; }
        //  public virtual ApplicationUser Owner { get; set; }
        //  public virtual UserWallItem UserWallItem { get; set; }
        //  public ICollection<UserWallItem> UserWallItems { get; set; }



    }
}
