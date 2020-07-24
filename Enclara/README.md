## Problem: Using VS Code, write a C# solution to take in an input of a paragraph and: Give the number of palindrome words, Give the number of palindrome sentences, List the unique words of a paragraph with the count of the word instance, Let the user also input a letter at some point and list all words containing that letter


### To solve this, four different methods were created to solve each individual problem. Another method, GetInputAndPrint() is created, which prompts the user for input and displays the correct solution for each of the four problems based on that input. Below each of the four methods are detailed on what they accomplish.

### **int NumberOfPalindromes(string paragraph)**
#### This method solves the problem for the number of palindrome words in a paragraph. This method takes in a string as an argument and returns a count of the number of palindrome words in the paragraph.

### **int NumberOfPalindromeSentences(string paragraph)**
#### This method solves the problem for the number of palindrome sentences in a paragraph. This method takes in a string as an argument and returns a count of the number of palindrome sentences in the paragraph.

### **Dictionary<string, int> UniqueWords(string paragraph)**
#### This method solves the problem to list the unique words with the count of the word instance. This method takes in a string as an argument and returns a dictionary object where the words are the keys and the number of appearances for each word is the value.

### **List<string> WordsContainingChar(string paragragh, char character)**
#### This method solves the problem to list all words that contain a letter. This method takes in a string and a character as arguments and returns a list of all words in the string that contain the provided character.

### Note: Only strings that contained only alphabetic characters were considered words. Special and numeric characters are not consider words. All special and numeric characters were removed from each word. 
