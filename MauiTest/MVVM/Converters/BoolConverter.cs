﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.MVVM.Converters
{
    public class BoolConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameterm , CultureInfo culture) {
            var boolValue = (bool)value;
            if (boolValue)
            {
                return "Sí";
            }
            return "No";
        }

        public object ConvertBack(object value, Type targetType, object parameterm, CultureInfo culture)
        {
            var stringValue = (string)value;
            if (stringValue == "Sí")
            {
                return true;
            }
            return false;
        }
    }
}
