using System;

using System.Collections;  
using System.Collections.Generic;

namespace W3Lab1_Gajjar
{
    class Farm<T> : ICollection<T>
    where T : Animal
    {   
        List<T> animals = new List<T>();
        public string name {get;set;}

        public int Count => GetCount();

        public bool IsReadOnly {
            get{
                return false;
            }
        }
        public Farm(string fname){
            name=fname;
        }

        public Farm()
        {
        }

        public void Add(T item){
            animals.Add(item);
        }

        public void Clear(){
            animals.Clear();
        }

        public bool Contains(T item){
            return animals.Contains(item);
        }

        public void MakeNoises(){
            foreach (var item in animals)
            {
                item.MakeANoise();
            }
        }

        public void FeedTheAnimals(){
            foreach (var item in animals)
            {
               item.Feed();
            }
        }

        public Farm<W3Lab1_Gajjar.Cow> GetCows(){
            Farm<Cow> dairyFarm = new Farm<Cow>(); 
            foreach (var item in animals)
            {
                if (item is Cow)
                {
                    dairyFarm.Add(item as Cow);
                }
            }
            return dairyFarm;
        } 
        
        public int GetCount(){
            return animals.Count;
        }

        public IEnumerable<T> GetEnumerable(){
            return animals;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)animals).CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)animals).Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)animals).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)animals).GetEnumerator();
        }


    }
}
