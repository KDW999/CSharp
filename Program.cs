using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        static int Find()
        {
            return 0;
        }

        class Monster
        {
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {
            // Nullable -> Null + able
            int? number = null;

            // 이런 식으로 아래의 null 체크를 한 번에 가능
            int b = number ?? 0; // 값이 있으면 원래값 쓰고 null이라면 0으로 초기화
            Console.WriteLine(b);

            //int c = (number != null) ? number.Value : 0; 삼항연산자랑 유사하다

            if(number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            // Nullable -> ?를 붙이는 형식
            // null을 가질 수 있음
            // ?? / ?. 처럼 null 체크를 줄여서 사용 가능
            Monster monster = null;

            if(monster != null)
            {
                int monsterId = monster.Id;
            }

            int? id = monster?.Id; // monster가 null이라면 id는 null 값이 있다면 id = monster.Id
            // 위의 형식은 아래의 조건 체크와 같다
            if(monster == null)
            {
                id = null;
            }
            else
            {
                id = monster.Id;
            }
        }
    }
}
