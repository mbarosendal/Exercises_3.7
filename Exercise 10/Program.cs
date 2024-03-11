int[] ageArray = new int[4];
ageArray[0] = 27;
ageArray[1] = 28;
ageArray[2] = 33;
ageArray[3] = 35;
int sumOfAges = 0;

// Print the ages of the array
foreach (int age in ageArray)
    Console.WriteLine(age);

// Find sum of the ages of the array
for (int i = 0; i < ageArray.Length; i++)
{
    sumOfAges += ageArray[i];
}

Console.WriteLine("The average age is: " + (sumOfAges / 4));

// Exercise 1.2.1 - Alternative Array Declaration
//int[] ageArray = new int[4] {27, 28, 33, 35};
