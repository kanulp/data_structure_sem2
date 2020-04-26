using System;
using System.Collections.Generic;
using System.Collections;


namespace W8LAB_GAJJAR
{
    internal class Farm<T> : ICollection<T>
        where T : Animal
    {
        static Dictionary<Type, Farm<T>> farmDict = new Dictionary<Type, Farm<T>>();

        private Farm() { }
        public static Farm<T> GetFarm()
        {
            Type t = typeof(T);
            if (!farmDict.ContainsKey(t))
            {
                farmDict[t] = new Farm<T>();
            }
            return farmDict[t];
        }
        private List<T> animals = new List<T>();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            animals.Add(item);
            // throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void MakeNoises()
        {
            foreach (T i in animals)
            {
                i.MakeANoise();
            }
        }

        public void FeedTheAnimals()
        {
            foreach (T i in animals)
            {
                i.Feed();
            }
        }

        public Farm<Cow> GetCows()
        {
            Farm<Cow> cowFarm = new Farm<Cow>();
            foreach (T animal in animals)
            {
                if (animal is Cow)
                {
                    cowFarm.animals.Add(animal as Cow);
                }
            }
            return cowFarm;
        }
    }

}

