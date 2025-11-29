using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }  

        static void Main(string[] args)
        {
             InputManager inputManager = new InputManager();
             inputManager.InputKey += OnInputTest;
            while (true)
            {
                inputManager.Update();
            }

            //inputManager.InputKey(); Event는 Delegate와 다르게 이런 식으로 단독으로 호출이 불가
            // 외부에서 멋대로 부르지 못하게 하기 위함
        }
    }
}
