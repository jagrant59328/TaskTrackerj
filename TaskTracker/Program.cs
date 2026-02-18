
using TaskTracker.TaskDomain;

var shouldContinue = true;
do
{
    Console.WriteLine("Welcome to TaskTracker!");
    Console.WriteLine("1. List Tasks");
    Console.WriteLine("2. About");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    int.TryParse(Console.ReadLine(), null, out int input);

      switch (input)
    {
        case 1:
            // list the tasks
            TaskItem Taskone = new();
            
            Taskone.Title = "Take out the trash";

            TaskItem Tasktwo = new();
         
            
            Tasktwo.Title = "Upgrade Phone";
            TaskItem Taskthree = new();
            
            Taskthree.Title = "Clean the roof";
           

            List<TaskItem> Taskitems = [];
            Taskitems.Add(Taskone);
            Taskitems.Add(Tasktwo);
            Taskitems.Add(Taskthree);
            
            foreach (var item in Taskitems)
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
            Console.WriteLine(Taskitems);
             break;
        
        case 2:
         
            break;
        case 3:
            shouldContinue = false;
            break;
        default:
            shouldContinue = false;
            break;
    }
    // make it so that the pro
} while (shouldContinue);

 void Aboutmeinformation()
{
      Console.WriteLine("Melissa Hegney");
            Console.WriteLine("Merlissa09");
            Console.WriteLine(DateTime.IsLeapYear(1998));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

}

