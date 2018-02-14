using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class DoublyLinkedList<T>
    {
        private Node<T> header = null;
        private Node<T> trailer = null;
        private int size = 0;
        public DoublyLinkedList()
        {
            header = new Node<T>(default(T), null, null);
            trailer = new Node<T>(default(T), header, null);
            header.Next=trailer;
        }
        public int Size()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }
        public T first()
        {
            if (isEmpty())
                return default(T);
            T ele = header.Previous.Element;
            return ele;
        }

        public T last()
        {
            if (isEmpty())
                return default(T);
            return trailer.Previous.Element;
        }
        public void addFirst(T e)
        {
            addBetween(e, header, header.Next);
        }

        public void addLast(T e)
        {
            addBetween(e, trailer.Previous, trailer);
        }

        public T removeFirst()
        {
            if (isEmpty())
                return default(T);
            return remove(header.Next);
        }
        public T removeLast()
        {
            if (isEmpty())
                return default(T);
            return remove(trailer.Previous);
        }
        private void addBetween(T e, Node<T> predecessor, Node<T> successor)
        {
            Node<T> newest = new Node<T>(e, predecessor, successor);
            predecessor.Next=newest;
            successor.Previous=newest;
            size++;
        }
        private T remove(Node<T> node)
        {
            Node<T> predecessor = node.Previous;
            Node<T> successor = node.Next;
            predecessor.Next=successor;
            successor.Previous=predecessor;
            size--;
            return node.Element;
        }

    }
}
