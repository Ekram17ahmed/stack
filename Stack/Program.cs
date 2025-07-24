namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the stack: ");
            int size = int.Parse(Console.ReadLine());
            StackClass myStack = new StackClass(size);

            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Peek");
                Console.WriteLine("4 - IsEmpty");
                Console.WriteLine("5 - IsFull");
                Console.WriteLine("6 - Exit");
                Console.Write("Your choice: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a number to push: ");
                        int item = int.Parse(Console.ReadLine());
                        myStack.Push(item);
                        break;

                    case "2":
                        int popped = myStack.Pop();
                        if (popped != -1)
                            Console.WriteLine(" Popped: " + popped);
                        break;

                    case "3":
                        int top = myStack.Peek();
                        if (top != -1)
                            Console.WriteLine("Top element is: " + top);
                        break;

                    case "4":
                        Console.WriteLine("Stack is " + (myStack.IsEmpty() ? "empty." : "not empty."));
                        break;

                    case "5":
                        Console.WriteLine("Stack is " + (myStack.IsFull() ? "full." : "not full."));
                        break;

                    case "6":
                        Console.WriteLine(" Exiting the program.");
                        return;

                    default:
                        Console.WriteLine(" Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
