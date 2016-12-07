using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyNotesWall.Models;

namespace MyNotesWall.Models
{
    public class ListPageModel
    {
        public IEnumerable<Item> List { get; set; }
        public Item Model { get; set; }
    }
}
