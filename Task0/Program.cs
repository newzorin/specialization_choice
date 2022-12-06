void ArrayMin3(string []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
           Console.Write(array[i] + " ");
        }
    }
}

string[] array1 = new string[] { "зеленый", "три", "3?", "ывнтпм", "fr" };
ArrayMin3(array1);


