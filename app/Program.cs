// See https://aka.ms/new-console-template for more information

using System.Xml;
using System.Diagnostics;

string[] possWords = ["WHAKA","MALSALA"];
Random randomGenerator = new();

string solution = possWords[randomGenerator.Next(0,possWords.Length)];

string display = new string('_', solution.Length);

string guess = getUserGuess();
Console.WriteLine(display);
/*

*/
bool quessIsCorrect = false;

for (int i = 0; i < solution.Length; i++)
{
    if (guess[0] == solution[i])
    {
        display.Remove(i,1);
        display.Insert(i, guess);
        quessIsCorrect = true;
    }
}
if(quessIsCorrect = true)
{
    Console.WriteLine($"{guess} exist");
}
else
{
    Console.WriteLine($"{guess} dont exist");    
}

string? getUserGuess()
{
    string guess = null;
    do
    {
        Console.WriteLine("enter a char, fool");
        string input = Console.ReadLine();
        Debug.Assert(input != null);
        if (input.Length == 1)
        {
            guess = input;
        }
    } while (guess == null);
    Debug.Assert(guess != null);
    return guess;
}