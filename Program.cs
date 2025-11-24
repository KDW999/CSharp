using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int highest = 0;
            foreach (int score in scores)
            {
                if (score > highest) highest = score;
            }
            return highest;
        }

        static int GetAverageScore(int[] scores)
        {
            if(scores.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            return sum / scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i< scores.Length; i++)
            {
                if (scores[i] == value) return i;
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                // [i ~ scores.Length - 1 ] 제일 작은 숫자가 있는 index를 찾는다.
                int minIndex = i;
                for(int j=i; j<scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex]) minIndex = j;
                }

                // swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;

            }

            //for (int i = 0; i < scores.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < scores.Length; j++)
            //    {
            //        if (scores[i] > scores[j])
            //        {
            //            int temp = scores[i];
            //            scores[i] = scores[j];
            //            scores[j] = temp;
            //        }

            //    }
            //}

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
        static void Main(string[] args)
        {
            // 배열, 
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
            int highestValue = GetHighestScore(scores);
            Console.WriteLine(highestValue);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 25);
            Console.WriteLine(index);

            Sort(scores);

        }
    }
}
