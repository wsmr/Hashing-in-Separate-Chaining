

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class Array
    {
        private ListNode head;//Reference to the first list item

        public Array()
        {
            head = null;
        }
        //Insert the ListNode to Array
        public void insert(ListNode theListNode)
        {
            int key = theListNode.value;
            ListNode previous = null;//Start insert at initially
            ListNode current = head;
            //Searching until end of the list
            while (current != null && key > current.value)
            {
                previous = current;
                current = current.next;//Access the next item
            }
            //At the begining of list
            if (previous == null)
                head = theListNode;
            else//Not at the begining
                previous.next = theListNode;
            theListNode.next = current;
        }
        //Delete a given ListNode
        public void delete(int key)
        {
            ListNode previous = null;//Start at initially
            ListNode current = head;

            while (current != null && key != current.value)
            {
                previous = current;
                current = current.next;//Access the next link
            }
            //At the begining of list delete the first ListNode
            if (previous == null)
                head = head.next;
            else//Delete the current ListNode
                previous.next = current.next;
        }
        //Find the relevent ListNode
        public ListNode search(int key)
        {
            ListNode current = head;//Start at the begining

            //Find the corrosponding ListNode and then return it
            while (current != null && current.value <= key)
            {
                if (current.value == key)
                    return current;
                current = current.next;//Access the next item
            }
            return null;//Didn't find return null
        }
        //Display the elements associate with each slot in the array
        public void displayArraySlots(){
        Console.Write("head(Dummy Node) ");
     
        ListNode current = head;//Start at the begining of the list
     
        while(current != null){
            Console.Write("=>");
            current.displayListNode();
            current = current.next;//Access the next ListNode
        }
        Console.WriteLine("");
    }
    }
}


