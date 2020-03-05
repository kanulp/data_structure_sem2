using System;
using System.Collections;  
using System.Collections.Generic;  


namespace W2Lab_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[]{5, -6, 7, 3, 4};
            PrintInts("Nums",arr);
            //int[] arr2 = ReadInts("Enter Values : ",3);
            //PrintInts("Nums:",arr2);
            Console.WriteLine("Minimum is :"+Minimum(arr));
            Console.WriteLine("Even Count is :"+CountEven(arr));

            var farmAnimals = new Animal[2];

            farmAnimals[0] = new Cow("Martha");
            farmAnimals[1] = new Chicken("Ken");
            System.Console.WriteLine("\nTime for feeding : ");
            foreach (var item in farmAnimals)
            {
                item.Feed();
            }
            System.Console.WriteLine("\nTime to feed me");
            foreach (var item in farmAnimals)
            {
                if(item is Cow){
                    ((Cow)item).Milk();
                }
                if(item is Chicken){
                    ((Chicken)item).LayEgg();
                }
            }

            Array.Resize<Animal>(ref farmAnimals, 4);

            farmAnimals[2] = new Cow("Benny");
            farmAnimals[3] = new Chicken("Chickaletta");

            System.Console.WriteLine("\nAnimals in my farm : ");
            foreach (var item in farmAnimals)
            {
                System.Console.WriteLine(item.name);
            }

            ArrayList myFarm = new ArrayList();
            myFarm.AddRange(farmAnimals);
            
            System.Console.WriteLine("\nNow I have a dynamic farm that can grow automatically");
            
            printCountAndCapacity(myFarm);
            
            myFarm.Add(new Cow("Betina"));
            myFarm.Add(new Chicken("Heihei"));

            printCountAndCapacity(myFarm);

            foreach (var item in myFarm)
            {
                System.Console.WriteLine((((Animal)item)).name);
            }
            addCowAndChicken(myFarm);
            removeCowAndChicken(myFarm);
            myFarm.Capacity = 10;
            printCountAndCapacity(myFarm);
            reduceMyfarmCapacity(myFarm);
            feedAnimalFarm(myFarm);


            System.Console.WriteLine("creating and generating dynamic farm...");
            System.Console.WriteLine("Feeding animals in the generic farm is much easier, I do not have to unbox animals");
            List<Animal> myGenericFarm = new List<Animal>();
            initializeMyFarmGeneric(myGenericFarm,farmAnimals);
            feedMyFarmGeneric(myGenericFarm);

            addCowAndChicken(myGenericFarm);

            removeCowAndChicken(myGenericFarm);

            System.Console.WriteLine("Trimming excess Capacity...");
            myGenericFarm.TrimExcess();
            printCountAndCapacity(myGenericFarm);
            
        }

        static void PrintInts(string label, int[] a)
        {
            Console.WriteLine(label+" : "+string.Join(" ", a));
        }
        static int[] ReadInts(string prompt, int n)
        {
            Console.WriteLine(prompt);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static int Minimum(int[] a)
        {
            int min=a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i]<min)
                    min=a[i];
            }
            return min; 
        }
        static int CountEven(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                    count++;
            }
            return count;
        }

        static void printCountAndCapacity(ArrayList array){
            Console.WriteLine("My Farm's capacity is : "+array.Capacity);
            Console.WriteLine("My Farm's count is : "+array.Count+"\n");
        }
         static void printCountAndCapacity(List<Animal> array){
            Console.WriteLine("My Farm's capacity is : "+array.Capacity);
            Console.WriteLine("My Farm's count is : "+array.Count+"\n");
        }

        static void addCowAndChicken(ArrayList array){
            for (int i = 0; i < 10; i++)
            {
                array.Add(new Cow(i+""));
                array.Add(new Chicken(i+""));
                System.Console.WriteLine("Added a cow and a chicken : ");
                printCountAndCapacity(array);
            }
        }
        static void removeCowAndChicken(ArrayList array){
            for (int i = 0; i < 10; i++)
            {
                array.RemoveAt(array.Count-1);
                array.RemoveAt(array.Count-1);   
                System.Console.WriteLine("Removed last two animals: ");
                printCountAndCapacity(array);
            }
        }
        static void reduceMyfarmCapacity(ArrayList myFarm){
            try
            {
                myFarm.Capacity = 5;

            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.ToString());
                System.Console.WriteLine("Setting the capacity to animal count:");
                myFarm.TrimToSize();
                printCountAndCapacity(myFarm);

            }
        }
        static void feedAnimalFarm(ArrayList array){
            foreach (var item in array)
            {
                (((Animal)item)).Feed();
            }
        }
        static void initializeMyFarmGeneric(List<Animal> myGenericFarm,Animal[] farmAnimals){
            /*foreach (var item in myFarm)
            {
                myGenericFarm.Add((Animal)item);
            }*/
            foreach (var item in farmAnimals)
            {
                myGenericFarm.Add(item);
            }
        }

        static void feedMyFarmGeneric(List<Animal> list){
            foreach (var item in list)
            {
                item.Feed();
            }
        }
        static void addCowAndChicken(List<Animal> array){
            for (int i = 0; i < 10; i++)
            {
                array.Add(new Cow(i+""));
                array.Add(new Chicken(i+""));
                System.Console.WriteLine("Added a cow and a chicken : ");
                printCountAndCapacity(array);
            }
        }
        static void removeCowAndChicken(List<Animal> array){
            for (int i = 0; i < 10; i++)
            {
                array.RemoveAt(array.Count-1);
                array.RemoveAt(array.Count-1);   
                System.Console.WriteLine("Removed last two animals: ");
                printCountAndCapacity(array);
            }
        }
    }
}
