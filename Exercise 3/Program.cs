
using System.ComponentModel;

try
{
    Console.Write("How many people are there? ");
    // int numOfPeople = int.Parse(Console.ReadLine());
    // Exercise 1.4.2 - Alternative with TryParse
    if (!int.TryParse(Console.ReadLine(), out int numOfPeople));
        throw new FormatException();

    int[] ageOfPeople = new int[numOfPeople];
    string[] namesOfPeople = new string[numOfPeople];
    string[] ordinals = new string[3] { "1st", "2nd", "3rd" };

    FillArrays(numOfPeople, namesOfPeople, ageOfPeople, ordinals);

    for (int i = 0; i < numOfPeople; i++)
        Console.WriteLine(namesOfPeople[i] + " is " + ageOfPeople[i] + "years old.");
}
catch (FormatException e) 
{
    Console.WriteLine("You didn't enter a valid number: \n\n {0}.", e);
}

void FillArrays(int numOfPeople, string[] namesOfPeople, int[] ageOfPeople, string[] ordinals)
{    
    for (int i = 0; i < numOfPeople; i++)
    {
        Console.WriteLine("What is the name of the {0} person?", i < 3 ? ordinals[i] : $"{i + 1}th");
        string name = Console.ReadLine();
        namesOfPeople[i] = name ?? "<Not Specified>";

        Console.WriteLine($"How old is {namesOfPeople[i]}?");
        int age = int.Parse(Console.ReadLine());
        ageOfPeople[i] = age;
    }
}





