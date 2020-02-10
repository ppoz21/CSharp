using System;

namespace PdaItem
{
    public class Program
    {
        public static void Main()
        {
            Contact[] contacts = new Contact[]
            {
                new Contact(
                    "Jan Kowal",
                "ul. Budowlanych 12/13, Opole 45-287",
                "123-123-123"
                ),
                new Contact(
                    "Andrzej Litwin",
                    "ul. Krótka 1/23, 30-037 Kraków",
                    "555-123-456"
                ),
                new Contact(
                    "Maria Harbiel",
                    "ul. Opolska 5/7, 43-290 Wrocław",
                    "222-456-789"
                ),
                new Contact(
                    "Janusz Stoicki",
                    "ul. Liliowa 7, 25-129 Kępno",
                    "444-123-456"
                ),
                new Contact(
                    "Patrycja Frątczak",
                    "ul. Kościuszki 321, 28-092 Sochaczew",
                    "123-456-789"
                ),
                new Contact(
                    "Janina Wielgosz",
                    "ul. Majowa 9/18, 01-154 Warszawa",
                    "333-444-555"
                )
            };

            // Klasy są niejawnie rzutowane na interfejsy
            ConsoleListControl.List(Contact.Headers, contacts);

            Console.WriteLine();

            Publication[] publications = new Publication[3]
            {
                new Publication("Dyscypliny życia duchowego",
                "Richard Foster", 1978),
                new Publication("Ortodoksja",
                "G. K. Chesterton", 1908),
                new Publication(
                    "Autostopen przez galaktykę",
                    "Douglas Adams", 1979)
            };
            ConsoleListControl.List(
                Publication.Headers, publications);
        }
        public static void List(PdaItem[] items)
        {
            // Zaimplementowana z wykorzystaniem polimorfizmu. Typ pochodny
            // zna szczegóły potrzebne do zaimplementowania metody GetSummary();
            foreach (PdaItem item in items)
            {
                Console.WriteLine("__________");
                Console.WriteLine(item.GetSummary());
            }
        }
    }
}
