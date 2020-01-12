

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashing
{
    class HashTable
    {
    private Array[] hashArray;//Array of list
    private int arrayLength;
    //Constructor for the array
    public HashTable(int size){
        arrayLength = size;
        hashArray = new Array[arrayLength];//Create the array
        for(int j=0;j<arrayLength;j++)
            hashArray[j] = new Array();//Fill array with dummy nodes
    }
    //Display the whole elements in the Hash Table
    public void displayHashTable(){
        for(int j=0;j<arrayLength;j++){
            Console.Write("("+j+") ");
            hashArray[j].displayArraySlots();
        }
    }
    //Hash key generating function
    public int hashFunction(int key){
        return key%arrayLength;
    }
    //Insert the ListNode
    public void insert(ListNode theListNode){
        int key=theListNode.value;
        int hashVal=hashFunction(key);//Generate the hash key to value
        hashArray[hashVal].insert(theListNode);//Insert the node in to corrosponding slot in the array
    }
    //Delete the ListNode
    public void delete(int key){
        int hashVal=hashFunction(key);
        hashArray[hashVal].delete(key);
    }
    //Find the ListNode
    public ListNode search(int key){
        int hashVal=hashFunction(key);
        ListNode theListNode=hashArray[hashVal].search(key);
        return theListNode;//Return the ListNode
    }
 
    }
}


