using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Test
{
  [TestClass]

  public class WordTest : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]

    public void WordConstructor_CreatsInstanceOfWord_Word()
    {
      Word newWord = new Word("test", false);
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]

    public void GetLetters_ReturnLetters_String()
    {
      string letters = "cat";
      Word newWord = new Word(letters,false);
      string result = newWord.Letters;
      Assert.AreEqual(letters, result);
    }

    [TestMethod]

    public void SetLetters_SetLetters_String()
    {
      string letters = "Cat";
      Word newWord = new Word(letters, false);

      string updatedLetters = "Dog";
      newWord.Letters = updatedLetters;
      string result = newWord.Letters;

      Assert.AreEqual(updatedLetters, result);
    }

    [TestMethod]

    public void GetAll_ReturnEmptyList_WordList()
    {
      List<Word> newList = new List<Word> { };

      List<Word> result = Word.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]

    public void GetAll_ReturnWord_WordList()
    {
      string letters01 = "Cat";
      string letters02 = "Dog";

      Word newWord1= new Word(letters01, false);
      Word newWord2 = new Word(letters02, false);

      List<Word> newList = new List<Word> { newWord1, newWord2 };

      List<Word> result = Word.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]

    public void ToArr_ReturnArr_Arr()
    {
      string letters01 = "Cat";
      string letters02 = "Dog";
      string letters03 = "Bunny";

      Word newWord1= new Word(letters01, false);
      Word newWord2 = new Word(letters02, false);
      Word newWord3 = new Word(letters03, false);

      List<Word> newList = new List<Word> { newWord1, newWord2, newWord3 };
    }
    
  }
}