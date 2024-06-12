class Program
{

// int userAge = -10;

// while (userAge < 0 || userAge > 120)
// {
//     Console.WriteLine("Please input your age (0-120) ");
//     userAge = int.Parse(Console.ReadLine());

// }

// do 
// {
//     Console.WriteLine('Please input your age (0-120)');
// } while (userAge < 0 || userAge > 120);


// // For loop
// for(int i = 0; i < 100; i+= 10) //for i in range 100, every 10th number
// {
//     Console.WriteLine("" + i);
// }

//declare a list

List<int> myNumbers = new List<int>();
List<string> myNames = new List<string>();

myNames.Add("Bob");
myNames.Add("Billy");
myNames.Add("Betty");

foreach(string name in myNames)
{
    Console.WriteLine("" + name);
}

myNumbers.Add(12);

foreach(string name in myNames)

}