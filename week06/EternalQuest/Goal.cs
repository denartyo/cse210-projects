using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName() => _name; // Getter for _name
    public string GetDescription() => _description; // Getter for _description
    public int GetPoints() => _points; // Getter for _points

    public abstract int RecordEvent(); // Abstract method for polymorphism
    public abstract string GetStatus(); // Abstract method for displaying progress

}