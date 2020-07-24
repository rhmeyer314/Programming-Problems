using Xunit;
using System.Collections.Generic;

public class Test
{
    Solution solution = new Solution();

    // ---------------------------------------------- NumberOfPalindromes ----------------------------------------------

    [Fact]
    public void EmptyStringNumberOfPalindromesTest()
    {
        string input = "";
        int expected = 0;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullNumberOfPalindromesTest()
    {
        string input = null;
        int expected = 0;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SpecialCharactersNumberOfPalindromesTest()
    {
        string input = "Hello $racecar# driver. Anna # is waiting for you near the rotor\n";
        int expected = 3;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Fact]

    public void NormalNumberOfPalindromesTest()
    {
        string input = "Anna is going for a drive today. She is a professional racecar driver and is getting for the next big race. Her mom has been" +
        "very supportive of her. Once Anna finishes the race, she wants to kayak with her mom.";
        int expected = 8;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleSpacesNumberOfPalindromesTest()
    {
        string input = "     By      high        noon tomorrow, there will be a festival      ";
        int expected = 2;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("This test looks to see if zero palindromes are recognized in inputs that have 0 palindrome words")]
    [InlineData("@ #$ *() ---- 121")]
    [InlineData("6^2 is equal to 36")]
    public void ZeroPalindromesTest(string input)
    {
        int expected = 0;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Refer Anna to the next level")]
    [InlineData("The #stats& will be posted at noon. I @ can't wait")]
    [InlineData("Wow   there are a lot of storms on the radar")]
    public void DataWithSameOutcomeNumberOfPalindromesTest(string input)
    {
        int expected = 3;
        int actual = solution.NumberOfPalindromes(input);
        Assert.Equal(expected, actual);
    }


    // ---------------------------------------------- NumberOfPalindromeSentences ----------------------------------------------

    [Fact]
    public void EmptyParagraphTest()
    {
        string input = "";
        int expected = 0;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullParagraphTest()
    {
        string input = null;
        int expected = 0;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NormalSentencesTest()
    {
        string input = "This is a normal, random sentence. Anne, I stay a day at Sienna. Rise to vote, Sir. This sentence is not a palindrome.";
        int expected = 2;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleSentencesTest()
    {
        string input = "Sore was I ere I saw Eros. A man, a plan, a canal -- Panama. Never a foot too far, even. This is a sentence that is not a palindrome";
        int expected = 3;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NumbersTest()
    {
        string input = "1111. 22222.";
        int expected = 0;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ZeroPalindromeSentencesTest()
    {
        string input = "These are sentences that are not considered palindromes. Since there are no sentences that are palindromes, this test should " +
        "expect a 0. Goodbye";
        int expected = 0;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SpecialCharacterSentencePalindromeTest()
    {
        string input = "These inputs #^ contain * special characters. 21 12. The next sentence is the only palindrome! Sire, was I ere I saw Eris?";
        int expected = 1;
        int actual = solution.NumberOfPalindromeSentences(input);
        Assert.Equal(expected, actual);
    }


    // ---------------------------------------------- uniqueWords ----------------------------------------------

    [Fact]
    public void EmptyStringUniqueTest()
    {
        string input = "";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullUniqueTest()
    {
        string input = null;
        Dictionary<string, int> expected = new Dictionary<string, int>();
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NormailUniqueTest()
    {
        string input = "This sentence is a normal sentence. This sentence is not normal! Some words vary.";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("this", 2);
        expected.Add("sentence", 3);
        expected.Add("is", 2);
        expected.Add("a", 1);
        expected.Add("normal", 2);
        expected.Add("not", 1);
        expected.Add("some", 1);
        expected.Add("words", 1);
        expected.Add("vary", 1);
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NoUniqueWordsTest()
    {
        string input = "There is not one repeated word in this sentence.";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("there", 1);
        expected.Add("is", 1);
        expected.Add("not", 1);
        expected.Add("one", 1);
        expected.Add("repeated", 1);
        expected.Add("word", 1);
        expected.Add("in", 1);
        expected.Add("this", 1);
        expected.Add("sentence", 1);
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SpecialCharacterUniqueTest()
    {
        string input = "Hello $ #I# am Dan. Hello";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("hello", 2);
        expected.Add("i", 1);
        expected.Add("am", 1);
        expected.Add("dan", 1);
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MultipleSpacesUniqueWordTest()
    {
        string input = "There    are a     lot of spaces.     Spaces      ";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("there", 1);
        expected.Add("are", 1);
        expected.Add("a", 1);
        expected.Add("lot", 1);
        expected.Add("of", 1);
        expected.Add("spaces", 2);
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AllRepeatsWords()
    {
        string input = "Each sentence is the same. Each sentence is the same. Each sentence is the same. Each sentence is the same.";
        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("each", 4);
        expected.Add("sentence", 4);
        expected.Add("is", 4);
        expected.Add("the", 4);
        expected.Add("same", 4);
        Dictionary<string, int> actual = solution.UniqueWords(input);
        Assert.Equal(expected, actual);
    }

    // ---------------------------------------------- wordsContainingChar ----------------------------------------------

    [Fact]
    public void EmptyStringContainingCharTest()
    {
        string input = "";
        List<string> expected = new List<string>();
        List<string> actual = solution.WordsContainingChar(input, 'a');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullContainingCharTest()
    {
        string input = "";
        List<string> expected = new List<string>();
        List<string> actual = solution.WordsContainingChar(input, 'a');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NormalContainingCharTest()
    {
        string input = "Test to see how many words contain the letter e. Repeated words, like test, count more than once.";
        List<string> expected = new List<string> { "Test", "see", "the", "letter", "e", "Repeated", "like", "test", "more", "once" };
        List<string> actual = solution.WordsContainingChar(input, 'e');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SpaceContainingCharTest()
    {
        string input = "Random sentence to test how many words contain a space";
        List<string> expected = new List<string>();
        List<string> actual = solution.WordsContainingChar(input, ' ');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NewLineCharTest()
    {
        string input = "This has a newline character\n.";
        List<string> expected = new List<string>();
        List<string> actual = solution.WordsContainingChar(input, '\n');
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void capitalizedTest()
    {
        string input = "Word";
        List<string> expected = new List<string> { "Word" };
        List<string> actual = solution.WordsContainingChar(input, 'w');
        Assert.Equal(expected, actual);
    }
}