class Program
{
    const string OPTIONS = $@"

        -- QUEUE OPERATIONS --
        /queue-enqueue
        /queue-dequeue

        -- STACK OPERATIONS --
        /stack-push <val>
        /stack-pop

        /help
        /exit

    ";
    static void Main()
    {
        Stack<int> intStack = new Stack<int>();
        Queue<ChatMessage> chatQueue = new Queue<ChatMessage>(10);

        Console.WriteLine(OPTIONS);
        while (true)
        {
            Console.Write("> ");
            string cmd = Console.ReadLine();

            string[] args = cmd.ToLower().Split(' ').ToArray<string>();

            switch(args[0])
            {
                case "/stack-push":
                    if (args.Count() == 1) {
                        Console.WriteLine("Requires an argument int");
                        break;
                    }
                    intStack.Push(int.Parse(args[1]));
                    Console.WriteLine($"Pushed value `{args[1]}` to stack");
                break;

                case "/stack-pop":
                    Console.WriteLine($"Poped value `{intStack.Pop()}` from stack");
                break;

                case "/queue-enqueue":
                    Console.Write("Enter message > ");
                    string message = Console.ReadLine();
                    chatQueue.Enqueue(new ChatMessage(message));
                    Console.WriteLine($"Enqueued value `{args[1]}` to chat queue");
                break;

                case "/queue-dequeue":
                    Console.WriteLine($"Dequeued value `{chatQueue.Dequeue().ToString()}` from chat queue");
                break;

                case "/help":
                    Console.WriteLine(OPTIONS);
                break;

                case "/exit":
                    return;
                default:
                    Console.WriteLine("Invalid operation, /help to see options");
                break;
            }
        }
    }
}