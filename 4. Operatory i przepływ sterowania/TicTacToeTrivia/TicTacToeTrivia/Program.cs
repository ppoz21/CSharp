class TicTacToeTrivia
{
    static void Main()
    {
        int input; //Deklaracja zmiennej, w której zapisywane są dane wejściowe.

        System.Console.Write(
            "Jaka jest maksymalna liczba ruchów " +
            "w grze w kółko i krzyżyk?" +
            "(Wpisz 0, aby zakończyć): ");

        // Instrukcja int.Parse() przekształca wartość
        // zwróconą przez ReadLine() na typ int
        input = int.Parse(System.Console.ReadLine());

        if (input <= 0)
            // Zmienna input ma wartość 0 lub mniejszą
            System.Console.WriteLine("Zamykanie programu...");
        else
            if (input < 9)
                // Zmienna input ma wartość mniejszą niż 9
                System.Console.WriteLine(
                    $"Maksymalna liczba ruchów w grze w kółko i krzyżyk " +
                    $"jest większa niż {input}");
            else
                if (input > 9)
                    // Zmienna input ma wartość większą niż 9
                    System.Console.WriteLine(
                    $"Maksymalna liczba ruchów w grze w kółko i krzyżyk " +
                    $"jest mniejsza niż {input}");
                else
                    // Zmienna input ma wartość 9
                    System.Console.WriteLine(
                    $"Dobrze, maksymalna liczba ruchów w grze w kółko i krzyżyk " +
                    $"wynosi 9");
    }
}