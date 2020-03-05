using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace W6Lab_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            
        String [] sampleStrings = {"that", "that", "is", "is", "that", "that", "is", "not", "is", "not", "is", "that", "it", "it", "is"};
        
        hashTableDemo();
        hashSetDemo(sampleStrings);
        dictionaryDemo(sampleStrings);

        CodeBookCipher codeBookCipher = new CodeBookCipher();
        Console.WriteLine(codeBookCipher.encrypt("this is a test message"));
        Console.WriteLine(codeBookCipher.decrypt("155 408 141 821 286 692 821 559 286 692 692 141 117 286"));
        //A-4
        /*Difference between Hashtable and Dictionary. Hashtable and Dictionary are collection of data structures to hold data as key-value pairs. Dictionary is generic type, hash table is not a generic type. The Hashtable is a weakly typed data structure, so you can add keys and values of any Object Type to the Hashtable.
        
        Java HashSet class is used to create a collection that uses a hash table for storage. It inherits the AbstractSet class and implements Set interface.

The important points about Java HashSet class are:

HashSet stores the elements by using a mechanism called hashing.
HashSet contains unique elements only.
HashSet allows null value.
HashSet class is non synchronized.
HashSet doesn't maintain the insertion order. Here, elements are inserted on the basis of their hashcode.
HashSet is the best approach for search operations.
The initial default capacity of HashSet is 16, and the load factor is 0.75.
        */
        }

        static void hashTableDemo(){
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Josh", "Joshua Whitetail");
            hashtable.Add("Sam", "Samantha Bernie");
            hashtable.Add("Eli", "Elizabeth Spiegel");
            hashtable.Add("Will", "William Johnson");
            hashtable.Add("Don", "Donald Regan");


            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item + " " + hashtable[item]);

            }
        }

        static void hashSetDemo(String[] sampleStrings){
            HashSet<String> hash = new HashSet<String>();
            foreach (var str in sampleStrings)
                hash.Add(str); 
            System.Console.WriteLine("Number of unique String : "+hash.Count);
            foreach (var item in hash)
            {
                System.Console.Write(item+",");
            }
            System.Console.WriteLine();
        }
        static void dictionaryDemo(String[] sampleStrings){
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (string word in sampleStrings)
        {
        if (dictionary.ContainsKey(word))
            {
            dictionary[word] += 1; 
            }
            else
            {
            dictionary.Add(word,1);
            }
        }
        foreach (KeyValuePair<String, int> item in dictionary)
        {
            Console.WriteLine("{0} and {1}", 
                        item.Key, item.Value); 
        }
        }

    }

}
