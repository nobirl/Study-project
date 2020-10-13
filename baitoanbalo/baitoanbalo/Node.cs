using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitoanbalo
{
    class Node
    {
        public int profit;
        public int bound;
        public float weight;
        public int level;

        public int Bound { get => bound; set => bound = value; }
        public float Weight { get => weight; set => weight = value; }
        public int Level { get => level; set => level = value; }
        public int Profit { get => profit; set => profit = value; }
    }
}
