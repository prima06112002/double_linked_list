using double_linked_list;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class reperesent the  node of doubly linked list
         * it consist of the information part and and link to
         * its secceding amd preceeding
         * in terms of the next and previous */
        public int noMhs;
        public string name;
        //point to succeding node
        public Node next;
        //point to preceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor


        public void addnode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number of allowed");
                    return;

                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
            /*if the node is to be inserted at beetwen two node*/
            Node previous, current;
            for(current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim >= current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }
            }
            /*On the execution of the above for loop,prev and
             * current will point to those nodes
             * between which the new node is to be inserted*/
            newNode.next = current;
            newNode.prev = previous;

            //if the node id to be inserted at the end of the list
            if(current == null)
            {
                newNode.next = null;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
        }
        public bool Search(int rollNo,ref Node previous, ref Node current)
        {
            previous = current = START;
            while (current != null &&
                rollNo != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(rollNo,ref previous,ref current) == false)
                return false;
            //the begining of data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //Node between two node in the list
            if(current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            /*if to be deleted is in between the list then the following lines of is executed. */
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecord in the ascending order of" + "Roll number are:\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + currentNode.next.name + "\n");
            }
        }
        public void descending()
        {
            if (!listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecord in the descending order of" + "Roll number are:\n");
                Node currentNode;
                //membawa current node ke node paling belakang
                currentNode = START;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                //membawa data diri last node ke first node
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.noMhs + " " + currentNode.name + "\n");
                    currentNode = currentNode.prev;
                }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DoubleLinkedList obj = new DoubleLinkedList();
        while (true)
        {
            try
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Add a record to the list");
                Console.WriteLine("2. Delete a record from to the list");
                Console.WriteLine("3. View all record in the asceding order of roll number");
                Console.WriteLine("4. View all record in  the descending order of roll number");
                Console.WriteLine("5. Search for a record in the list");
                Console.WriteLine("6. Exit\n");
                Console.WriteLine("Enter your choice (1-6): ");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                { }
                
            }
         }
    }
}


