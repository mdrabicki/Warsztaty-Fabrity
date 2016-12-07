using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(160),MinLength(5), Required(ErrorMessage = "Pole nie może zostać puste"),Display(Name = "Title")]
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }

    }
}
