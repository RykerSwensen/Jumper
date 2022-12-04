class Dictionary {

    private List<string> words = new List<string>() { 
        "dog", 
        "cat", 
        "mouse", 
        "moose", 
        "cow", 
        "deer", 
        "doe", 
        "bass", 
        }; 

    private Random rnd = new Random();

    public Dictionary() {
    }

    public string GetRandomWord() {
        return words[rnd.Next(0, words.Count - 1)];
    }
}