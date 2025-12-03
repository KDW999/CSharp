using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm
{
    internal class Board
    {
        // 배열 : 사용 방 갯수를 고정 사용 (변경 불가(
        // 연속된 방으로 배정 받아 사용 (선형)
        // 장점 : 연속된 방
        // 단점 : 방 추가/축소 불가
        public int[] _data = new int[25]; 

        // 동적 배열(리스트) : 사용할 방 갯수가 유동적
        // 연속된 방으로 배정 받아 사용
        // 동적 배열 할당 정책 : 실제 사용 방보다 여유분을 두고 예약, 이동 횟수를 최소화
        // 장점 : 유동적인 사용
        // 단점 : 중간 삽입/삭제
        public List<int> _data2 = new List<int>();

        // 연결 리스트 : 연속되지 않은 방을 사용
        // 장점 : 중간 추가/삭제 이점
        // 단점 : N번 째 방을 바로 찾을 수가 없음 (임의 접근 Random Access 불가)
        public LinkedList<int> _data3 = new LinkedList<int>();
        public void Initialize()
        {

        }
    }
}
