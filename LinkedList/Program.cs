using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    public class Example
    {

        public static void Main()
        {
             
            /*
            In computer science, a linked list is a linear collection of data elements whose order is not given by their physical placement in memory.Instead, each element points to the next. It is a data structure consisting of a collection of nodes which together represent a sequence. In its most basic form, each node contains: data, and a reference(in other words, a link) to the next node in the sequence. This structure allows for efficient insertion or removal of elements from any position in the sequence during iteration.More complex variants add additional links, allowing more efficient insertion or removal of nodes at arbitrary positions.A drawback of linked lists is that access time is linear(and difficult to pipeline). Faster access, such as random access, is not feasible. Arrays have better cache locality compared to linked lists.
            */

            string[] words = { "first", "second", "third", "forth", "fifth" };

            //create linked list with existing array
            LinkedList<string> linkedWords = new LinkedList<string>(words);
            LinkedListNode<string> linkedListNode;

            int count = 0;

            linkedListNode = linkedWords.First;

            do
            {
                if (linkedListNode == null)
                {
                    break;
                }
                else
                {
                    linkedListNode = linkedListNode.Next;
                    count++;
                }
            } while (true);
            linkedListNode = linkedWords.First;


            //note that cannot indexing linkedlist like linkedWords[3]

            int middleOfCount = count / 2;

            do
            {
                linkedListNode = linkedListNode.Next;
                middleOfCount--;

            } while (middleOfCount > 0);


            Console.WriteLine($"Middle of element {linkedListNode.Value}\n");

            Console.WriteLine($"You can also find next element of next");
            Console.WriteLine($"First           : {linkedWords.First.Value}");
            Console.WriteLine($"First.Next      : {linkedWords.First.Next.Value}");
            Console.WriteLine($"First.Next.Next : {linkedWords.First.Next.Next.Value}");
            
            
            Console.WriteLine("You can also use builtin linq expressions to find count");

            int countUsingLinq=linkedWords.Count();


            // you can find and insert between values
            LinkedListNode<string> thirdTextNode=linkedWords.Find("third");
            linkedWords.AddAfter(thirdTextNode, "thirdPlus");


            Console.ReadLine();
        }
    }

}
