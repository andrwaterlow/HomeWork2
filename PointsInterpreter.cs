using System;

namespace Assets.Scripts
{
    internal sealed class PointsInterpreter
    {
        public string Interpret(string value)
        {
            if (Int32.TryParse(value, out var point))
            {
                return toKFormat(point);
            }
            throw new ArgumentException(nameof(value));
        }

        public string toKFormat(int point)
        {
            if ((point < 0) || (point > 1000000000)) 
                throw new ArgumentOutOfRangeException(nameof(point),
                    "inposible value");

            if (point >= 1000000) return Convert.ToString(
                (point / 1000000)) + "M";

            if (point >= 1000) return Convert.ToString(
                (point / 1000)) + "K";

            if (point < 1000) return string.Empty;

            throw new ArgumentOutOfRangeException(nameof(point));
        }
    }
}
