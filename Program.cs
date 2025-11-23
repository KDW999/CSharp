using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열, 
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            // new int로 동적할당하기에 참조타입

            int[] scores2 = scores;
            scores2[0] = 5555;
            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            for(int i=0; i<scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
