class CircleAreaCalculator
{
    static void Main()
    {
        double radious; // Deklaracja zmiennej przechowującej promień
        double area; // deklaracja zmiennej przechowującej powierzchnię

        System.Console.Write("Wprowadź promień koła: ");

        // instrukcja double.Parse() przekształca wartość zwróconą
        // przez polecenie ReadLine() na typ double
        radious = double.Parse(System.Console.ReadLine());

        if (radious >= 0)
        {
            // Obliczenie powierzchni koła
            area = System.Math.PI * radious * radious;
            System.Console.WriteLine(
                $"Powierzchnia koła wynosi: {area: 0.00}");
        }
        else
        {
            System.Console.WriteLine(
                $"{radious} nie jest poprawną wartoscią promienia.");
        }
    }
}