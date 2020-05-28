using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class booton
    { 
        public string color { get; set; }
        public booton (string k)
        {
            color = k;
        }
        public override string ToString()
        {
            return "колiр бутона" + color ;
        }
        public override int GetHashCode()
        {
            return color.Length;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var boot = (booton)obj;
            return (this.color == boot.color);
        }
    }
}
