var shouldContinue = true;
do {
    Console.WriteLine("Welcome to TaskTracker!");
    Console.WriteLine("1. List Tasks");
    Console.WriteLine("2. About");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
 
    int.TryParse(Console.ReadLine(), null, out int input);
 
    if (input == 2)
    {
        Console.WriteLine("Jayden Grant");
        Console.WriteLine("Jagrant59328");
        Console.WriteLine(DateTime.IsLeapYear(2007));
        Console.WriteLine(DateTime.Now);
    }
 
    if(input == 3)
    {
        shouldContinue = false;
    }
 
    // make it so that the program does't close after an action is done
} while (shouldContinue);
