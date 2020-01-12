

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
   class ListNode
    {
       public int value;//Data of the ListNode
       public ListNode next;//Reference to the next ListNode
       //Fill Data to each ListNode
       public ListNode(int num)
        {
            value = num;
        }
       //Display the content of the ListNode
       public void displayListNode(){
            Console.Write(value+" ");
       }
    }
}

