using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        string _userInput = "";

        Scripture scripture1 = new Scripture("For intelligence cleaveth unto intelligence; wisdom receiveth wisdom; truth embraceth truth; virtue loveth virtue; light cleaveth unto light; mercy hath compassion on mercy and claimeth her own; justice continueth its course and claimeth its own; judgment goeth before the face of him who sitteth upon the throne and governeth and executeth all things.\n He comprehendeth all things, and all things are before him, and all things are round about him; and he is above all things, and in all things, and is through all things, and is round about all things; and all things are by him, and of him, even God, forever and ever.");
        
        Reference reference1 = new Reference("D&C 88:40-41 ");

        List<string> scriptureWords = scripture1.GetScriptureWords();

        Random _random = new Random();

        while (_userInput != "quit")
        {   
            
            reference1.DisplayReference();

            foreach (string word in scriptureWords)
            {
                Console.Write($"{word} ");
            }

            Word.ReplaceRandomWordsWithUnderscores(scriptureWords, 5, _random);

            Console.WriteLine(); 

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
                 
            _userInput = Console.ReadLine();

            Console.Clear();

            if (scriptureWords.TrueForAll(w => w.All(c => c == '_')))
            {
                break;
            }
        }
    }
}

//ChatGPT was used in this program. Explanations have been provided as needed.