

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hashing
{
    class Readfile
    {
    StreamReader buff=null;
    List<string> v=new List<string>();
 
    public void openFile(){
        try{
            buff=new StreamReader("HashInt.txt");//Open the file to read
        }catch(Exception ex){
            Console.WriteLine("File can't open : "+ex);
        }
    }
    //Read content of the file
    public int[] readFile(){
        try
        {
            string s = buff.ReadLine();
            while (s != null)
            {
                v.Add(s);//Add each element to the list
                s = buff.ReadLine();//Read next line
            }
        }catch(NullReferenceException ex){
            Console.WriteLine(ex);
        }
        //Cast each element of the list and put it in to the int array
        int[] dataSet=new int[v.Count];
        for(int j=0;j<v.Count;j++){
            dataSet[j]=Int32.Parse(v[j]);
        }
        return dataSet;//Return the int array
    }
    //Close File after the reading completed
    public void closeFile(){
        try
        {
            buff.Close();//Close the file
        }catch(NullReferenceException ex){
            Console.WriteLine(ex);
        }
    }
    }
}


