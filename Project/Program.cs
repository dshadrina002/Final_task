static void ShortenStringArray(string[] inputArray)
{
    int n = inputArray.Length;
    string[] outputArray = new string[n];
    int outputIndex = 0;

    for (int i = 0; i < n; i++)
    {
        string str = inputArray[i];
        if (str.Length <= 3)
        {
            outputArray[outputIndex++] = str;
        }
    }

    Array.Resize(ref outputArray, outputIndex);
    Console.WriteLine(string.Join(", ", outputArray));
}

string[] inputArray1 = { "hello", "2", "world", ":-)" };
ShortenStringArray(inputArray1);
string[] inputArray2 = { "1234", "1567", "-2", "computer science" };
ShortenStringArray(inputArray2);
string[] inputArray3 = { "Russia", "Denmark", "Kazan" };
ShortenStringArray(inputArray3);