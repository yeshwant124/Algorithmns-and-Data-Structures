using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class SimpleLinkedList
    {
        Node<object> head = null;
        
        public void AddLast(object data)
        {
            Node<object> newItem = new Node<object>();
            newItem.data = data;

            if (head == null)
            {                
                head = newItem;
                head.nextNode = null;                
            }
            else
            {
                Node<object> currentNode = head;

                while(currentNode.nextNode != null)
                {
                    currentNode = currentNode.nextNode;
                }
                currentNode.nextNode = newItem;
            }
        }

        public void AddFirst(object data)
        {
            Node<object> newItem = new Node<object>();
            newItem.data = data;
            newItem.nextNode = head;
            head = newItem;
        }

        public void ReadAll()
        {
            Node<object> current = head;

            while(current.nextNode != null)
            {
                Console.WriteLine(current.data);
                current = current.nextNode;                
            }
            Console.WriteLine(current.data);
        }
    }
}
