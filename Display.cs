//for visuals
class Display {
    //initialize class variables
    Generator generator = new Generator();
    Guess guess = new Guess();

    public void DisplayJumper() {
        Console.WriteLine(@"  ___");
        Console.WriteLine(@" /___\");
        Console.WriteLine(@" \   /");
        Console.WriteLine(@"  \ /");
        Console.WriteLine(@"   O");
        Console.WriteLine(@"  /|\");
        Console.WriteLine(@"  / \");
        Console.WriteLine(@"     ");
        Console.WriteLine(@"^^^^^^^");
    }

    //display the line for the word being guessed
    //display the letters already guessed
    public void DisplayWordLine() {
        //temp variables
        string word = generator.GetWord();
        string userGuess = guess.GetUserGuess();
        int wordCount = generator.GetWordCount();
        
        //compare user Guess to program Word
        for (int i = 0; i != wordCount; i++) {

            //display the correctly guessed letter
            /*TODO This is a very sloppy way to make userGuess a "char", but I
            don't want to spend the time right now to find a clean way*/
            if (userGuess[i - i] == word[i]) {
                Console.Write($"{userGuess}");
            }

            //display the missing letter line
            else {
                Console.Write("_ ");
            }
        }
    }
}