using System.Security.Cryptography.X509Certificates;
using TaskTracker.TaskDomain;

namespace TaskDomain;
//middle man connecting to database 
public class TaskItemService
{
    //instance variable
    List<TaskItem> Taskitems = new();
    public void PopulateInitialTasksItems()
    {

        TaskItem Taskone = new("Take out the trash");

        TaskItem Tasktwo = new("Upgrade Phone");
        TaskItem Taskthree = new("Clean the roof");


        Taskitems.Add(Taskone);
        Taskitems.Add(Tasktwo);
        Taskitems.Add(Taskthree);

        foreach (var item in Taskitems)
        {
            Console.WriteLine($"{item.Id}: {item.Title}");
        }
    }

public void AddTask(string title)
        {
        Taskitems.Add(new TaskItem(title)); 

        }
    //move this to the Ui layer 
    public void DisplayTaskItems()
    {
        foreach (var item in Taskitems)
        {
            Console.WriteLine($"{item.Id}: {item.Title}");
        }

    }


}
