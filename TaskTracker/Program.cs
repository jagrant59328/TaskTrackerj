using TaskTracker.TaskDomain;
using TaskTracker;
using TaskDomain;

var shouldContinue = true;
  TaskItemService taskItemService = new();

do
{
    Console.WriteLine("Welcome to TaskTracker!");

    foreach (var item in Enum.GetValues<MainMenu>())
    {
        Console.WriteLine($"{(int)item}. {item}");
    }

    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);

    switch (input)
    {
        case (int)MainMenu.ListTasks:
            taskItemService.DisplayTaskItems();
            break;
        
        case (int)MainMenu.AddTask:
            // add logic to add a task
            Console.Write("Enter the task title: ");
            var userInput = Console.ReadLine();
            if(userInput != null)
            taskItemService.AddTask(userInput);
            break;

    

        case (int)MainMenu.DeleteTask:
           var success = int.TryParse(Console.ReadLine(), null, out int Idtodelete);
            if(success)
            taskItemService.DeleteTask(Idtodelete);
            break;

        case (int)MainMenu.UpdateTask:
            break;
       
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);

void AboutMeInformation()
{
    Console.WriteLine("My name is Jayden G");
    Console.WriteLine("My GitHub name is Jayden59328");
    Console.WriteLine();
}