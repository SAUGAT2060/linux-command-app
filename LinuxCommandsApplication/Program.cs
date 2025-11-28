// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//After update we are using the above version but for the previous versions the following code used to be written
using System;
using System.Text.Json; //Using is like import in JavaScript //we haven't used it yet

// namespace "My App"


//namespace "MyApp" => from the C# docs
//We need to change it to our application name that is :LinuxCommandsApplication

namespace LinuxCommandsApplication //changed version
{
    //Internal= Only available inside our assembly or we can use public as well (Not much difference in this project)

    //Default => public
    //and this convention by default have Pascal Case

    /*
        Program Class: Contains the main entry point:
        -Static method(Main)
        -Collections(List<T>)
        -JSON file Reading
        -Exception Handling using try and catch
        -OOP example usage(Calling linuxCommand methods)
        
    */
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //We will encapsulate our code with try and catch

            try
            {
                //our main code here...
                
                // Testing: just hardCode the arguments just in case the code is working 
                LinuxCommand command1 = new ("ls","list files");
                command1.ShowCommandInfo();

                //Read all the commands from the JSON files => array of x numbers of commands(objects)
                
                // string jsonString = File.ReadAllText("commands.json");

                string filePath = Path.Combine(AppContext.BaseDirectory,"Data","linux-commands.json");

                //Optional : Check if the file exists before trying to read it 

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File is not found at {filePath} ");
                    //if the file doesn't exist / isn't found 
                    // We need to stop/ terminate our main method 
                    return ;
                }

                string jsonString = File.ReadAllText(filePath);

                Console.WriteLine(jsonString);

                 //  Step04: Deserialize JSON into objects:
                // ---------------------------------------
                // JsonSerializer.Deserialize converts JSON string to C# objects
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-9.0
                // Link: https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer.deserialize?view=net-8.0
                // LinuxCommand => is our Class:
                List<LinuxCommand> allCommands = JsonSerializer.Deserialize<List<LinuxCommand>>(jsonString);

                /* 
                NOTE: We need to use (import in Java) the Json library
                Error: The name 'JsonSerializer' does not exist in the current context
                With "Quick Fix" => using System.Text.Json;
                */

                // Step05-Optional (Strongly Recommended): Check if the commands string is null or empty:
                // --------------------------------------------------------------------------------------
                if (allCommands == null || allCommands.Count == 0)
                {
                    Console.WriteLine("No commands found in the JSON file.");
                }
                else
                {
                    // Step06: Iterate and display commands:
                    // -------------------------------------
                    // Using collections, foreach loop, and object method usage
                    // Display all commands
                    foreach (LinuxCommand cmd in allCommands)
                    {
                        cmd.ShowCommandInfo(); // Call our public method "ShowInfo()" from "LinuxCommand" class
                    }
                }
            

            }
            catch (FileNotFoundException ex)
            {
                //Handle file not found 
                Console.WriteLine($"Error:{ex.Message}");
                
            }
            catch(Exception)
            {
                throw;
            }
        
        }//Main()
    
    
    }//class



}//namespace