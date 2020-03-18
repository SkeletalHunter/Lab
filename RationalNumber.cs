using System;

namespace Lab
{
    public class RationalNumber
    {
        IntegerNumber upNumber;
        NaturalNumber downNumber;

        public RationalNumber(IntegerNumber a, NaturalNumber b)
        {
            this.upNumber = a;
            this.downNumber = b;
        }

        public RationalNumber Square()
        {
            this.upNumber.Multiply(this.upNumber.Get());
            this.downNumber.Multiply(this.downNumber.Get());
            return this;
        }

        public void Write()
        {
            upNumber.Write();
            Console.Write("/");
            downNumber.Write();
            Console.WriteLine();
        }
    }
}
