using System;

namespace KeepHydratedKata
{
    internal class Calculator
    {
        public const double timeToLitreConversionUnit = 0.5;
        public static int ConvertTimeCycledToLitresDrank(double hoursCycled)
        {
            var result = hoursCycled * timeToLitreConversionUnit;
            return Convert.ToInt32(Math.Floor(result));
        }
    }
}