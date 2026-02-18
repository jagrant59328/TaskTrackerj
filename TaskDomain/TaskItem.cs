using System.Dynamic;

namespace TaskTracker.TaskDomain;

public class TaskItem
{

    //instance properties 
    //instance properties belong to object 
    //static properties belong to the class itself
    private static int _Totalcount = 0;

    public static int Totalcount
    {
        get => _Totalcount;
    }
    //constructors build 
    public TaskItem()
    {
        ++_Totalcount;
    }

    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IsComplete { get; set; }
}