/* 
    Words.cs
    Jacob Mertz / Section 01B / 2:30PM

    This class handles the word list and random word generation for the Wordle game.
    It reads a list of words from a file, filters them to only include 5-letter words,
    and provides a method to get a random word from the list.
    
*/


using System;
using System.IO;

public class Words
{
    public string[] wordList;
    public int wordCount;

    public Words()
    {
        string[] allWords = File.ReadAllLines("words.txt");
        wordList = new string[allWords.Length];
        wordCount = 0;

        foreach (string line in allWords)
        {
            string word = line.Trim().ToUpper();
            if (word.Length == 5)
            {
                wordList[wordCount] = word;
                wordCount++;
            }
        }
    }

    public string GetRandomWord()
    {
        Random rand = new Random();
        int index = rand.Next(wordCount);
        return wordList[index];
    }
}
