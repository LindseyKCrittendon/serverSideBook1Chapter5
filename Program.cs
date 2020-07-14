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

// Console.WriteLine(wordsAndDefinitions["Excited"]);
// Console.WriteLine(wordsAndDefinitions["Tired"]);

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
// foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
// {
//     Console.WriteLine($"The definition of {word.Key} is {word.Value}");
// };

// Practice: List of Dictionaries about Words
// Now, you are going to refactor the structure of our data. Instead of one C# Dictionary with key value pairs for words and definitions. You want to track more than just the word and its definition, so we are going to build a list of dictionaries.

// Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few words
Dictionary<string, string> excitedWord = new Dictionary<string, string>();
//can also add objects during instantiation inside curly braces after the parethasis


// Add each of the 4 bits of data about the word to the Dictionary
excitedWord.Add("word", "excited");
excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
excitedWord.Add("part of speech", "adjective");
excitedWord.Add("example sentence", "I am excited to learn C#!");

// Add Dictionary to your `dictionaryOfWords` list
dictionaryOfWords.Add(excitedWord);


// create another Dictionary and add that to the list
Dictionary<string, string> flabberWord = new Dictionary<string, string>(){
    {"word", "flabbergasted"},
    {"definition", "doubting I understand this when I actually do"},
    {"part of speech", "verb"},
    {"example sentence", "I am flabbergasted at the exercises today"},
};

dictionaryOfWords.Add(flabberWord);

Dictionary<string, string> bloopWord = new Dictionary<string, string>(){
    {"word", "bloopfuck"},
    {"definition", "when I try to console something but I'm ever so slightly WRONG"},
    {"part of speech", "noun"},
    {"example sentence", "I see a bloopfuck in my code"},
};

dictionaryOfWords.Add(bloopWord);

/*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

// Iterate the List of Dictionaries
foreach (Dictionary<string, string> singleWord in dictionaryOfWords)
{
    // Iterate the KeyValuePairs of the Dictionary
    foreach (KeyValuePair<string, string> wordData in singleWord)
    {
        Console.WriteLine($"{wordData.Key}: {wordData.Value}");
    }
};
        }
    }
}
