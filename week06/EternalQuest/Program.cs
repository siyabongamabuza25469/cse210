using System;
using System.Collections.Generic;
using System.Dynamic;

namespace EternalQuestProject
{
    public abstract class Goal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!This is the EternalQuest Project.");
    }

     public string Name { get; set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        IsCompleted = false;
    }

    public virtual void MarkComplete()
    {
        IsCompleted = true;
    }

    public abstract int CalculatePoints();
    public abstract string GetProgress();
}
public class SimpleGoal : Goal
{
    public int Points { get; private set; }

    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override int CalculatePoints()
    {
        if (IsCompleted)
        {
            return Points;
        }
        else
        {
            return 0;
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}

public class EternalGoal : Goal
{
    public int Points { get; private set; }

    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override int CalculatePoints()
    {
        return Points;
    }

    public override string GetProgress()
    {
        return "[Ongoing]";
    }
}

public class ChecklistGoal : Goal
{
    public int SingleCompletionPoints { get; private set; }
    public int TotalCompletionBonus { get; private set; }
    public int TargetTimes { get; private set; }
    private int timesCompleted;

    public ChecklistGoal(string name, int singleCompletionPoints, int totalCompletionBonus, int targetTimes) : base(name)
    {
        SingleCompletionPoints = singleCompletionPoints;
        TotalCompletionBonus = totalCompletionBonus;
        TargetTimes = targetTimes;
        timesCompleted = 0;
    }

    public override void MarkComplete()
    {
        timesCompleted++;
        if (timesCompleted == TargetTimes)
        {
            IsCompleted = true;
        }
    }

    public override int CalculatePoints()
    {
        int totalPoints = timesCompleted * SingleCompletionPoints;
        if (IsCompleted)
        {
            totalPoints += TotalCompletionBonus;
        }
        return totalPoints;
    }

    public override string GetProgress()
    {
        return $"Completed {timesCompleted}/{TargetTimes} times";
    }
}

}