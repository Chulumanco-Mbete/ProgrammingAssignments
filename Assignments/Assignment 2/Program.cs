namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumberToWords numberToWords = new NumberToWords();
            Console.WriteLine("Enter a number to convert to words: ");
            string number = Console.ReadLine();
            number = NumberToWords.NumbersToWords(int.Parse(number));

            Console.WriteLine("Number in words is: \n{0}", number);
            Console.ReadKey();
        }
    }
}
