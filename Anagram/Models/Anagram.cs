using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Word
  {

    public string Letters { get; set; }
    public bool IsAnagram { get; set; }
    private static List<Word> _instances = new List<Word> {};

    public Word(string letters, bool isAnagram)
    {
      Letters = letters;
      _instances.Add(this);
      IsAnagram = isAnagram;
    }

    public static List<Word> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void ToArr()
    {

      string val = Console.ReadLine();

      foreach (Word thisWord in Word.GetAll())
      {
        char[] chr = thisWord.Letters.ToLower().ToCharArray(); 
        
        Array.Sort(chr);

        string val2 = new string (chr);


      }
    }
  }
}