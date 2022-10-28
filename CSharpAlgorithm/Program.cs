using System.Text;

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
            int n = int.Parse(Console.ReadLine());
            int answer = 0;

            List<int> list = new List<int>();
            list.Add(0);
            int i = 1;
            while (Math.Pow(i, 2) <= 50000)
            {
                list.Add((int)Math.Pow(i++, 2));
            }

            while (n > 0) {
                int low = 0;
                int high = list.Count - 1;
                int mid = -1;
                while (low < high)
                {
                    mid = (low + high) / 2;
                    Console.WriteLine($"{low} {mid} {high}");
                    if (list[mid] > n)
                        high = mid;
                    else
                        low = mid + 1;
                }

                if (n != 0)
                {
                    answer++;
                    n -= list[mid - 1];
                    Console.WriteLine($"!{list[mid - 1]}");
                }
            }

            Console.WriteLine(answer);
        }
    }
}