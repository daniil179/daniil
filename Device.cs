usign System;
public abstract class Device : ITestable
{
public string Name { get; set; }
public string Model { get; set; }
public bool IsWorking { get; protected set; }
public abstact void Test ();
public virtual void DisplayInfo()
{
Console.WriteLine($"{Name} ({Model}) - {(IsWorking ? "Работает" : "Неработает")}");
}
}
