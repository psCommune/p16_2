using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace p16_2
{
    class Exam
    {
        public static string Second(string[] mass)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                char[] str = new char[mass[i].Length];
                for (int j = 0; j < mass[i].Length; j++)
                {
                    str[j] = mass[i][j];
                }
                count += (from k in str where char.IsNumber(k) select i).Count();

            }
            return $"Кол-во цифр {count}";
        }

        public static string Second2(string[] mass)
        {
            string str = string.Empty;
            var vivod = mass.TakeWhile(x => !x.Contains('/'));
            foreach (var item in vivod)
            {
                str += item + " ";
            }
            return str;
        }

        public static string Second3(string[] mass)
        {
            string str = string.Empty;
            var vivod = mass.SkipWhile(x => !x.Contains('/'));
            foreach (var item in vivod)
            {
                str += item + " ";
            }
            string vivod2 = new string(str.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)).ToArray());
            StreamWriter sr = new StreamWriter("zad2.txt");
            sr.WriteLine(vivod2);
            sr.Close();
            return vivod2;
        }
    }
}
