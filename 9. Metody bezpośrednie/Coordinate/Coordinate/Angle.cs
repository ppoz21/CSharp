using System;
namespace Coordinate
{
    // Do deklarowania typów bezpośrednich służy słowo kluczowe struct.
    struct Angle
    {
        public Angle(int degrees)
            : this(degrees, default)
        {
        }
        public Angle(int degrees, int minutes)
            : this(degrees, minutes, default)
        {
        }
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        // używanie przeznaczonych tylko do odczytu i automatycznie imoplementowanych
        // właściwości z języka C# 6.0
        public int Degrees { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Angle Move(int degrees, int minutes, int seconds)
        {
            return new Angle(
                Degrees + degrees,
                Minutes + minutes,
                Seconds + seconds);
        }
    }
}
