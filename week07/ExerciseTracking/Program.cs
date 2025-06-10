using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ExerciseTrackingProject
{
    public class Activity
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project..");
        }
        
        private DateTime date;
    protected int durationInMinutes;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        durationInMinutes = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {durationInMinutes} min";
    }
}
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (durationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return durationInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min/km";
    }
}
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (durationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}

}

