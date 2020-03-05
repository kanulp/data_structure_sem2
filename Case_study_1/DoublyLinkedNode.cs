using System;
using System.Collections.Generic;
using System.Text;

namespace Case_study_1
{
    class DoublyLinkedNode<T>
    {
        public T nodeData;
        public DoublyLinkedNode(T nodeData)
        {
            this.nodeData = nodeData;
        }
        public DoublyLinkedNode<T> NextNode { get; set; }
        public DoublyLinkedNode<T> PreviousNode { get; set; }

        public DoublyLinkedNode<T> Nodedata { get; set; }

    }
}
