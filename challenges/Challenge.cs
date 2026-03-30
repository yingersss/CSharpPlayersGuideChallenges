using System;

public interface Challenge
{
    string challengeName { get; }
    int challengeNumber { get; }
    void Run();
}
