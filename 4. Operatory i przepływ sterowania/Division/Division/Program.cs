class Division
{
    static void Main()
	{
        int numerator, denominator, quotient, remainder;

        System.Console.Write("Wprowadź licznik: ");
        numerator = int.Parse(System.Console.ReadLine());

        System.Console.Write("Wprowadź mianownik: ");
        denominator = int.Parse(System.Console.ReadLine());

        quotient = numerator / denominator;
        remainder = numerator % denominator;

        System.Console.WriteLine(
            $"{numerator} / {denominator} = {quotient} reszta {remainder}");
	}
}