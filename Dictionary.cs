

    public class Dictionary{

        // Opens up the dictionary.txt file and picks out a random word
        private string pullWord(){
            List<string> lines = new List<string>(File.ReadLines("dictionary.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }
      
    }
