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

                }

            }
        }
    }
}
