using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laba_1;

namespace Laba_1.Classes
{
    public class Calculator: ICalculator
    {
        public  int[] ConsonantsAndVowels(string str)
        {
            char[] consonants = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь'};
            char[] vowels = new char[] { 'а', 'е', 'ё', 'и', 'й', 'о', 'у', 'э', 'ю', 'я' };
            int c = 0;
            int v = 0;

            foreach (char s in str)
            {
                if (consonants.Contains(Char.ToLower(s)))
                    c++;
                else if (vowels.Contains(Char.ToLower(s)))
                    v++;
            }
            return new int[] { c, v };
        }

        public  string GetLength(string str)
        {
            return str.Length.ToString();
        }

        public  string WordCount(string str)
        {
            return str.Split(' ').Length.ToString();
        }

        public  string SenCount(string str)
        {
            char[] endOfSen = new char[] { '.', '?', '!' };
            if (!endOfSen.Contains(str[^1]))
            {
                return str.Split(endOfSen).Length.ToString();
            }
            else
            {
                int result = str.Split(endOfSen).Length - 1;
                return result.ToString();
            }
        }
    }
}
