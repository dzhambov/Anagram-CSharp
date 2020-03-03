using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word: ");

      string mainWord = Console.ReadLine();

       char[] chrMain = mainWord.ToLower().ToCharArray(); 
        
        Array.Sort(chrMain);

      string val1 = new string(chrMain);

      Console.WriteLine("Enter three words to check to see if they are an anagram of the first word. Enter the first word:");

      string newLetters = Console.ReadLine();

      Word newWord = new Word(newLetters, false);

      Console.WriteLine("Enter the second word: ");
      string newLetters2 = Console.ReadLine();

      Word newWord2 = new Word(newLetters2, false);

      Console.WriteLine("Enter the third word: ");
      string newLetters3 = Console.ReadLine();

      Word newWord3 = new Word(newLetters3, false);

         foreach (Word thisWord in Word.GetAll())
      {
        char[] chr = thisWord.Letters.ToLower().ToCharArray(); 
        
        Array.Sort(chr);

        string val2 = new string (chr);

        if (val1 == val2)
        {
          Console.WriteLine(thisWord.Letters + " is an anagram of " + mainWord + ".");
        }
        else
        {
          Console.WriteLine(thisWord.Letters + " is NOT an anagram of " + mainWord + ".");
        }
      }
    }
  }
}
      
  

   