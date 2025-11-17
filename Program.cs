using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    // OOP(은닉성/상속성/다형성)
   
    // 자동차
    // 핸들 페달 차문
    // 전기장치 엔진 기름 <-> 외부 노출
    // 설계 시 위험하냐, 대충 사용해도되냐의 보안레벨

    class Knight
    {
        // 접근 한정자
        // public 모두 접근
        // protected 자식 클래스는 접근 가능
        // private 같은 클래스 내에서만, 접근한정자 아무것도 안붙이면 기본적으로 private
        // 변수를 private 메서드를 public으로 사용하면 여러 곳에서 hp를 사용 시 어디서 사용했는지 찾기가 쉽다
        protected int hp;
 

    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }

        

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.SetHp(100);

        }
    }
}
