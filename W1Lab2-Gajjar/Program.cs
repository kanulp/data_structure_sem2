using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace W1Lab2_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of QuickPick numbers to generate:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int[]> newarr = new List<int[]>();
            bool isBonus=false;
            int[] temp = new int[6];
            
            /* //int[,] q = new int[,]{{4,16,18,25,40,47},{6,7,13,15,21,40},{6,17,24,26,28,33},{11,19,29,36,34,47}};
            int[] a1 = new int[]{4,16,18,25,40,47};
            int[] a2 = new int[]{6,7,13,15,21,40};
            int[] a3 = new int[]{6,17,25,27,29,12};
            int[] a4 = new int[]{11,19,29,36,34,47}; 

            newarr.Add(a1);
            newarr.Add(a2);
            newarr.Add(a3);
            newarr.Add(a4);
            */
            
            
            for (int i = 0; i < n; i++)
            {
                newarr.Add(getUniqueNumber());
            }  


            System.Console.WriteLine("Quickpick number is :");
            foreach (var item in newarr)
            {
                foreach (var item2 in item)
                {
                    System.Console.Write(item2+" ");
                }
                System.Console.WriteLine();
            }
            
            

            System.Console.WriteLine("Winning number is : ");
            int[] winningarr = getUniqueNumber();
            //int[] winningarr = new int[]{6,17,24,26,28,33};

            //bonus
            //int bonus = 12;
            int bonus = generateWinningBonus(winningarr);

            for (int i = 0; i < winningarr.Length; i++)
            {
                System.Console.Write(winningarr[i]+" ");
            } 
            System.Console.WriteLine("Bonus : "+bonus);
            //check array comparison based on max element matched.
            checkMatchingItems(newarr,winningarr,temp,bonus,ref isBonus);
                        
            /* System.Console.WriteLine("TEMP is : ");
            foreach (var item in temp)
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine();
             */
            int max=0;
            max=temp[0];
            //int foundRow=0;
            for (int i = 0; i < temp.Length; i++)
            {
               if(temp[i]>max){
                   max=temp[i];
                   //foundRow=i;
               }
            }
           //System.Console.WriteLine("Matched Row is : "+foundRow);
           //System.Console.WriteLine("Max is : "+max);

        
           calculatePrice(max,ref isBonus);

           
        }


        static void calculatePrice(int max,ref bool isBonus){
            double price = 0;
            double total = 30.0;
            string priceStr="";
            switch (max)
            {
                case 6:
                price=total*0.805;
                priceStr=" Million";
                break;

                case 5:
                if(isBonus)
                    price=total*0.575;
                else
                    price=total*0.475;
                    priceStr=" Million";
                break;

                case 4:
                price = total*0.09;
                    priceStr=" Million";

                break;

                case 3:
                price = 10;
                break;

                case 2:
                if(isBonus)
                    price = 5;
                else
                    price = 0.0;
                break;

                default:
                price = 0.0;
                break;
            }
            if(price>0.0)
                System.Console.WriteLine("Congratulations! You won the jack pot! Your prize is $ "+price+" "+priceStr);
            else
                System.Console.WriteLine("Sorry, You did not win. Try Again...");
        }

        
       static void checkMatchingItems(List<int[]> newarr, int[] winningarr,int[] temp,int bonus,ref bool isBonus){
            int t_index=0;
            foreach (var ele in newarr)
            {
                int i=1;
                foreach (var item in ele)
           {
        
               foreach (var item2 in winningarr)
               {
                   if(item==item2){
                       temp[t_index]=i;
                       i++;
                   }  
               }
               if(bonus==item){
                   isBonus=true;
               }
           }
                t_index++;
            }

           
           
       }
       static int[] getUniqueNumber(){
           int[] arr = new int[6];
           for (int i = 0; i < arr.Length; i++)
           {
               int x = new Random().Next(1,49);
               if(arr.Contains(x))
                i--;
                else
                arr[i]=x;
           }
            Array.Sort(arr);
           return arr;
       }

       static int generateWinningBonus(int[] arr){
           int x = 0;
           while (true)
           {
            x = new Random().Next(1,49);
            if(!arr.Contains(x)){
                break;
            }
            }
            return x;
       }

    }
}
