using System;

class Hider
{
   private List<Word> _words;
    private Random _rand;

    public Hider(List<Word> words)
    {
        _words = words;
        _rand = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    } 
}
