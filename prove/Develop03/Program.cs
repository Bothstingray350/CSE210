using System;

class Program
{
    static Scripture InitScripture(string scripture)
    {
        List<Word> verse = new List<Word>();
        int startVerse;
        int endVerse;
        string[] ref_script = scripture.Split(')'); // split scripture at closing parentheses into reference and verse(s)
        string[] chapter_ref = ref_script[0].Split(' '); // split reference at space between book and chapter # 
        string book = chapter_ref[0].Substring(1); // remove opening parentheses from book

        string[] chapter_verse = chapter_ref[1].Split(':'); // split at ':'  to seperate chapter and verses
        int chapter = int.Parse(chapter_verse[0]); // parse the chapter number into an int
        string[] verses = chapter_verse[1].Split('-'); // split at '-' if it exists
        if(verses.Length == 1) // did we only have one verse?
        {
            startVerse = int.Parse(verses[0]); // initialize both with the same for Scripture class to handle
            endVerse = int.Parse(verses[0]);
        }
        else
        {
            startVerse = int.Parse(verses[0]); // initialize with starting and ending verses
            endVerse = int.Parse(verses[1]);
        }

        string[] words = ref_script[1].Split(' '); // split verse into words
        foreach(string word in words)
        {
            Word newWord = new Word(word);
            verse.Add(newWord);
        }
        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        return new Scripture(reference, verse);
    }
    static void Main(string[] args)
    {
        string fullScripture = "(Proverbs 3:5-6) Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture s1 = InitScripture(fullScripture);
        bool quit = false;
        string userInput;
        Console.Clear();
        while(!quit)
        {
            Console.WriteLine(s1.GetReferenceVerseStr() + '\n');
            Console.WriteLine("Press enter to hide words or type 'quit' to quit: ");
            userInput = Console.ReadLine();
            if (userInput == "")
            {
                quit = s1.HideWords();
                Console.Clear();
            }
            else if(userInput.ToLower()=="quit")
            {
                quit = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again");
            }
        }
    }
}