using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Case_study_1
{
    class Queue<T> : IEnumerable<T>, ICollection<T>
    {
        public bool IsReadOnly => throw new NotImplementedException();
        DoublyLinkedList<T> ddl = new DoublyLinkedList<T>();
        public int Count => ddl.Count;
        public void Enqueue(T nodedata)
        {
            ddl.AddLast(nodedata);
        }

        public void Dequeue()
        {
            ddl.RemoveFirst();
        }
        public DoublyLinkedNode<T> Peek()
        {
            return ddl.HeadNode;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ddl.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
