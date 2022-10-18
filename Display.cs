//for visuals
class Display {
    //initialize class variables
    Generator generator = new Generator();
    Guess guess = new Guess();

    public void DisplayJumper() {
        Console.WriteLine(@" ___");
        Console.WriteLine(@"/___\");
        Console.WriteLine(@"\   /");
        Console.WriteLine(@" \ /");
        Console.WriteLine(@"  O");
        Console.WriteLine(@" /|\");
        Console.WriteLine(@" / \");
        Console.WriteLine(@"^^^^^^^");
    }

    //display the line for the word being guessed
    //display the letters already guessed
    public void DisplayWordLine() {
        //temp variables
        string word = generator.GetWord();
        string input = guess.GetGuess();
        int wordCount = generator.GetWordCount();
        
        //compare user Guess to program Word
        for (int i = 0; i != wordCount; i++) {
            if (input[i] == word[i]) {
                
            }
        }
    }
}