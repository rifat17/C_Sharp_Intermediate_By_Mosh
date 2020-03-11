using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
