using System;
namespace GeoCoordinates
{
    public struct Longitude
    {
        public Longitude(int degrees, int minutes)
        {
            _Degrees = degrees;
            _Minutes = minutes;
        }

        public Longitude(int degrees)
            : this(degrees, 0) { }

        public Longitude(Longitude longitude)
            : this(longitude.Degrees, longitude.Minutes) { }


        public int Degrees
        {
            get { return _Degrees; }
            set { _Degrees = value; }
        }
        private int _Degrees;

        public int Minutes
        {
            get { return _Minutes; }
            set { _Minutes = value; }
        }
        private int _Minutes;

        // JEDNOARGUMENTOWY
        public static Longitude operator -(Longitude longitude)
        {
            return new Longitude(-longitude.Degrees);
        }

        public static Longitude operator +(Longitude longitude)
        {
            return longitude;
        }
        // ----

        public static Longitude operator +(Longitude leftHandSide, Longitude rightHandSide)
        {
            return new Longitude(leftHandSide.Degrees + rightHandSide.Degrees, leftHandSide.Minutes + rightHandSide.Minutes);
        }

        public static Longitude operator -(Longitude leftHandSide, Longitude rightHandSide)
        {
            return new Longitude(leftHandSide.Degrees - rightHandSide.Degrees, leftHandSide.Minutes - rightHandSide.Minutes);
        }
    }
}
