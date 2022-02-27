using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    class LinkedList
    {
        // variables
        internal Node head;
        /// <summary>
        /// add elements into linkedlist.
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        /// <summary>
        /// display the elements of linkedlist.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.Write("null");
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position != 0) //
                {

                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        
        public int PopFirstNode()
        {
            if (this.head == null)
                return 0;
            int pop = this.head.data;
            this.head = this.head.next;
            return pop;
        }
        public Node PopLastNode()
        {
            if (this.head == null)
                return null;
            if (head.next == null)
                return null;
            else
            {
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                return newNode;

        }
    }
}

