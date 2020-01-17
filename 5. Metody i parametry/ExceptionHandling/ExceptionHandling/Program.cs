using System;

class ExceptionHandling
{
    static int Main()
    {
        string firstName;
        string ageText;
        int age;
        int result = 0;

        Console.WriteLine("Hej, Ty!");

        Console.Write("Wprowadź imię: ");
        firstName = Console.ReadLine();

        Console.Write("Wprowadź wiek: ");
        ageText = Console.ReadLine();

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
            $"Hej, {firstName}! Twój wiek w miesiącach to {age * 12}.");
        }
        catch (FormatException)
        {
            Console.WriteLine(
            $"Wprowadzony wiek, {ageText}, nie jest prawidłowy.");
            result = 1;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
            $"Nieoczekiwany błąd: {exception.Message}");
            result = 1;
        }
        finally
        {
            Console.WriteLine(
            $"Żegnaj, {firstName}!");
        }
        return result;
    }
}