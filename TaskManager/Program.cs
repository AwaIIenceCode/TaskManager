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
        this._priority = priority;
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
     Console.WriteLine($"Task: {_description} Priority: {_priority} Completed: {status}");   
    }
}
class MyClass
{
    static void Main()
    {}
}