using System;

namespace Case_study_1
{    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackInts = new Stack<int>();
            stackInts.push(10);
            stackInts.push(20);
            stackInts.push(30);
            stackInts.push(40);
            stackInts.push(50);


            Console.WriteLine("Pushed integers. Count is : " + stackInts.Count);

            foreach (var item in stackInts)
            {
                Console.WriteLine(item);
            }

            stackInts.pop();
            Console.WriteLine("Poped. Count is : "+ stackInts.Count); 
            foreach (var item in stackInts)
            {
                Console.WriteLine(item);
            }

            var stackPeek = stackInts.peek();
            System.Console.WriteLine("Peek in Stack : "+stackPeek.nodeData);

            Queue<int> queueInts = new Queue<int>();

            queueInts.Enqueue(60);
            queueInts.Enqueue(70);
            queueInts.Enqueue(80);
            queueInts.Enqueue(90);

            Console.WriteLine("Enqueued integers. Count is : " + queueInts.Count);

            foreach (var item in queueInts)
            {
                Console.WriteLine(item);
            }

            queueInts.Dequeue();
            Console.WriteLine("Dequeued integer. Count is : " + queueInts.Count);

            foreach (var item in queueInts)
            {
                Console.WriteLine(item);
            }

            var peekQueue = queueInts.Peek();
            System.Console.WriteLine("Peek in Queue is : "+peekQueue.nodeData);

        }
    }

}
