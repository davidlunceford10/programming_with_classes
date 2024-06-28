using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture

{

    private string _scripture;

    //This takes the scripture attribute and assigns it to the variable _scripture.
    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    //This takes the _scripture variable, splits it into an array based on spaces, converts it to a list, and returns a list comprised of the words of the scripture.
    public List<string> GetScriptureWords()
    {
        string[] wordsArray = _scripture.Split(' ');

        List<string> scriptureWordsList = new List<string>(wordsArray);

        return scriptureWordsList;
    }

    












}