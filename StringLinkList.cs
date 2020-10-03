using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace LinkedListHomework
{
    class StringLinkList
    {
        private Node head;

        public Node AddToHead(string data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node newHead = new Node(data);
                newHead.next = head;
                head = newHead;
            }
            return head;
        }

        public Node AddToEnd(string data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
                return current.next;
            }

        }

        public Node Contains(string data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.data == data)
                {
                    return current;
                }

                current = current.next;
            }

            return null;
        }

        public void Remove(string data)
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            else if (current.data == data)
            {
                head = current.next;
                return;
            }

            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            return;
        }

        public Node GetFirst()
        {
            return head;
        }

        public Node Add(string data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }

            Node current = head;
            while (current != null)
            {
                Node next = current.next;

                if (next == null)
                {
                    return AddToEnd(data);
                }

                if (current.data.CompareTo(data) > 0)
                {
                    return AddToHead(data);
                }

                if (current.data.CompareTo(data) < 0 && next.data.CompareTo(data) >= 0)
                {
                    current.next = new Node(data);
                    current.next.next = next;
                    return current.next;
                }
                current = current.next;
            }
            return null;
        }

        public void PrintAllNodes()
        {
            Node current = head;
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

        }
    }
}
