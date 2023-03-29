public static class PalindromeStack
{
    //Create a function that has a string parameter for a word/sentence
    static void Test(string word)
    {
        // Initiate a stack
        Stack < char > stack = new Stack < char > ();
        // Iterate through each letter in the word/sentence
        foreach (var letter in word)
        {
            // Add each letter to the stack
            stack.Push(letter);
        }

        // Create a variable to hold the new word
        var newWord = "";
        // Loop through each letter in the stack until it is empty
        while (stack.Count > 0)
        {
            // Pop of the top letter off the stack and add it to the new string
            newWord += stack.Pop();
        }

        // Print out the new string and see if it is a palindrome
        Console.WriteLine(newWord);
    }

    static void Main()
    {
        Console.WriteLine("Choose a word to see if it is a palindrome: ");
        string word = Console.ReadLine();
        Test(word);
    }
}

