using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace ClinicApp.XamlPages
{
    public class DateBirthToAgeConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dateOfBirth = (DateTime)value;
            DateTime todayDateTime = DateTime.Today;
            int age = todayDateTime.Year - dateOfBirth.Year;
            if (todayDateTime.Month < dateOfBirth.Month || (todayDateTime.Month == dateOfBirth.Month && todayDateTime.Day < dateOfBirth.Day))
            {
                age--;
            }
            return age;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }

    }
}
