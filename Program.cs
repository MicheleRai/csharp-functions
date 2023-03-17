int[] numbers = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Array originale: ");

printArray(numbers);

Console.WriteLine("Array al quadrato: ");

printArray(ElevaArrayAlQuadrato(numbers));

Console.WriteLine("Array originale: ");

printArray(numbers);

Console.WriteLine("Somma array originale: ");

Console.WriteLine(sommaElementiArray(numbers));

Console.WriteLine("Somma array originale con numeri al quadrato");

Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numbers)));

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