﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace FlowNotes.Converters
{
    public class SizeToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language) => ((Windows.Foundation.Size)value).Height;

        public object ConvertBack(object value, Type targetType, object parameter, string language) => new Windows.Foundation.Size((double)value, (double)value);
    }
}
