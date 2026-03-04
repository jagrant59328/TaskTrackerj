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
    public TaskItem(string title)
    {
        Id = ++_Totalcount;
        Title = title; 
    }

    public int Id { get; }
    public string Title = string.Empty; 
    public bool IsComplete { get; set; }
    //consider achivement system
}