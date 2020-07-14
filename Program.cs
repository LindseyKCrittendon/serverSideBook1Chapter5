using System;
using System.Collections.Generic;

namespace chapter5exercises
{
    class Program
    {
        static void Main(string[] args)
        {
//            Practice: Dictionary of Words
// You are going to buid a C# Dictionary to represent an actual dictionary. Each KeyValuePair within the Dictionary will contain a single word as the key, and a definition as the value. Below is some starter code. You need to add a few more words and definitions to the dictionary.

// After you have added them, use square bracket notation to output the definition of two of the words to the console.


// Lastly, use the foreach loop to iterate over the KeyValuePairs and display the entire dictionary to the console.

/*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
wordsAndDefinitions.Add("Tired", "The feeling of starting over completely");
wordsAndDefinitions.Add("Excited", "The feeling of learning something new that might make all the things you already learned a little easier");

Console.WriteLine(wordsAndDefinitions["Excited"]);
Console.WriteLine(wordsAndDefinitions["Tired"]);

/*
    Use square brackets to get the definition of two of the
    words and then output them to the console
*/


/*
    Below, loop over the wordsAndDefinitions dictionary to get the following output:
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
        The definition of (WORD) is (DEFINITION)
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{
    Console.WriteLine($"The definition of {word.Key} is {word.Value}");
};
        }
    }
}
