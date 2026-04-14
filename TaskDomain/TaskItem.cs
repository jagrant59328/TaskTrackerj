using System.Dynamic;

namespace TaskTracker.TaskDomain;

public class TaskItem : ITaskable
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
    private string Title = string.Empty;
    private bool Complete { get; set; }
    //consider achivement system

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        return string.Empty;
    }

    public bool IsComplete()
    {
        return Complete;
    }

    public bool MarkComplete()
    {
        Complete = true;
        return true;
    }
}
