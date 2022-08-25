using System;
using prog.lib;

const string msg = "Enter a number between 1 and 2000,  or enter X to exit";
var response = "";

do
{

    Console.WriteLine(msg);
    response = Console.ReadLine();

    response = string.IsNullOrEmpty(response) ? "X" : response.ToUpper();

    if (response != "X")
    {

        var num = Convert.ToInt32(response);
        if (num < 1 || num > 2000)
        {
            Console.WriteLine("Number must be between 1 and 2000");
        }
        else
        {
            Console.WriteLine($"The number ({num}) is equivalent to the Roman number: {Roman.ConvertRomanForAll(num)}");
            System.Console.WriteLine();
        }
    }
} while (response.ToUpper() != "X");

System.Console.WriteLine("Goodbye!");

