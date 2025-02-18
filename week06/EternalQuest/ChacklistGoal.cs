using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }
     public int GetTargetCount() => _targetCount;
    public int GetCurrentCount() => _currentCount;
    public int GetBonusPoints() => _bonusPoints;

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;

            if (_currentCount == _targetCount)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return (_currentCount >= _targetCount ? "[X]" : "[ ]") + $" {_name} - Completed {_currentCount}/{_targetCount} times";
    }
        
}

