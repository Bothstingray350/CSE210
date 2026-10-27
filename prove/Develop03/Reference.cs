public class Reference
{
    private string _book;
    private int _chapter;
    private int _sVerse;
    private int _eVerse;
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _sVerse = startVerse;
        _eVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _sVerse = startVerse;
        _eVerse = endVerse;
    }
    public string GetReferenceStr()
    {
        if(_sVerse != _eVerse)
        {
            return $"{_book} {_chapter}:{_sVerse}-{_eVerse}";
        } else
        {
            return $"{_book} {_chapter}:{_sVerse}";
        }
    }
}