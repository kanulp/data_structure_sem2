using System;
using System.Collections;
using System.Collections.Generic;

namespace midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[7]{1,2,3,4,5,6,7};
            int[] a = new int[7];

            Random r = new Random();

            for(int i=0;i<7;i++){

                 a[i]=r.Next(1,49);
                
            }


            foreach (var item in a)
            {
                System.Console.Write(item+"\t");
            }
            System.Console.WriteLine();

            ArrayList arrayList = new ArrayList(a);

            foreach (var item in arrayList)
            {
                System.Console.Write(item+"\t");
            }
            System.Console.WriteLine();
            //System.Console.WriteLine(BinarySearchDisplay(a,3));
            //dictionaryDemo();

            personDemo();

        }
        /*public static Object BinarySearchDisplay(int[] arr, int key) {
        int minNum = 0;
        int maxNum = arr.Length - 1;

        while (minNum <=maxNum) {
        int mid = (minNum + maxNum) / 2;
        if (key == arr[mid]) {
        return ++mid+" is Found !";
        } else if (key < arr[mid]) {
        maxNum = mid - 1;
        }else {
         minNum = mid + 1;
        }
         }    
        return "Element not found";
        }*/
        static void dictionaryDemo(){

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("ON", "Ontario");
        dictionary.Add("BC", "British Columbia");
        dictionary.Add("QC", "Quebec");
        dictionary.Add("PE", "Prince Edward Island");
        dictionary.Add("NS", "Nova Scotia");
        
        List<String> list = new List<string>();

        //print dictionary keys and values 
        System.Console.WriteLine("Keys and Values in dictionary :");
        foreach (var item in dictionary)
        {
            list.Add(item.Value);
            System.Console.WriteLine(item.Key+" : "+item.Value);
        }

        //printing values in list
        System.Console.WriteLine("Values in list:");
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
        
    }

    static void personDemo(){
            List<Person> personList = new List<Person>();
            
            

            Person p1 = new Person("Karan","Gajjar","k@k.com");
            Person p2 = new Person("Karan2","Gajjar2","k2@k.com");
            Person p3 = new Person("Karan3","Gajjar3","k3@k.com");
            Person p4 = new Person("Karan4","Gajjar4","k4@k.com");
            Person p5 = new Person("Karan5","Gajjar5","k5@k.com");

            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);
            personList.Add(p5);



        foreach (var item in personList)
        {

            System.Console.WriteLine(item.getLastName());
            //personList.Sort(item);

        }   

    }
    public int compare(Object o1, Object o2) {
                Person p1 = (Person) o1;
                Person p2 = (Person) o2;
                int res =  p1.getLastName().CompareTo(p2.getLastName());
                if (res != 0)
                    return res;
                return p1.getLastName().CompareTo(p2.getLastName());
    }
}
}
