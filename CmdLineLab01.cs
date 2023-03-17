// Project Prolog
// Name: Andrew Todd
// CS3260 Section 001
// Project: Lab_01
// Date:  08/26/22
// Purpose: Demonstrate the C# System.Console functionality by reading in command line arguments and printing them to the console.
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

public class Program
{
	/// <summary>
	/// Purpose: Entry point of the program. Display the parameters passed to the method on the Console
	/// </summary>
	static void Main(string[] args)
	{
		if(args.Length < 2)
		{
			Console.WriteLine("Input of insufficient length.\n Only {0} arguments entered.\n Please enter 2 or more!", args.Length);
			return;
		}
		
		Console.WriteLine("{0} arguments entered. They are\n", args.Length);
		
		foreach(string s in args)
		{
			Console.WriteLine("{0}", s);
		}
		
		return;
	}
}
		