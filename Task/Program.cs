string[] arr1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arr2 = new string[arr1.Length];

void new_array(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if (arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.Write("]");
        Console.WriteLine();
}
new_array(arr1, arr2);
PrintArray(arr2);