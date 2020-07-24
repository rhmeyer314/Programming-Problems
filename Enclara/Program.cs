using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.GetInputAndPrint();
    }
}

class Solution

{
    // this method takes in a string and returns a count of of many palindrome words were in this string
    public int NumberOfPalindromes(string paragragh)
    {
        if (paragragh == null) return 0;

        int count = 0;
        List<string> trimmedWords = TrimWords(paragragh);

        foreach (string word in trimmedWords)
        {
            if (IsPalindrome(word)) count++;
        }

        return count;
    }

    // this method takes in a string and returns a count how many sentences are palindromes
    public int NumberOfPalindromeSentences(string paragragh)
    {
        if (string.IsNullOrEmpty(paragragh)) return 0;

        int count = 0;
        char[] specialCases = { '.', '!', '?' }; // punctuation that ends sentences

        string[] sentences = paragragh.Split(specialCases, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            string trimmedSentence = Regex.Replace(sentence, "[^a-zA-Z]+", "");

            // if the string is null or empty, then it contained only special and/or numeric characters and is not a word. Therefore ignore this string.
            if (string.IsNullOrEmpty(trimmedSentence)) continue;

            if (IsPalindrome(trimmedSentence)) count++;
        }

        return count;
    }

    // this method takes in a string and returns a Dictionary that contains all unique words and the number of times they appear from the string
    public Dictionary<string, int> UniqueWords(string paragragh)
    {
        if (string.IsNullOrEmpty(paragragh)) return new Dictionary<string, int>();

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // lowercase all trimmed words in order to see how many different times a word repeats, regardless of cases
        List<string> trimmedWords = TrimWords(paragragh.ToLower());

        foreach (string word in trimmedWords)
        {
            if (dictionary.ContainsKey(word)) dictionary[word] += 1;

            else dictionary.Add(word, 1);
        }
        return dictionary;
    }

    // this method takes in a string and char, and returns a list of words that contained the char parameter
    public List<string> WordsContainingChar(string paragragh, char character)
    {
        if (string.IsNullOrEmpty(paragragh)) return new List<string>();

        List<string> list = new List<string>();
        List<string> trimmedWords = TrimWords(paragragh);

        foreach (string word in trimmedWords)
            // check to see if character in contained in either uppercase or lowercase strings
            if (word.ToLower().Contains(character) || word.ToUpper().Contains(character)) list.Add(word);

        return list;
    }

    /*
    This method takes in user input and uses the solution methods in order to print out the number of palindrome words,
    the number of palindrome sentences, a list of unique words and how many times they appear, and a list of words that contain
    a specified character.
    */
    public void GetInputAndPrint()
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();
        Console.WriteLine("\nEnter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine(); // added to help with formatting in terminal

        Console.WriteLine("\nNumber of palindromes: " + NumberOfPalindromes(input) + "\n");

        Console.WriteLine("Number of palindrome sentences: " + NumberOfPalindromeSentences(input) + "\n");

        Console.WriteLine("List of unique words: ");
        Dictionary<string, int> dict = UniqueWords(input);
        foreach (KeyValuePair<string, int> entry in dict)
        {
            Console.WriteLine("\"" + entry.Key + "\"" + " appears " + entry.Value + " times");
        }
        Console.WriteLine(); // added to help with formatting in terminal

        Console.WriteLine("The letter " + "\'" + ch + "\'" + " appears in the following words:");
        List<string> list = WordsContainingChar(input, ch);
        foreach (string word in list)
        {
            Console.WriteLine("\"" + word + "\"");
        }
    }

    // this takes in a string and verifies if it is a palindrome or not
    private bool IsPalindrome(string word)
    {
        word = word.ToLower();
        int currentLength = word.Length;

        for (int i = 0; i < word.Length; i++, currentLength--)
            if (word[i] != word[currentLength - 1]) return false;

        return true;
    }

    /* 
    this method takes in a string and returns a list of trimmed words. These trimmed words only contain alphabetic characters. Any special
    or numeral characters are removed from the original words.
    */
    private List<string> TrimWords(string str)
    {
        List<string> output = new List<string>();
        string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string trimmedWord = Regex.Replace(word, "[^a-zA-Z]+", "");

            // if the string is null or empty, then it contained only special and/or numeric characters and is not a word. Therefore ignore this string.
            if (string.IsNullOrEmpty(trimmedWord)) continue;

            output.Add(trimmedWord);
        }

        return output;
    }
}