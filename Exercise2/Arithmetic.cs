using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Arithmetic
    {
        private double a;
        private double b;

        public double subtraction() {
            return a - b;
        }
        public double multiplication() {
            return a * b;
        }
        public double addition()
        {
            return a + b;
        }
        public double division()
        {
            return a / b;
        }
        public double A
        { 
            set { a = value; } 
            get { return a; } 
        }
        public double B
        {
            set { b = value; }
            get { return b; }
        }

    }
}
