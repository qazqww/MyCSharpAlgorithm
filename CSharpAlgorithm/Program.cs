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
            String[] temp = Console.ReadLine().Split();
            int N = int.Parse(temp[0]);
            int M = int.Parse(temp[1]);

            Dictionary<string, string> dict = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                temp = Console.ReadLine().Split();
                dict.Add(temp[0], temp[1]);
            }

            for (int i = 0; i < M; i++)
            {
                String site = Console.ReadLine();
                sb.AppendLine(dict[site]);
            }

            Console.WriteLine(sb);
        }
    }
}