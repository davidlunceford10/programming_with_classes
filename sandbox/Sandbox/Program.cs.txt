using System;

class Program 
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Bob", "Billy", 24, 210);
        Console.WriteLine(person1.PersonInformation());
        Fireman fireman = new Fireman("EMT and Parametic", "Billiam", "Martin", 24, 210);
        Console.WriteLine(fireman.FiremanInformation());
    
    }
}


