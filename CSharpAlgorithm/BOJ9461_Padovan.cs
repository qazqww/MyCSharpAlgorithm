// https://www.acmicpc.net/problem/9461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithm
{
    internal class BOJ9461_Padovan
    {
        static void Solution()
        {
            long[] padovan = new long[101];
            padovan[1] = 1;
            padovan[2] = 1;
            padovan[3] = 1;
            padovan[4] = 2;
            padovan[5] = 2;

            for (int i = 6; i < padovan.Length; i++)
            {
                padovan[i] = padovan[i - 5] + padovan[i - 1];
            }

            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(padovan[int.Parse(Console.ReadLine())]);
            }
        }
    }
}
