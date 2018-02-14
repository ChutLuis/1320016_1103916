using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Node<T>
    {
        private T element;
        private Node<T> next;
        private Node<T> prev;
        public Node(T element,Node<T> prevNode, Node<T> nextNode)
        {
            this.element = element;
            this.prev = prevNode;
            this.next = nextNode;
        }
        public T Element
        {
            get { return element; }
            set { element = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node<T> Previous
        {
            get { return this.prev; }
            set { this.prev = value; }
        }

    }
}
