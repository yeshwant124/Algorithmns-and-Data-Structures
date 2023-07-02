using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class SimpleLinkedListWithGenerics<T>
    {
        Node<T> head = null;
        Node<T> tail = null;

        public void AddLast(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.nextNode = newItem;
                tail = newItem;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> newItem = new Node<T>();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.nextNode = head;
                head = newItem;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            else
            {                
                tail = null;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                head = head.nextNode;
            }
        }

        public void ReadAll()
        {
            Node<T> current = head;

            while (current.nextNode != null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;
            }
            Console.WriteLine(current.data);
        }
    }
}
