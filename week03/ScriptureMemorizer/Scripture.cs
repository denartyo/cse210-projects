using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Hider _hider;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _hider = new Hider(_words);
    }

    public void HideWords(int numberToHide)
    {
        _hider.HideRandomWords(numberToHide);
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}


// class Scripture
// {
//     private Reference _reference;
//     private List<Word> _words;

//     public Scripture(Reference reference, string text)
//     {
//         _reference = reference;
//         _words = text.Split(' ').Select(word => new Word(word)).ToList();
//     }

//     public void HideRandomWords(int numberToHide)
//     {
//         Random rand = new Random();
//         var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

//         for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
//         {
//             int index = rand.Next(visibleWords.Count);
//             visibleWords[index].Hide();
//             visibleWords.RemoveAt(index);
//         }
//     }