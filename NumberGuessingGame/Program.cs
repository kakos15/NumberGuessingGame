// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//Console.WriteLine("Hello, World!");

Random r = new Random();
int winNum = r.Next(0, 100);
bool win = false;
do {

    Console.Write("Guess a number in between  0 and 100: ");
    string s  = Console.ReadLine();

    int i = int.Parse(s);
    if (i > winNum)
    {
        Console.WriteLine("To high! Guess lower...");
    }
    else if (i < winNum)
    {
        Console.WriteLine("Go low! Guess higher...");
    }
    else if (i == winNum)
    {
        Console.WriteLine("YOU WIN");
        win = true;
    }
}while(win ==false);
Console.WriteLine("Thank you for playing the game");
Console.WriteLine("Press any to finish ");
Console.ReadKey(true);


