using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warsztaty.Data.Models;

namespace Warsztaty.Data
{
    public class ListPageModel
    {
        public IEnumerable<Item> List { get; set; }
        public Item Model { get; set; }
    }
}
