﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace BCL.Configuration.Converters
{
    [TypeConverter(typeof(CultureInfoTypeConverter))]
    public class CultureInfoTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context,
            Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context,
         CultureInfo culture, object value)
        {
            if (value is string)
            {
                return new CultureInfo(value.ToString());
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
