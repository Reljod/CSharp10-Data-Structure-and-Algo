using LinkedList;

namespace MainProg
{
    public static class Examples
    {
        public static void ExecuteSimpleLinkedListExamples()
        {
            /*
            Supposed we are given a series of instructions that 
            we need to follow in order. Linked list is one of the data structures
            that are perfect for those types of data.
            */  

            // data
            string instruction1 = "Go to Rizal Park then pick up a bottle near the statue.";
            string instruction2 = "Go to Intramuros Gate and find the key that matches the bottle.";
            string instruction3 = "Use the key to unlock one of the locks in MOA Sea side area.";

            // Create simple Linked List
            ILinkedList<string> sll = new SimpleLinkedList<string>();

            // Add the instruction to the front of the Linked List.
            sll.AddFront(instruction1);
            sll.AddFront(instruction2);
            sll.AddFront(instruction3);

            // fetch data
            Console.WriteLine(sll.Head.Data);  // prints instruction1
            Console.WriteLine(sll.Head.Next.Data);  // prints instruction2
            Console.WriteLine(sll.Head.Next.Next.Data);  // prints instruction3

            /*
            Supposed the instructor forgot to include the first instruction and wants
            to add it on the first most part.
            */

            string instruction0 = "The goal is to be faster than the other teams.";
            sll.AddBack(instruction0);

            Console.WriteLine(sll.Head.Data);  // now prints instruction0
            Console.WriteLine(sll.Head.Next.Data);  // now prints instruction1
        }
    }
}