using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john15_13 = new Reference("John", 15, 13);
        Word word1 = new Word("Greater");
        Word word2 = new Word("love");
        Word word3 = new Word("hath");
        Word word4 = new Word("no");
        Word word5 = new Word("man");
        Word word6 = new Word("than");
        Word word7 = new Word("this");
        Word word8 = new Word(",");
        Word wordc = new Word("that");
        Word word9 = new Word("a");
        Word word10 = new Word("man");
        Word word11 = new Word("lay");
        Word word12 = new Word("down");
        Word word13 = new Word("his");
        Word word14 = new Word("life");
        Word word15 = new Word("for");
        Word word16 = new Word("his");
        Word word17 = new Word("friends");
        Word word18 = new Word(".");
        Scripture scripture = new Scripture(john15_13, new List<Word> { word1, word2, word3, word4, word5, word6, word7, word8, wordc, word9, word10, word11, word12, word13, word14, word15, word16, word17, word18 });
        

        while (true)
        {
            scripture.GetScriptureText();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\n\nAll words are hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("\n\nPress enter to hide words, type 'quit' to exit.");
            string input = Console.ReadLine();
            scripture.HideWords();
            

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            
            
            
        }

    }
}