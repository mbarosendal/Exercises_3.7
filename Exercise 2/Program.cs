
int[] ageArray = new int[4] { 27, 28, 33, 35 };

Console.Write("Type age to look for: ");
int findAge = int.Parse(Console.ReadLine());

void FindAge()
{
    for (int i = 0; i < ageArray.Length; i++)
    {
        if (ageArray[i] == findAge)
        {
            Console.WriteLine($"Index {i}: Age {findAge} was found here." + "\n <Ending Search.>");
            break;
        }
    }

}

FindAge();

// Alternative solution with bool

//bool ageFound;
//int foundAtIndex = 0;

//void FindAge()
//{
//    for (int i = 0; i < ageArray.Length; i++)
//    {
//        if (ageArray[i] == findAge)
//        {
//            ageFound = true;
//            foundAtIndex = i;
//            break;
//        }
//    }
//}

//FindAge();

//if (ageFound = true)
//{
//    Console.WriteLine("Age was found in the array at index " + foundAtIndex);
//}

