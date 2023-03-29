using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class player
    {
        public string  Name { get; set; }
        public int Point { get; set; }

        public player(string name,int point)
        {
            Name = name;
            Point = point;
        }
    }
}
