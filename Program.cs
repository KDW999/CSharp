using System.Threading.Channels;

namespace CSharp
{
    internal class Program
    {
        // C#의 주석
        /*
         다중 주석
         */
        static void Main(string[] args)
        {
            // int     정수형 (-1 0 1 2 3 4)
            // float   실수형 (1.0 3.14)
            // string  문자열 ("Rookiss")
            // bool    불리언 (true/false)
            
            // [  ]
            short b = 100;
            // [ ]
            int a = b;

            //Console.WriteLine(a);
            // 100 -> 100.0f
            int d = 100;
            float c = d;
            //Console.WriteLine(c);

            // string -> int
            //string input = Console.ReadLine();
            //int number = int.Parse(input);
            //Console.WriteLine(number);

            // int -> string
            int hp = 100;
            int maxHp = 100;

            // 당신의 HP는 ?? 입니다.
            // stirng Format 방법 : 대입해야할 값이 많아지면 복잡해지는 단점은 있음
            //string message = string.Format("당신의 HP는 {0}/{1}입니다.", hp, maxHp);

            // string interpolation 방법 : 직관적
            string message = $"당신의 HP는 {hp} / {maxHp}입니다";
            Console.WriteLine(message);
        }
    }
}
