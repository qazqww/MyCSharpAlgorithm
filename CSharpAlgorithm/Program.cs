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
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }

                Dictionary<string, int> dict = new Dictionary<string, int>();
                for (int i = 0; i < n; i++)
                {
                    string[] temp = Console.ReadLine().Split();
                    if (dict.ContainsKey(temp[1]))
                        dict[temp[1]]++;
                    else
                        dict.Add(temp[1], 1);
                }

                int answer = 1;
                foreach (int val in dict.Values) {
                    answer *= (val + 1);
                }

                Console.WriteLine(answer - 1);
            }
        }
    }
}