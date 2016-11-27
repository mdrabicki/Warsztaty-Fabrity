using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warsztaty.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }

    }
}
