class HeyYou
{
    static void Main()
    {
        string firstName; //zmienna do przechowywania imienia
        string lastName; //zmienna do przechowywania nazwiska

        System.Console.WriteLine("Hej, ty!");

        System.Console.Write/* bez nowego wiersza */("Podaj imię: "); 
        firstName = System.Console.ReadLine();

        System.Console.Write/* bez nowego wiersza */("Podaj nazwisko: "); 
        lastName = System.Console.ReadLine();

        /*
            Wyświetlanie powitania w konsoli z wykorzystaniem znaków formatowania
         */

        System.Console.WriteLine(
            $"Twoje imię i nazwisko to { firstName } { lastName }.");

        //koniec programu
    }
}