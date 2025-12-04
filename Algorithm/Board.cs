using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm
{
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;
        public MyLinkedListNode<T> Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> Head = null; // 첫 번째
        public MyLinkedListNode<T> Tail = null; // 마지막
        public int Count = 0;

        // 0(1)
        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();
            newRoom.Data = data;

            // 아직 방이 아예 없었다면, 새로 추가한 첫 번째 방이 곧 Head
            if (Head == null)
                Head = newRoom;

            // 기존의 마지막 방과 새로 추가되는 방을 연결
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            // 새로 추가되는 방을 마지막 방으로 인정
            Tail = newRoom;
            Count++;
            return newRoom;
        }

        // 0(1)
        public void Remove(MyLinkedListNode<T> room)
        {
            // 삭제하는 게 첫 번째 방이라면 두 번째 방이 첫 번째 방이 된다
            if (Head == room)
                Head = Head.Next;

            // 삭제하는 게 마지막 방이라면 마지막 앞 방이 마지막 방이 된다
            if (Tail == room)
                Tail = Tail.Prev;

            // 삭제할 노드의 앞 뒤 연결
            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    internal class Board
    {
        public int[] _data = new int[25];
        public MyLinkedList<int> _data3 = new MyLinkedList<int>();
        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
