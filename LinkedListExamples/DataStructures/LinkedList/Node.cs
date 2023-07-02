using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public T data=default(T);
        public Node<T> nextNode =null;

    }
}
