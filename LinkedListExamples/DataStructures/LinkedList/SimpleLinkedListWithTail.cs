using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class SimpleLinkedListWithTail
    {
        Node<object> head = null;
        Node<object> tail = null;

        public void AddLast(object data)
        {
            Node<object> newItem = new Node<object>();
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

        public void AddFirst(object data)
        {
            Node<object> newItem = new Node<object>();
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

        public void ReadAll()
        {
            Node<object> current = head;

            while (current.nextNode != null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;
            }
            Console.WriteLine(current.data);
        }
    }
}
