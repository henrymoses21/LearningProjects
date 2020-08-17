using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using DiceRolling.Enums;

namespace DiceRolling.Converters
{
    class BooleanToDieFaceViewModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // note that this only works with two view modes.
            // we will fix this, but we'll need to change from using a checkbox.

            var boolVal = (bool?) value ?? false;
            return boolVal ? DieFaceViewMode.Numbers : DieFaceViewMode.Dots;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // not used.
            throw new NotImplementedException();
        }
    }

    public class DebugDummyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }
    }
}
