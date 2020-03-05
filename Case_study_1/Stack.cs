using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Case_study_1
{
    class Stack<T> : IEnumerable<T>, ICollection<T>
    {
        DoublyLinkedList<T> ddl = new DoublyLinkedList<T>();
        public int Count => ddl.Count;
        public bool IsReadOnly => throw new NotImplementedException();
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
        public void push(T nodeData) {

            ddl.AddLast(nodeData);

        }
        public void pop()
        {
            ddl.RemoveLast();
        }

        public DoublyLinkedNode<T> peek()
        {
           return ddl.HeadNode;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ddl.GetEnumerator();
        }
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
