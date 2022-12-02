using System;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stack
    {
        Node top;
        public Stacks()
        {
            Node top;
            public Stacks()
            {
                top = null;
            }
            bool empty()
            {
                if (top == null)
                    return (true);
                else
                    return (false);
            }
        }
    }
}