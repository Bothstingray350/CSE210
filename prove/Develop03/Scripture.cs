using System.Data;

public class Scripture
{
    private Reference _ref;
    private List<Word> _verse;
    private Random _rand = new Random();

    public Scripture(Reference reference, List<Word> verse)
    {
        _ref = reference;
        _verse = verse;
    }

    public void SetReference(Reference reference)
    {
        _ref = reference;
    }
    public void AddWord(Word word)
    {
        _verse.Add(word);
    }
    public bool HideWords(int numHidden=3)
    {
        List<int> validIndexes = new List<int>();
        int random_index;
        for(int i=0;i<_verse.Count;i++) // for each Word in _verse
        {
            if(!_verse[i].GetisHidden()) // if the word is not hidden
            {
                validIndexes.Add(i); // add its index to list of unhidden indexes
            }
        }
        if(validIndexes.Count == 0) // If there are no more words to turn blank
        {
            return true; // return that we are done
        }
        for(int i=0;i<numHidden;i++) 
        {
            random_index = _rand.Next(0, validIndexes.Count); // get random index of validIndexes
            _verse[validIndexes[random_index]].Hide(); // hide word in _verse at validIndex chosen at random
        }
        return false;
    }
    public string GetReferenceVerseStr()
    {
        string verse = "";
        foreach(Word word in _verse)
        {
            verse += word.GetWord() + " ";
        }
        return $"({_ref.GetReferenceStr()}){verse}";
    }
}