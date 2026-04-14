public interface ITaskable
//This interface defines the contract for a task.
{
    string GetTitle();
    /// Gets the description of the task.
    /// <returns></returns>
    string GetDescription();

    /// Gets whether the task is complete or not.
    /// <returns>The status of completion.</returns>
    bool IsComplete();
    /// Marks the task as complete.
    /// <returns weather task was completed or not></returns>
    bool MarkComplete();

}
    
