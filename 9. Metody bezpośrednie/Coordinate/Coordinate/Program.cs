using System;

namespace Coordinate
{
    class Program
    {
        static void Main()
        {
            Coordinate coordinate1 =
                new Coordinate(new Angle(48, 52),
                               new Angle(-2, -20));
            // Obiekty typów bezpośrednich nigdy nie są równe ze względu na referencje.
            if (Coordinate.ReferenceEquals(coordinate1,
                coordinate1))
            {
                throw new Exception(
                    "coordinate1 jest równa ze względu na referencje z coordinate1");
            }
            Console.WriteLine(
                "coordinate1 NIE jest równa ze względu na referencje z samym sobą!");
        }
    }
}
