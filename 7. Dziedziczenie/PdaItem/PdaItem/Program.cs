using System;

namespace PdaItem
{
    public class Program
    {
        public static void Main()
        {
            PdaItem[] pda = new PdaItem[3];

            Contact contact = new Contact("Janusz Nosacz");
            contact.Address = "Ćwiartki 3/4, Wrocław, Polska";
            pda[0] = contact;

            Appointment appointment =
                new Appointment("Melanż z okazji urodzin Admina");
            appointment.StartDateTime = new DateTime(2020, 2, 6);
            appointment.EndDateTime = new DateTime(2020, 2, 7);
            appointment.Location = "Deja Vu Pub & Cafe";
            pda[1] = appointment;

            contact = new Contact("Ferdynand Kiepski");
            contact.Address =
                "Ćwiartki 1/2, Wrocław, Polska";
            pda[2] = contact;

            List(pda);
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
