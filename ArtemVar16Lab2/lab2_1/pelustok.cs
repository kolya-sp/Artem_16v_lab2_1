using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class pelustok
    {
        public int n { get; set; }
        public pelustok(int k)
        {
            n = k;
        }
        public override string ToString()
        {
            return n + " pelustok ";
        }
        public override int GetHashCode()
        {
            return n;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            var pel = (pelustok)obj;
            return (this.n == pel.n);
        }
    }
}
