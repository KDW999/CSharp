using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    // 객체(OOP Object Oriented Programming)

    // Ref 참조
    class Knight
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        static public void Test()
        {
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            return knight;
        }
        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 0;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }

        public Knight(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출");
        }
        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }
        public void Move()
        {
            Console.WriteLine("knight Move");
        }
        public void Attack()
        {
            Console.WriteLine("knight Attack");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight(); // static
            knight.Move(); // 일반
        }
    }
}
