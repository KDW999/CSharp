using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {

        // Attribute : 실행 시 주석을 볼 수 있게
        class Important : System.Attribute
        {
            string message;

            public Important(string message) { this.message = message; }
        }
        class Monster
        {
            // hp입니다. 중요한 정보
            [Important("Very Important")]
            public int hp;
            protected int attack;
            private float speed;
            void Attack() { }
        }
        static void Main(string[] args)
        {
            // Reflection : X-Ray, 동적으로 구현 시
            Monster monster = new Monster();
            Type type = monster.GetType();

           var fields = type.GetFields(System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic) 
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                // 데이터의 타입을 볼 수 있게
                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
                // => public Int32 hp
                // protected Int32 attack
                // private Single speed
            }
        }
    }
}
