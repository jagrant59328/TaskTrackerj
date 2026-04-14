using System.Security.Cryptography.X509Certificates;
using TaskTracker.TaskDomain;

namespace TaskDomain;
//middle man connecting to database 
public class TaskItemService
{
    //instance variable
    List<TaskItem> Taskitems = new();

    public TaskItemService()
    {
        //constructor
        PopulateInitialTasksItems();

    }
//overloaded constructor
    public TaskItemService(List<TaskItem> taskitems, bool append = true)
    {
        if (append)
        {//create initial list of task items
            PopulateInitialTasksItems();
            this.Taskitems.AddRange(taskitems);
        }
        else
        {//replace the existing task items with existing TI
            this.Taskitems = taskitems;
        }
    }

    private void PopulateInitialTasksItems()
    {

        TaskItem Taskone = new("Take out the trash");

        TaskItem Tasktwo = new("Upgrade Phone");
        TaskItem Taskthree = new("Clean the roof");


        Taskitems.Add(Taskone);
        Taskitems.Add(Tasktwo);
        Taskitems.Add(Taskthree);

        foreach (var item in Taskitems)
        {
            Console.WriteLine($"{item.Id}: {item.GetTitle()}");
        }
    }

    public void AddTask(string title)
    {
        Taskitems.Add(new TaskItem(title));

    }
    public int DeleteTask(int id) //deletes any task items with matching Id
    {
        //what is the task, can idnetify by name, Id is best
        //Id is more unique 
        //for better ux confirming the taskitem
       return Taskitems.RemoveAll(TaskItem => TaskItem.Id == id);
    }
    

    //move this to the Ui layer
    public void DisplayTaskItems()
    {
        foreach (var item in Taskitems)
        {
            Console.WriteLine($"{item.Id}: {item.GetTitle()}");
        }

    }


}
