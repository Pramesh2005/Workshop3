using System;

namespace Task2;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        Console.WriteLine(username == null ? "Username is not available" : username);
        Console.WriteLine(username ?? "Username is not available");
        username ??= "name1";
        Console.WriteLine("Updated username: " + username);

    }

}
