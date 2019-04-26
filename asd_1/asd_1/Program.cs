using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace asd_1 //CONSEC
{
    class Program
    {
        static StringBuilder result = new StringBuilder(100000);
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            Debug.Assert(T >= 1 && T <= 15);

            //StringBuilder S = new StringBuilder();

            string S = Console.ReadLine();
            Debug.Assert(S.Length >= 1 && S.Length <= 200_000);

            int Q = int.Parse(Console.ReadLine());
            Debug.Assert(Q >= 1 && Q <= 100_000);

            for(int i= 1; i<=Q; i++)
            {
                Solution(S, i);
            }

            Console.WriteLine(result.ToString());
        }

        static void Solution(string s, int caseNo)
        {
            result.Append($"Case {caseNo}:");

            string[] tabStr = (Console.ReadLine()).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] tabInt = Array.ConvertAll(tabStr, int.Parse);

            int queryType = tabInt[0];
            int index = tabInt[1];

            #region my_code
            //int f_indx;
            //int l_indx;

            /*if (Sb[index] == Sb[index - i])
                f_indx = index - 1;
            else
            {
                f_indx = index;
                break;
            }*/
            #endregion

            StringBuilder Sb = new StringBuilder(s);

            switch (queryType)
            {
                case 1:
                    int b = index;
                    for( b= index; b >= 0; b--)
                        if (Sb[index] != Sb[b]) break;
                    b++;

                    int e = index;
                    for (e = index; e <= Sb.Length; e++)
                        if (Sb[index] != Sb[e]) break;
                    e--;

                    result.Append($"{e-b+1}");
                    break;

                case 2:
                    Sb[index] = '#';
                    break;

                default:
                    throw new ArgumentException();
            }
            
        }
    }
}
