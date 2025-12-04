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
                    newArray[i] = _data[i];
                _data = newArray;
            }
            // 2. 공간에 데이터를 넣어준다.
            _data[Count] = item;
            Count++;
        }

        // 0(1)

        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        // O(N)
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];

            _data[Count - 1] = default(T);
            Count--;
        }
    }

    internal class Board
    {
        public int[] _data = new int[25];

    }
}
