using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    // Observer Parttern : 특정 상황 발생 시 알려주는 디자인 패턴
    internal class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable == false)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A) // A키를 누른다면
            {
                // 모두에게 알려주기
                InputKey();
            }
        }
    }
}
