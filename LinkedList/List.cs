using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List
    {
        private Node head;
        private Node tail;
        private int size;

        public void PushFront(int data)
        {
            if(head == null)
            {

                Node temp = new Node(data, null, null);
                head = temp;
                tail = head;
                ++size;
            }
            else
            {
                Node temp = new Node(data, null, head);
                temp.Next = head;
                head = temp;
                temp.Next.Previous = head;
                ++size;
            }
        }

        public void PushBack(int data)
        {
            if (head == null)
            {
                Node temp = new Node(data, null, null);
                head = temp;
                tail = head;
                ++size;
            }
            else
            {
                Node temp = new Node(data, tail, null);
                tail.Next = temp;
                temp.Previous = tail;
                tail = temp;
                ++size;
            }
        }

        public void PopFront()
        {
            if (head == null)
                Console.WriteLine("List is empty");
            else
            {
                Node temp = head;
                if(head.Next != null)
                {
                    head.Next.Previous = null;
                }
                head = head.Next;
                --size;
            }
        }

        public void PopBack()
        {
            if (tail == null)
                Console.WriteLine("List is empty");
            else
            {
                Node temp = tail;
                if(tail.Previous != null)
                {
                    tail.Previous.Next = null;
                }
                tail = tail.Previous;
                --size;
            }
        }





        public int GetSize()
        {
            return size;
        }
        public void Show()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Next;
            }
        }


    }
}
