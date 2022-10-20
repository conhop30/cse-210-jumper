//for running the game
class Game {
    public void PlayGame() {
    //intialize class variables
    Display display = new Display();
    Guess guess = new Guess();
    Generator generator = new Generator();

    //set up game
    generator.GetWordCount();
    display.DisplayJumper();
    //start playing game
    guess.GetUserGuess();
    display.DisplayWordLine();
    }
}
