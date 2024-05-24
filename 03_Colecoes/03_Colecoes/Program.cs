using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace _03_Queue
{
    internal class Program
    {
        private static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue(1); // add
            queue.Enqueue("10");
            queue.Enqueue(true);
            queue.Enqueue(false);

            queue.Dequeue(); // remove o mais antigo

            queue.Peek(); // mostra o elemento mais antigo, 1

            for (int i = 0; i < queue.Count; i++)  // apenas pecorrer uma lista, pode mostrar um elemento especifíco
            {
                Console.WriteLine(i);
            }

            queue.Clear(); //remove todos os itens

            //_________ Queue<t> _________

            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());  //Dequeuing 'one'
            Console.WriteLine("Peek at next item to dequeue: {0}",
                numbers.Peek());  // Peek at next item to dequeue: two
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue()); //Dequeuing 'two'
            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }
            /*Contents of the first copy:
                three
                four
                five*/

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Create a second queue, using the constructor that accepts an
            // IEnumerable(Of T).
            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
                /*Contents of the second copy, with duplicates and nulls:

                    three
                    four
                    five*/
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));          //queueCopy.Contains("four") = True

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count); //   queueCopy.Count = 0

            //_________ ImmutableQueue<t> _________
            var iQ = ImmutableQueue<int>.Empty;

            var qWithOneElement = iQ.Enqueue(1); // ele retorna para fila
            var qWithTwoElement = qWithOneElement.Enqueue(2); // ele retorna para fila

            iQ.Enqueue(2); //não faz nada, fila continua igual

            var values = new[] { 1, 2, 3 };
            var iq2 = ImmutableQueue.CreateRange(values); // fila com a coleção de valores

            Console.WriteLine("Fila copia da imutavel");
            foreach (var value in qWithTwoElement)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Fila imutavel");
            foreach (var value in iQ)
            {
                Console.WriteLine(value); //vai estar vazia
            }

            Console.ReadKey();
        }
    }
}