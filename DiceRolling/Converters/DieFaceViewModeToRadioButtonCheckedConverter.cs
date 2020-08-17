using System;
using System.Globalization;
using System.Windows.Data;
using DiceRolling.Enums;

namespace DiceRolling.Converters
{
    class DieFaceViewModeToRadioButtonCheckedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var targetMode = parameter as DieFaceViewMode? ?? null;
            var currentMode = value as DieFaceViewMode? ?? DieFaceViewMode.Numbers;
            return targetMode == currentMode;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = ((bool?)value ?? false) ? parameter : null;
            return type;
        }
    }
}
