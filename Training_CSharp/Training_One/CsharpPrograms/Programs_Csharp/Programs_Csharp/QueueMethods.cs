using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
    class QueueMethods
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            foreach (Object obj in queue)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Number of Elements ? : " + queue.Count);
            Console.WriteLine("Queue contains " + queue.Contains(3));
            Console.ReadKey();

            queue.Dequeue();
            foreach (Object obj in queue)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
