

Console.Write("How many people are there? ");
int numOfPeople = int.Parse(Console.ReadLine());

int[] ageOfPeople = new int[numOfPeople];
string[] namesOfPeople = new string[numOfPeople];
string[] ordinals = new string[3] {"1st", "2nd", "3rd" };

// Fill two arrays with values corresponding to the name and age of a person, so that e.g. index 0 in both relate to the same person
for (int i = 0; i < numOfPeople; i++)
{
    Console.WriteLine("What is the name of the {0} person?", i <= 3 ? ordinals[i]: i + "th");
    string name = Console.ReadLine();
    namesOfPeople[i] = name ?? "<Not Specified>";

    for (int j = 0; j < numOfPeople; j++)
    {
        Console.WriteLine($"How old is {namesOfPeople[i]}?");
        int age = int.Parse(Console.ReadLine());
        ageOfPeople[i] = age;
        break;
    }
}

for (int i = 0; i < numOfPeople; i++)
    Console.WriteLine(namesOfPeople[i] + " is " + ageOfPeople[i] + "years old.");



