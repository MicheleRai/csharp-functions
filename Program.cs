
using System.Collections;

programma(componiArray());

void programma(int[] numbers)
{
    Console.WriteLine("Array creato da te: ");

    printArray(numbers);

    Console.WriteLine("Array al quadrato: ");

    printArray(ElevaArrayAlQuadrato(numbers));

    Console.WriteLine("Array creato da te: ");

    printArray(numbers);

    Console.WriteLine("Somma array creato da te: ");

    Console.WriteLine(sommaElementiArray(numbers));

    Console.WriteLine("Somma array creato da te con numeri al quadrato");

    Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numbers)));

    printArray(numbers);

    Console.WriteLine(printaPiuPiccolo(numbers));


}

int[] componiArray()
{
    Console.WriteLine("Quanto vuoi che sia lungo l'array lungo l'array?");
    int[] nums = new int[Convert.ToInt32(Console.ReadLine())];
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine($"immetti il numero in  posizione {i}:");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    return nums;
}


void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

int Quadrato(int num)
{
    var result = num * num;

    return result;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] quadratoArray = new int[array.Length];
    for (int i = 0;i < array.Length; i++)
    {
        quadratoArray[i] = Quadrato(array[i]);
    }

    return quadratoArray;
}

int sommaElementiArray(int[] array)
{
    var sum = 0;

    foreach (var item in array)
    {
        sum += item;
    }
    return sum;
}

//superbonus
int printaPiuPiccolo(int[] array)
{
    var piccolo = 0;
    Array.Sort(array);

    return piccolo = array[0];
 
}