using System;
using System.Linq;

namespace W1Lab2_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of QuickPick numbers to generate:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n,6];
            int[] temp = new int[6];
            int k=0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < 6; j++)
                {

                    int x=getNumber(temp);
                    arr[i,j] = x;
                    
                }
                
                k=0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
       
       static int[] getNumber(){
           int[] arr = new int[6];
           for (int i = 0; i < arr.Length; i++)
           {
               int x = new Random().Next(1,49);
               if(arr.Contains(x))
                i--;
           }

           return arr;
       }


    }
}
