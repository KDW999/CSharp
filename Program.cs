using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        // delegate -> 함수 자체를 인자로 넘겨주는 형식
        // 반환:int, 입력:void
        // OnClicked이 delegate 형식의 이름
        delegate int OnClicked();

        static void ButtonPressed(OnClicked clickedFunction)
        {
            // 함수 호출
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate 2");
            return 0;
        }

        static void Main(string[] args)
        {
            // ★ delegate (대리자), CallBack
            // 메서드를 데이터 취급하여 전달할 수 있고, 어떤 메서드가 실행될 지는 실행 시점에 정한다.
            Console.WriteLine();

            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2; // 여러 함수를 체이닝해서 사용 가능

            ButtonPressed(clicked);
        }
    }
}
