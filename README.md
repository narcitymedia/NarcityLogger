# NarcityLogger
A very simplistic .NET (dotnet) Core Logger that outputs colorful text to the console and displays the time at which the text was logged.

## How to use
First, add a reference to the [Nuget package](https://www.nuget.org/packages/NarcityLogger/).
If you're using the dotnet CLI you can do so by running :

`dotnet add package NarcityLogger --version 1.0.1`

Otherwise, follow the instructions given on the [Nuget package page](https://www.nuget.org/packages/NarcityLogger/) that corresponds to your facourite package manager.

Now to use the Logger in your soruce code, you only have to use the `NarcityMedia.Log` namespace and you're good to go.
The following code:
```csharp
using System;
using NarcityMedia.Log;

namespace LoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NMLogger.Log("Normal");
            NMLogger.Log("Success", LogType.Success);
            NMLogger.Log("Info", LogType.Info);
            NMLogger.Log("Warning", LogType.Warning);
            NMLogger.Log("Error", LogType.Error);
        }
    }
}
```
Will produce the following output
### On Windows
![Windows output example](https://github.com/narcitymedia/NarcityLogger/blob/master/assets/windows-example.png)
### On Unix Systems
![Unix output example](https://github.com/narcitymedia/NarcityLogger/blob/master/assets/unix-example.png)
