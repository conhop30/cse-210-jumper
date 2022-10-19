//for generating a random word
class Generator {
    //variables
    //TODO Set to TOBY for testing purposes. Remove once word generator is implemented
    private string word = "Toby";
    private int wordCount = 0;

    //methods
    public string GetWord() {
        return word;
    }
    public void SetWord() {
        this.word = word ?? "";
    }

    public int CalculateWordCount() {
        wordCount = word.Length;
        return wordCount;
    }
    public int GetWordCount() {
        return wordCount;
    }
    
}