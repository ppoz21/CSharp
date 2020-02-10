using System;
namespace Coordinate
{
    // Deklaracja klasy, czyli typu referencyjnego
    // Użycie w deklaracji słowa kluczowego struct spowodowałoby
    // powstanie typu bezpośredniego zajmującego więcej niż 16 bajtów.
    class Coordinate
    {
        public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }
    }
}
