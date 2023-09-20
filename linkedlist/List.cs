using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace linkedlist
{
    public class Node<T> 
    {
        public Node(T value)
        {
            Value = value;
        }
        public Node() { }
        public T Value { get; set; }
        public Node<T>? Next { get; set; }
    }

    internal class ListNode<T>: IEnumerable<T>
    {
        Node<T>? head;
        Node<T>? tail;
        int count;

        public void Add(T value)
        {
            Node<T> current = new Node<T>(value);

            if(head == null)
            {
                head = current;
            }
            else
            {
                tail!.Next = current;
            }
            tail = current;
            count++;
        }

        public bool Contains(T value)
        {
            Node<T> node = head;
            while(node != null && node.Value != null)
            {
                if (node.Value.Equals(value))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }


       public void AppendFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = head;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }

        public void Loop(Action<T> action)
        {
            Node<T> current = head;
            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

    }


}
