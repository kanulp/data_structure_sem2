using System;
using System.Collections.Generic;
using System.Collections;

namespace Case_study_1
{
    class DoublyLinkedList<T> : IEnumerable<T>, ICollection<T>
    {
        public DoublyLinkedNode<T> HeadNode { get; private set; }
        public DoublyLinkedNode<T> TailNode { get; private set; }
        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();
        public void Add(T item)
        {
            throw new NotImplementedException();
        }
        public void AddFirst(T nodeData)
        {
            DoublyLinkedNode<T> tempNode = HeadNode;
            HeadNode = new DoublyLinkedNode<T>(nodeData);
            HeadNode.NextNode = tempNode;
            Count++;
            if (Count == 1)
                TailNode = HeadNode;
            else
            {
                tempNode.PreviousNode = HeadNode;
            }
        }
        public void AddLast(T nodeData)
        {
            DoublyLinkedNode<T> newNode = new DoublyLinkedNode<T>(nodeData);
            if (Count == 0) 
            { 
                HeadNode = newNode;
                Count++;
            }
            else if (Count == 1)
            {
                HeadNode.NextNode = newNode;
                newNode.PreviousNode = HeadNode;
                TailNode = newNode;
                Count++;
            }
            else
            {
                TailNode.NextNode = newNode;
                newNode.PreviousNode = TailNode;
                TailNode = newNode;
                Count++;
            }
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
          
            DoublyLinkedNode<T> node = HeadNode;
            while (node != null)
            {
                yield return node.nodeData;
                node = node.NextNode;
            }

        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            if (Count != 0)
                {
                    HeadNode = HeadNode.NextNode;
                    Count--;
                    if (Count == 0)
                        TailNode = null;
                    else

                    {
                        HeadNode.PreviousNode = null;
                    }
                }
            }
            public void RemoveLast()
            {
                if (Count == 1)
                {
                    HeadNode = null;
                    TailNode = null;
                }
                else
                {
                    TailNode.PreviousNode.NextNode = null;
                    TailNode = TailNode.PreviousNode;
                }
            }
    }
}

