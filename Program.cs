using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        class MyList<T> where T : Monster // T는 어떤거든 넣을 수 있지만 몬스터를 상속받은 클래스여야한다, 특정 제약조건을 걸 수 있음
        { 
            // T는 사용하고 싶은 타입형으로 변경 가능
            T[] arr = new T[10];
            
            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        
        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }
        
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();

            Test<int>(3);
        }
    }
}
