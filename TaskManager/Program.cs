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

    public string Description
    {
        get => _description;
    }

    public int Priority
    {
        get => _priority;
        set
        {
            if (value < 1 || value > 5)
                throw new ArgumentException("Priority must be between 1 and 5");

            _priority = value;
        }
    }

    public bool IsCompleted { get; private set; }

    public void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"The task \"{_description}\" is complete!");
    }

    public void NotComplete()
    {
        IsCompleted = false;
        Console.WriteLine($"The task \"{_description}\" is not complete!");
    }

    public string Status => Priority >= 4 ? "High" : Priority >= 2 ? "Medium" : "Low";

    public void Print()
    {
        Console.WriteLine($"Task: {Description}, Priority: {Priority} ({Status}), Completed: {IsCompleted}");
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
}