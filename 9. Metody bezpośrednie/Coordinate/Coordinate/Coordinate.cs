using System;
namespace Coordinate
{
    public struct Coordinate
    {
        public Coordinate(Angle longitude, Angle latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Angle Longitude { get; }
        public Angle Latitude { get; }

        public override string ToString()
        {
            return $"{ Longitude } { Latitude }";
        }

        public override int GetHashCode()
        {
            int hashCode = Longitude.GetHashCode();
            // Powtarzanie operacji, dopóki skróty nie przyjmą równych wartości
            if (Longitude.GetHashCode() != Latitude.GetHashCode())
            {
                hashCode ^= Latitude.GetHashCode(); // Operacja XOR
            }
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            // KROK 1. Sprawdzanie, czy obiekt jest różny od null
            if (obj == null)
            {
                return false;
            }
            // KROK 3. Sprawdzenie czy typy pasują do siebie
            // Można pominąć ten krok, jeśli typ jest zamknięty
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Coordinate)obj);
        }
    }
}
