using System;

namespace Lab
{
    public class IntegerNumber
    {
        int number;

        public IntegerNumber(double count)
        {
            number = ErrorCheck(count);
        }

        public int PlusOrMinus(double count)
        {
            number = ErrorCheck(number + count);
            return number;
        }

        public int Multiply(double count)
        {
            number = ErrorCheck(number * count);
            return number;
        }

        public int Get()
        {
            return number;
        }

        public void Write()
        {
            Console.Write(number);
        }

        public int ErrorCheck(double count)
        {
            if (count % 1 != 0)
            {
                Console.WriteLine(count + " converted into " + (int)count);
            }
            return (int)count;
        }
    }
}
