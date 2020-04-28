using System;
using System.Linq;

namespace Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var delimiter = ',';

            if (numbers.StartsWith("//"))
            {
                 delimiter = numbers[2];
            }
            var ints = numbers.Split(delimiter, '\n');
            var ints2 = ints.Select(Parse).ToList();
            var negatives = ints2.Where(i => i < 0).ToList();
            if (negatives.Count>0)
            {
                throw new Exception($"negatives not allowed {String.Join(',', negatives)}");
            }
            return ints2.Sum();

        }
        private static int Parse(string f)
        {
            Int32.TryParse(f, out var i);
            return i;
        }

    }
}
