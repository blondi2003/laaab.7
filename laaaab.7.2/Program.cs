class Program
{
    static void Main()
    {
        string stringNumbers = "92 33 52 86 75 12 54 96 82 65 56 20 87";

        string[] numbers = stringNumbers.Split(' ');

        var evenNumbers = numbers.Where(n => Convert.ToInt32(n) % 2 == 0);

        Console.WriteLine(evenNumbers.Count());


        Console.WriteLine();


        char[] charNumbers = stringNumbers.ToCharArray();

        int countEvenNumbers = 0;

        string tempNumber = "";

        foreach (char c in charNumbers)
        {
            if (c == ' ')
            {
                if (Convert.ToInt32(tempNumber) % 2 == 0)
                {
                    countEvenNumbers++;
                }
                tempNumber = "";
            }
            else
            {
                tempNumber += c;
            }
        }

        Console.WriteLine(countEvenNumbers);
    }
}