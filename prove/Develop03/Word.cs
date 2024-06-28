using System.Runtime.CompilerServices;

public class Word
{
    
    //This method takes a list of strings that contain the words of the scripture, the number of words to replace with underscores, and an instance of the random class to generate random numbers. 
    public static void ReplaceRandomWordsWithUnderscores(List<string> words, int count, Random random)
    {
        //Starts a counter to keep track of how many words have been replaced so far.
        int replaced = 0;

        //Creates a HashSet to store the indicies of the words that already have been replaced, while making sure that each index is unique. 
        HashSet<int> usedIndices = new HashSet<int>();

        //This loop continues until the set number of words specified in 'int count' have been replaced or all the words in the list have been replaced. 
        while (replaced < count && usedIndices.Count < words.Count)
        {
            //This generates a random index within the bounds of the wordcount
            int randomIndex = random.Next(words.Count);

            //This genius piece of code uses the NOT operater to make sure that the index and its word haven't been hidden yet or have any underscores, and if the word hasn't been hidden it will replace the word's letters with underscores.
            if (!usedIndices.Contains(randomIndex) && words[randomIndex].Any(c => c != '_'))
            {
                words[randomIndex] = new string('_', words[randomIndex].Length);
                usedIndices.Add(randomIndex);
                replaced++;
            }
        }
    }
    
    
    
    


}