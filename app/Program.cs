// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml;

string[] possWords = ["WHAKA","MALSALA"];
Random randomGenerator = new();

string solution = possWords[randomGenerator.Next(0,possWords.Length)];

string display = new string('_', solution.Length);
bool again = true;
while (again)
{
  while (display.Contains('_'))
  {
      Console.WriteLine(display);
      string guess = getUserGuess().ToUpper();
  
  /*
  
  */
      bool quessIsCorrect = false;
  
      for (int i = 0; i < solution.Length; i++)
      {
          if (guess[0] == solution[i])
          {
              display = display.Remove(i,1);
              display = display.Insert(i, guess);
              quessIsCorrect = true;
          }
      }
      if(quessIsCorrect == true)
      {
          Console.WriteLine($"{guess} exist genius");
      }
      else
      {
          Console.WriteLine($"{guess} dont exist fool");    
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
              else
              {
                  Close();
              }
          } while (guess == null);
          Debug.Assert(guess != null);
          return guess;
      
  }
  
      void Close()
      {
      
      }   
  
}
}
Console.WriteLine($"You got it! the word was {solution}!");
Console.WriteLine("Wanna go again?(Y/N)");
string restart = Console.ReadLine().ToUpper();
if (restart == "Y")
{
    again = true;
}
else
{
    again = false;
}

