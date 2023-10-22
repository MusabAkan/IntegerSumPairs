 class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir dizi sayıyı boşlukla ayırarak girin:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');

        List<int> pairs = new();

        for (int i = default(int); i < numbers.Length; i += 2)
        {
            int num1 = int.Parse(numbers[i]);
            int num2 = int.Parse(numbers[i + 1]);
            if (num1 != num2)
                pairs.Add(num1 + num2);
            else
                pairs.Add(num1 * num2);
        }

        Console.WriteLine("Sonuç:");
        foreach (int pair in pairs)
            Console.Write(pair + " ");
    }
}