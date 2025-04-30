

static void Main()
{
    Console.WriteLine("Input the number of elements to be store in the array: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];

    Console.WriteLine("Input [n] elements in the array: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("element - {i} : ");
    }

    Dictionary<int, int> frequency = new Dictionary<int, int>();

    foreach (int num in array)
    {
        if (frequency.ContainsKey(num))
        {
            frequency[num]++;
        }
        else
        {
            frequency[num] = 1;
        }
    }
    Console.WriteLine("Frequency of all elements of the array:");
    foreach (var kvp in frequency)
    {
    
    }
}   

