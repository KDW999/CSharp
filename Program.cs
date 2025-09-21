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

            // [데이터 타입] [이름];
            int hp = 500;
            int maxHp;

            // TODO
            maxHp = hp;

            // [ 메모리 공간 ]
            float a;
            a = 4.5f;

            double b;
            b = 3.5;

            string name;
            name = "Rookiss";

            char ch = 'R';

            Console.WriteLine(name);
            Console.WriteLine(ch);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(hp);
        }
    }
}
