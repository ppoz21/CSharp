using System;
namespace GeoCoordinates
{
    public struct Latitude
    {
        public Latitude(int degrees, int minutes)
        {
            _Degrees = degrees;
            _Minutes = minutes;
        }

        public Latitude(int degrees)
            : this(degrees, 0) { }

        public Latitude(Latitude Latitude)
            : this(Latitude.Degrees, Latitude.Minutes) { }

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
        public static Latitude operator -(Latitude latitude)
        {
            return new Latitude(-latitude.Degrees);
        }

        public static Latitude operator +(Latitude latitude)
        {
            return latitude;
        }
        // ----

        public static Latitude operator +(Latitude leftHandSide, Latitude rightHandSide)
        {
            return new Latitude(leftHandSide.Degrees + rightHandSide.Degrees, leftHandSide.Minutes + rightHandSide.Minutes);
        }

        public static Latitude operator -(Latitude leftHandSide, Latitude rightHandSide)
        {
            return new Latitude(leftHandSide.Degrees - rightHandSide.Degrees, leftHandSide.Minutes - rightHandSide.Minutes);
        }
    }
}
