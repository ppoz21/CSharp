using System;

namespace GeoCoordinates
{
    public struct Arc
    {
        public Arc(
            Longitude longitudeDifference,
            Latitude latitudeDifference)
        {
            _LongitudeDifference = longitudeDifference;
            _LatitudeDifference = latitudeDifference;
        }

        public Longitude LongitudeDifference
        {
            get
            {
                return _LongitudeDifference;
            }
        }
        private readonly Longitude _LongitudeDifference;

        public Latitude LatitudeDifference
        {
            get
            {
                return _LatitudeDifference;
            }
        }
        private readonly Latitude _LatitudeDifference;

        public static Arc operator -(Arc arc)
        {
            // Wykorzystano tu jednoargumentowy operator — zdefiniowany
            // w typach Longitude i Latitude.
            return new Arc(-arc.LongitudeDifference,
                -arc.LatitudeDifference);
        }

        public static Arc operator +(Arc arc)
        {
            return arc;
        }
    }
}
