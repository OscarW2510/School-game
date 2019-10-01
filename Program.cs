using System;

class MainClass
{
    public static void Main(string[] args)
    {

        ShowHeading(1);

        Console.WriteLine("Please enter your name");
        string myname;
        myname = Console.ReadLine();

        Console.WriteLine(myname + " Please enter your name");
        Console.WriteLine("Hope you have an amazing time down here");

        // First choice
        Console.WriteLine("Would you like to be a wizard or a toadman");
        string choice1;
        choice1 = Console.ReadLine();
        // wizard
        if (choice1 == "wizard")
        {
            Console.WriteLine("You're a hizzard warry");
            Console.WriteLine("You made the right decision what power do you want? Fire or Lightning");
            string FireOrLightning;
            FireOrLightning = Console.ReadLine();
            if (FireOrLightning == "fire")
            {
                Console.WriteLine("Well done you chose the best one");
            }
            else
            {
                Console.WriteLine("You idiot everyone knows that fire is the better option");
            }

        }
        else
        {
            // toadman
            Console.WriteLine("Your're a toadman bro");
            Console.WriteLine("Are you sure you picked the right person");


            string areyousure;
            areyousure = Console.ReadLine();
            if (areyousure == "yes")
            {
                Console.WriteLine("Well then I wish you luck on making it to the end you twat");
            }
            else
            {
                Console.WriteLine("Good, you better be sorry");
            }


        }


        Console.WriteLine("Are you ready for the boss fight");
        string areYouReady;

        areYouReady = inputText();
        if (areYouReady == "yes")
        {
            Console.WriteLine("Ok, on to the next stage");
        }
        while (areYouReady == "yes")
        {
            areYouReady = Console.ReadLine();
            if (areYouReady == "no")
            {
                output("are you sure?" + "\n");
                areYouReady = inputText();
            }
            else
            {
                output("Well then you can't carry on" + "\n");
            }
        }


    }

    public static void ShowHeading(int x)
    {

        Console.WriteLine(@" _____  _____  ____  _____  _____  _____    _____  _____  _____  _____  _____  ___  ____ 
    /  ___>/  _  \/    \/  _  \/  _  \/  ___>  /  ___>/  _  \/  _  \|  _  \/  _  \/___\/    \
    |___  ||  _  |\-  -/|  _  ||  |  ||___  |  |___  ||  _  ||  |  ||  |  ||   __/|   |\-  -/
    <_____/\__|__/ |__| \__|__/\__|__/<_____/  <_____/\__|__/\__|__/|_____/\__/   \___/ |__| 
                                                                                            ");


        Console.WriteLine("Hello Welcome to HELL - Level 1");



    }

    private static string inputText()
    {
        return Console.ReadLine();
    }

    private static void output(string text)
    {
        Console.WriteLine(text);
    }
}

/*
using system;

public class MyProgram
{
    public static void main(string[] args)
    {
        ShowHeading();
    }
    
    public static void ShowHeading()
    {
        output("my heading" + "\n");
    }
    
    private static output(string text)
    {
        Console.WriteLine(text)
    }
}

using system;

public class MyProgram
{
    public static void main(string[] args)
    {
        output("Are you ready for the Boss fight" + "\n");
        string areYouReady;
        
        areYouReady = inputText();
        while (areYouReady != "yes")
        {
            if (areYouReady == "no")
            {
                output("are you sure?" + "\n");
                areYouReady = inputText();
            }
            else
            {
                output("Well then you can't carry on" + "\n");
            }
        }
        output("next stage" + "\n");
    }
    
    ' .NET can only read single characters or entire lines from the console.
    ' The following functions are designed to help input specific data types.
    private static double inputValue()
    {
        double result
        while (!double.TryParse(Console.ReadLine(), out result));
        return result
    }
    
    private static string inputText()
    {
        return Console.ReadLine()
    }
    
    private static output(string text)
    {
        Console.WriteLine(text)
    }
}

*/
