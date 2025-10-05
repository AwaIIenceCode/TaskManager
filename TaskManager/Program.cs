using System;
class Task
{
    private readonly string _description;
    private int _priority;
    private bool _isCompleted;
    public Task(string description)
    {
        if (string.IsNullOrEmpty(description)) throw new ArgumentException("Description cannot be empty!");
        this._description = description;
        this._priority = 1;
        this._isCompleted = false;
    }
    public Task(string description, int priority) : this(description)
    {
        this._priority = (priority < 1 || priority > 5) ? priority : 1 ;
    }
    public Task(string description, int priority, bool isCompleted) : this(description, priority)
    {
        this._isCompleted = isCompleted;
    }
    public void Complete()
    {
        this._isCompleted = true;
        Console.WriteLine($"The task \"{_description}\" is complete!");
    }
    public void NotComplete()
    {
        this._isCompleted = false;
        Console.WriteLine($"The task \"{_description}\" is not complete!");
    }
    public void Print()
    { 
     string status = _isCompleted ? "Yes" : "No";
     Console.WriteLine($"Task: {_description}, Priority: {_priority}, Completed: {status}");   
    }
}
class MyClass
{
    static void Main()
    {
        Task task1 = new Task("Write code");
        Task task2 = new Task("Fix bugs", 3);
        Task task3 = new Task("Deploy app", 5, true);

        task1.Print();
        task2.Print();
        task3.Print();

        task2.Complete();
        task2.Print();
    }
}