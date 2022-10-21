﻿using System.Text;

namespace CSharpAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

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