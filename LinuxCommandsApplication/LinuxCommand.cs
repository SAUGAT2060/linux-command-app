using System;
using System.Dynamic;
//using keyword in C# => import keyword in java 
namespace LinuxCommandsApplication;

public class LinuxCommand
{
    //We need two fields: Command Name and Command Description
    //instead of creating private fields then public getters and setters to access them


//     private string command;

//    private string des;

//We will create getters and setters here 



    public string Command {get;set;} = "";

    /*
    Description of the Linux command,example: "List directory contents"
    Public getter and setter allows controlled access.
    */
      public string Description {get;set;} = "";

  public int CommandId {get; set; }

  /*
  You will be needed to Add at least one more task 
  */
// Constructor:
    // ------------
    // Initializes a new instance of the LinuxCommand class.
    // Constructor ensures that Command and Description are set when creating an object.
    // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
    /// <param name="command">Command name</param>
    /// <param name="description">Command description</param>
    public LinuxCommand(string command, string description)
    {
        // initializing the class properties:
        Command = command; // Assign "command" argument/parameters to the Command property
        Description = description; // Assign the "description" argument/parameters to "Description property
    }

    // Methods:
    // --------
    // Displays the command information in a readable format.
    // Demonstrates object behavior and method usage.
    // Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
    public void ShowCommandInfo()
    {
        // String interpolation for readable output
        // Docs: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        // Passing the class properties: Command and Description
        Console.WriteLine($"{Command}: {Description}");


    //we can create the getters and setters immediately 

    }
}