using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm
{

    class MyList<T>
    {
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count; // 실제로 사용 중인 데이터 갯수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 갯수

        // 0(1) 예외 케이스 : 이사 비용 무시
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인
            if (Count >= Capacity)
            {
                // 공간을 다시 늘려서 확보
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = _data[i];
                    _data = newArray;
                }
            }
            // 2. 공간에 데이터를 넣어준다.
            _data[Count] = item;
            Count++;
        }

        // 0(1)

        public T this[int index]
        {
            get { return _data[index];  }
            set { _data[index] = value; }
        }

        // O(N)
        public void RemoveAt(int index)
        {
            for(int i=index; i<Count-1; i++)
            {
                _data[i] = _data[Count - 1];
                _data[Count - 1] = default(T);
            }
            Count--;
        }
    }
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
        public MyList<int> _data2 = new MyList<int>();

        // 연결 리스트 : 연속되지 않은 방을 사용
        // 장점 : 중간 추가/삭제 이점
        // 단점 : N번 째 방을 바로 찾을 수가 없음 (임의 접근 Random Access 불가)
        public LinkedList<int> _data3 = new LinkedList<int>();
        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);
        }
    }
}
