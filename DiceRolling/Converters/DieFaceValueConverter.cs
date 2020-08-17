using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using DiceRolling.Enums;

namespace DiceRolling.Converters
{
    class DieFaceValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dieFaceValue = value as int? ?? 0;
            var mode = parameter as DieFaceViewMode? ?? DieFaceViewMode.Numbers;
            switch (mode)
            {
                case DieFaceViewMode.Dots:
                    return string.Empty;
                case DieFaceViewMode.Numbers:
                    return System.Convert.ToString(dieFaceValue);
                case DieFaceViewMode.RomanNumerals:
                    if (dieFaceValue < 0 || dieFaceValue > 6)
                        return System.Convert.ToString(dieFaceValue);
                    return new[] {"I", "II", "III", "IV", "V", "VI"}[dieFaceValue - 1];
                default:
                    return System.Convert.ToString(dieFaceValue);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // not used here
            throw new NotImplementedException();
        }
    }
}
