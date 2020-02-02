using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class RidicareLaPutere
    {
        protected int a, b;
        public RidicareLaPutere(int a, int b) //constructorul nu are return type
        {
            this.a = a;
            this.b = b;
        }
        public int rezultat() {
            return (int)Math.Pow(this.a, this.b);
        }
    }
}
