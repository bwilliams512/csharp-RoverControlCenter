/*
Welcome to SPACE: Space Program for Aeronautical Collection and Exploration. 
I am in charge of the fictional Rover Control Center. 
All rovers on Moon and Mars are under my direction!

This project will show some ways in which references, inheritance, 
interfaces, and arrays can help code better C# programs.
*/

using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		
      // Put three rovers in an array to manage them all at once
      Rover[] rovers = { lunokhod, apollo, sojourner };

      // Call the DirectAll() method usign the array as the argument
      DirectAll(rovers);

      // Create an array containing all the probes
      IDirectable[] allprobes = { lunokhod, apollo, sojourner, sputnik };
      DirectAll(allprobes);

      // Put all three rovers and sateliite in an array to manage all space probes
      Object[] probes = { lunokhod, apollo, sojourner, sputnik };
      Console.WriteLine("\n");
      foreach (Object probe in probes) 
      {
        Console.WriteLine($"Tracking a {probe.GetType()}...");
      }
    }

    // Write a static method that directs the rovers to send info, explore their surroundings, and collect samples
    public static void DirectAll(IDirectable[] allprobes) 
    {
      foreach (IDirectable allprobe in allprobes) 
      {
        Console.WriteLine(allprobe.GetInfo());
        Console.WriteLine(allprobe.Explore());
        Console.WriteLine(allprobe.Collect());
      }
    }
  }
}

