
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hashing
{
    class SeperateChaining
    {
        static void Main(string[] args)
        {
  
        int aKey;
        ListNode item;
        int size=1000;
        int[] targetSums={231552, 234756, 596873, 648219, 726312, 981237, 988331, 1277361, 1283379};
        int strlen = targetSums.Length;
        char[] str=new char[strlen];
        HashTable theHashTable=new HashTable(size);//Create the HashTable
     
        Console.WriteLine("\n---------------------------System Controllers-----------------------------------");
        Console.WriteLine("\n\t\t1. Insert Data to List : i");
        Console.WriteLine("\n\t\t2. Delete Data from the List : d");
        Console.WriteLine("\n\t\t3. Find specific value in the List : f");
        Console.WriteLine("\n\t\t4. Show the List : s");
        Console.WriteLine("\n\t\t5. Show the String bit pattern of target sums : t");
        Console.WriteLine("\n\t\t6. Exit from the System : e");
        Console.WriteLine("\n--------------------------------------------------------------------------------\n");
     
        //Read the File
        Readfile r=new Readfile();
        r.openFile();
        int[] dataSet = r.readFile();
        r.closeFile();//End of the file reading
     
        SeperateChaining sep_chain=new SeperateChaining();
     
        while(true){
            sep_chain.printMessage("\nEnter the control key : ");
            char choice=sep_chain.getChar();//Get the one character at a time to control the system

            switch(choice){
                case 's':
                    theHashTable.displayHashTable();//Display the whole HashTable
                    break;
                case 'i':
                    for(int k=0;k<dataSet.Length;k++){
                        aKey=dataSet[k];
                        item=new ListNode(aKey);//Create a new ListNode to each element
                        theHashTable.insert(item);//Insert ListNode to the HashTable
                    }
                    break;
                case 'd':
                    sep_chain.printMessage("\nEnter value to delete : ");
                    aKey=sep_chain.getInt();//Get the value to delete
                    item=theHashTable.search(aKey);//Find that element in the HashTable
                    if(item != null)
                        theHashTable.delete(aKey);//Element get hit then perform the delete operation
                    else
                        Console.WriteLine("Could not search "+aKey);
                    break;
                case 'f':
                    sep_chain.printMessage("\nEnter value to search : ");
                    aKey=sep_chain.getInt();
                    item=theHashTable.search(aKey);//Search the given element in the HashTable
                    if(item != null)
                        Console.WriteLine("Found "+aKey);
                    else
                        Console.WriteLine("Could not search "+aKey);
                    break;
                case 't':
                    int txtValue=0;
                    for(int k=0;k<targetSums.Length;k++){
                        for(int j=0;j<dataSet.Length;j++){
                            txtValue=(targetSums[k]-dataSet[j]);
                            if(txtValue < 0)
                                continue;
                            if(theHashTable.search(txtValue) != null){
                                str[k]='1';
                                break;
                            }
                            else
                                str[k]='0';
                        }
                    }
                    for(int k=0;k<targetSums.Length;k++){
                        Console.Write(str[k]+" ");
                    }
                    Console.WriteLine("\n");
                    break;
                case 'n':
                    Console.WriteLine("\nWARNING : Don't send NULL character again............\n");
                    break;
                case 'm':
                    Console.WriteLine("\nWARNING : Don't send more than one character.............\n");
                    break;
                case 'e':
                    Console.WriteLine("\nExit from the System sucessfully...................\n");
                    Environment.Exit(0);
                    break;
                default:
                    sep_chain.printMessage("\nYour input is invalid\n");
                    break;
                }
        }
      
    }
    //Print the message
    public void printMessage(string s){
        Console.Write(s);
    }
    //Read the console input as string
    public static string getString(){
        string s=Console.ReadLine();
        return s;
    }
    //Read the one character from the console input
    public char getChar(){
        string s=getString();
        if (s.Length == 0)
            return 'n';
        else if(s.Length > 1)
            return 'm';
        else
            return s[0];
    }
    //Cast the given searching or deleting element to int
    public int getInt(){
        string s=getString();
        int numValue;
        bool parsed = Int32.TryParse(s, out numValue);
        if (!parsed)
        {
            Console.WriteLine("\nWARNING : Could not parse '{0}' to an int.............",s);
            Console.Write("Return value become zero : ");
            return 0;
        }
        else
            return Int32.Parse(s);
    }
    }
}



