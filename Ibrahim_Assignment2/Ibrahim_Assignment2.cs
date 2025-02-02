namespace Ibrahim_Assignment2
{
    internal class Ibrahim_Assignment2
    {
        static void Main(string[] args)
        {
            //Asks user for a decimal number input to be truncated
            Console.Write("Enter a decimal number: ");
            double myNum = Convert.ToDouble(Console.ReadLine());

            //Truncates the number to an integer
            Console.WriteLine("The number truncated into an integer: " + Math.Truncate(myNum));

            //Truncates the number to the hundredths place (the number of zero after 1 indicates the place)
            Console.WriteLine("The number truncated to the hundredths place: " + (Math.Truncate(myNum * 100) / 100));
        }
    }
}
