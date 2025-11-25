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
            int[] arr = new int[10];

            // List <- 동적 배열
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++) list.Add(i);

            // 삽입 삭제
            //list.Insert(2, 999);

            //bool success =  list.Remove(3); // Remove는 해당 값 삭제
            //list.RemoveAt(0); // RemoveAt는 해당 인덱스 삭제
            list.Clear(); // 전체 삭제

            for (int i=0; i<list.Count; i++)
                Console.WriteLine(list[i]);

            foreach(int num in list)
                Console.WriteLine(num);
        }
    }
}
