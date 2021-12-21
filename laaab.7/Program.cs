class Program
{
    static void Main()
    {
        string text = "Hello world!";

        var charTextLinq = text.Select(x => (x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z') ? '+' : x);

        foreach (char c in charTextLinq)
        {
            Console.Write(c);
        }

        Console.WriteLine();

        char[] charText = text.ToCharArray();

        for (int i = 0; i < charText.Length; i++)
        {
            if ((charText[i] >= 'a' && charText[i] <= 'z') || (charText[i] >= 'A' && charText[i] <= 'Z'))
            {
                charText[i] = '+';
            }
        }

        foreach (char c in charText)
        {
            Console.Write(c);
        }
    }
}
