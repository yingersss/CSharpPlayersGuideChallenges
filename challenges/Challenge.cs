using System;

public interface Challenge
{
    string name { get; }
    int number { get; }
    void Run();
}
