using System;
namespace GeoCoordinates
{
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            _Longitude = longitude;
            _Latitude = latitude;
        }

        public static Coordinate operator +(
            Coordinate source, Arc arc)
        {
            Coordinate result = new Coordinate(
                new Longitude(
                    source.Longitude + arc.LongitudeDifference),
                new Latitude(
                    source.Latitude + arc.LatitudeDifference));
            return result;
        }

        public static Coordinate operator -(
            Coordinate source, Arc arc)
        {
            Coordinate result = new Coordinate(
                new Longitude(
                    source.Longitude - arc.LongitudeDifference),
                new Latitude(
                    source.Latitude - arc.LatitudeDifference));
            return result;
        }

        public static bool operator ==(
              Coordinate leftHandSide,
              Coordinate rightHandSide)
        {

            // Sprawdzanie, czy leftHandSide to null
            // (operator== działałby rekurencyjnie)
            if (ReferenceEquals(leftHandSide, null))
            {
                // Zwraca true, jeśli rightHandSide to też null.
                // W przeciwnym razie zwraca false 
                return ReferenceEquals(rightHandSide, null);
            }

            return (leftHandSide.Equals(rightHandSide));
        }

        public static bool operator !=(
            Coordinate leftHandSide,
            Coordinate rightHandSide)
        {
            return !(leftHandSide == rightHandSide);
        }

        public override bool Equals(object obj)
        {
            // KROK 1: Sprawdzanie wartości null
            if (obj == null)
            {
                return false;
            }
            // KROK 3: Sprawdzanie, czy typy danych są te same
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Coordinate)obj);
        }

        public bool Equals(Coordinate obj)
        {
            // KROK 1. Sprawdzenie (w przypadku typów referencyjnych), 
            // czy obiekt jest różny od null.
            // if (obj == null)
            // {
            //   return false;
            // }

            // KROK 2. Sprawdzenie wyniku wywołania metody ReferenceEquals 
            // (gdy kod dotyczy typu referencyjnego).
            // if (ReferenceEquals(this, obj))
            // {
            //  return true;
            // }

            // KROK 4. Opcjonalne sprawdzenie, czy skróty są identyczne.
            // if (this.GetHashCode() != obj.GetHashCode())
            // {
            //   return false;
            // } 

            // KROK 5. Sprawdzenie wyniku wywołania base.Equals, jeśli 
            // w klasie bazowej przesłonięta jest metoda Equals().
            // System.Diagnostics.Debug.Assert(
            //   base.GetType() != typeof(object) );
            // if (!base.Equals(obj) )
            // {
            //   return false;
            // } 

            // KROK 6. Sprawdzenie, czy pola identyfikujące mają równą wartość.
            // Tu używana jest wersja metody Equals z typów Longitude i Latitude
            return ((Longitude.Equals(obj.Longitude)) &&
                (Latitude.Equals(obj.Latitude)));
        }

        // KROK 7. Przesłonięcie metody GetHashCode.
        public override int GetHashCode()
        {
            int hashCode = Longitude.GetHashCode();
            hashCode ^= Latitude.GetHashCode(); // Xor
            return hashCode;
        }

        public Longitude Longitude { get { return _Longitude; } }
        private readonly Longitude _Longitude;

        public Latitude Latitude { get { return _Latitude; } }
        private readonly Latitude _Latitude;

        public override string ToString()
        {
            return string.Format("{0}° {1}' 0 E {2}° {3}' 0 N", Longitude.Degrees, Longitude.Minutes, Latitude.Degrees, Latitude.Minutes);
        }

    }
}
