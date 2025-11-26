using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        class Monster
        {
            public int id;
            public Monster(int id) { this.id = id; }
        }
        static void Main(string[] args)
        {
            // HashTable : 메모리 사용량은 늘지만 성능은 향상
            // Key -> value
            // Dictionary
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for(int i=0; i<10000; i++)
            {
                dic.Add(i, new Monster(i));
            }
            Monster mon;
            bool found = dic.TryGetValue(2000, out mon);

            dic.Remove(7777);
            dic.Clear();
        }
    }
}
