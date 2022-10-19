//for getting the users guess
class Guess {
    //variables
    private string guess = "";

    //methods
    public string GetGuess() {
        return guess;
    }
    public void SetGuess() {
        this.guess = guess;
    }

    //get the guess from the User
    public string GetUserGuess() {
        Console.Write("Guess a letter [a-z]: ");
        return guess = Console.ReadLine() ?? "";
    }
}
