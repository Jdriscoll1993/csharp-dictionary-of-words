using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Create a dictionary with key value pairs to
      represent words (key) and its definition (value)
      */
      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

      // Add several more words and their definitions
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
      wordsAndDefinitions.Add("Dope", "The definition of Joey Driscoll");
      wordsAndDefinitions.Add("Greatness", "The status of one who knows what's up");

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */
      Console.WriteLine($"Awesome: {wordsAndDefinitions["Awesome"]}");
      Console.WriteLine($"Dope: {wordsAndDefinitions["Dope"]}");
      Console.WriteLine($"Greatness: {wordsAndDefinitions["Greatness"]}");
      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */
      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value} ");
      }
    }
  }
}
