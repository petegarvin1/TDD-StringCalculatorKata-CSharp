﻿namespace StringCalculatorKata.Source
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            return int.Parse(numbers);
        }
    }
}