using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using DiceRolling.Enums;

namespace DiceRolling.Converters
{
    class DieFaceViewModeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var targetViewMode = parameter as DieFaceViewMode? ?? DieFaceViewMode.Dots;
            var viewMode = value as DieFaceViewMode?;
            return viewMode == targetViewMode ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // not used in this case
            throw new NotImplementedException();
        }
    }
}
