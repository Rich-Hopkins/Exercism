using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedListKata
{
    public class SimpleLinkedList<T>
    {
        private List<Node> list = new List<Node>();

        public SimpleLinkedList(object o)
        {
            Add(o);
        }

        public int Value
        {
            get { return (int) list[0].Value; }
        }

        public Node Next()
        {
            return list[list.Count - 1].Next;
        }

        public SimpleLinkedList<T> Add(object o)
        {
            Node newNode;
            if (list.Count == 0)
            {
                newNode = new Node(null, o);
            }
            else
            {
                newNode = new Node(list[list.Count-1], o);
                list[list.Count - 1].Next = newNode;
            }
            list.Add(newNode);
            return this;
        }
    }

    public class Node
    {
        public Node(Node prev, object value)
        {
            Previous = prev;
            Value = value;
        }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public object Value { get; set; }
    }
}
