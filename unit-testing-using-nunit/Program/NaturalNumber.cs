using System;

namespace Lab
{
    /// <summary>
    /// Name of the class
    /// </summary>
    public class NaturalNumber
    {
        /// <summary>
        /// The count of number
        /// </summary>
        int number;
        /// <summary>
        /// Creating number
        /// </summary>
        /// <param name="count">The count</param>
        public NaturalNumber(double count)
        {
            number = ErrorCheck(count);
        }
        /// <summary>
        /// Function that pluses or minuses the count of number
        /// </summary>
        /// <param name="count">The count</param>
        /// <returns>Changed count</returns>
        public int PlusOrMinus(double count)
        {
            number = ErrorCheck(number + count);
            return number;
        }
        /// <summary>
        /// Function that multyplies the count of number
        /// </summary>
        /// <param name="count">The count</param>
        /// <returns>Changed count</returns>
        public int Multiply(double count)
        {
            number = ErrorCheck(number * count);
            return number;
        }
        /// <summary>
        /// Function to get the value of number
        /// </summary>
        /// <returns>The value of number</returns>
        public int Get()
        {
            return number;
        }
        /// <summary>
        /// Function to write the value of number to console
        /// </summary>
        public void Write()
        {
            Console.Write(number);
        }
        /// <summary>
        /// Check for errors
        /// </summary>
        /// <param name="count">The count</param>
        /// <returns>Nice number</returns>
        public int ErrorCheck(double count)
        {
            double firstCount = count;
            bool changed = false;
            if (count < 1)
            {
                count = -count;
                changed = true;
                if (count < 1)
                {
                    count = 1;
                }
            }
            if (changed || count % 1 != 0)
            {
                Console.WriteLine(firstCount + " converted into " + (int)count);
            }
            return (int)count;
        }
    }
}
