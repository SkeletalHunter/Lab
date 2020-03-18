using System;

namespace Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            NaturalNumber n = new NaturalNumber(-2);
            IntegerNumber i = new IntegerNumber(3);
            RationalNumber r = new RationalNumber(i, n);
            r.Write();
            r.Square();
            r.Write();
        }
    }
}
