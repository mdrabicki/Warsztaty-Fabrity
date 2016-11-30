using System;
using System.Collections.Generic;

namespace Warsztaty.Models.DbEntities
{
    public partial class Items
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
    }
}
