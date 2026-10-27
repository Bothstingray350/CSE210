using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }
    
    public void Hide()
    {
        string replacement = "";
        for (int i=0;i<_word.Length;i++)
        {
            replacement += '_';
        }
        _word = replacement;
        _isHidden = true;
    }
    public void SetWord(string newWord)
    {
        _word = newWord;
    }
    public bool GetisHidden()
    {
        return _isHidden;
    }
    public string GetWord()
    {
        return _word;
    }
}