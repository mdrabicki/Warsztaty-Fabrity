using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Models
{
    public class LayoutViewModel
    {

        public Wall ActiveWall { get; set; }
        public List<Wall> AccessableWalls { get; set; }

    }
}
