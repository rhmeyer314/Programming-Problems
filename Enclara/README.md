## Problem:Using VS Code, write a C# solution to take in an input of a paragraph and:

## Give the number of palindrome words

## Give the number of palindrome sentences

## List the unique words of a paragraph with the count of the word instance

## Let the user also input a letter at some point and list all words containing that letter

### To solve this, I created four different methods to solve each individual problem. I also created another method that prompts the user for input, and displays the correct solution for each of the four problems based on that input. Below I have detailed how each of the four methods solves their respective problems.

### NumberOfPalindromes(string paragraph)
#### This method takes in a string and returns a count of how many times a palindrome was seen. The main issue on this problem was determining what is and is not a word. I decided to exclude special and numeral characters. I created a helper method, trimWords(string str), which returns a List of alphabetic words. I loop through this list, and use another helper method, isPalindrome(string word), to check each word in the list and determine if the word is a palindrome or not. If the word is a palindrome, then the count is incremented. If the word is not a palindrome then the loop moves to the next iteration. Once the loop breaks, the count is returned.
