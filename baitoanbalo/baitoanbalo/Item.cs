using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitoanbalo
{
    class Item
    {
        private float weight;
        private float value;
        private String name;

        public float Weight { get => weight; set => weight = value; }
        public float Value { get => value; set => this.value = value; }
        public string Name { get => name; set => name = value; }
    }
}
