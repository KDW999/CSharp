using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{

    internal class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            protected int hp;

            //public int Hp { get; set; } = 100; // 자동 구현 프로퍼티, get,set + 필드변수 자동생성
            public int Hp
            {
                get { return hp; }
                set { hp = value; }
            }

            // getter / setter
            //public int GetHp() { return hp; }
            //public void SetHp(int hp)
            //{
            //        this.hp = hp;
            //}   
        }
        static void Main(string[] args)
        {
            // 프로퍼티 : getter / setter를 축약한 문법
            Knight knight = new Knight();
            //knight.SetHp(100);
            knight.Hp = 100;
            int hp = knight.Hp; 
        }
    }
}
