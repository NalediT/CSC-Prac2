using System;

namespace MyStuff
{
    public class Program
    {
        public static string Prefix(string str)
        {
            int i, wrd, l;





            l = 0;
            wrd = 1;

            /* loop till end of string */
            while (l <= str.Length - 1)
            {
                /* check whether the current character is white space or new line or tab character*/
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }



            int count = 0;
            foreach (Char c in str)
            {

                count++;

            }

            string output = $"{wrd},{count}: {str}";
            //Console.Write("Output:{0} and {1} : {2} ", wrd, count, str);
            //Console.ReadLine();
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Prefix("123 12"));
            Console.ReadLine();
        }
    }
}
