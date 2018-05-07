using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static <Sentence> = new <Sentence> {};
    private string _sentence;

    public class RepeatCounter (string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(newSentence){
      _sentence = newSentence
    }
    public static <Sentence> GetAll()
    {
      return _instances
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
