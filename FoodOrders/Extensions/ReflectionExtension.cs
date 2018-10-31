using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrders.Extensions
{
    public static class ReflectionExtension
    {
        public static string GetPropertyValue<T>(this T item,string propertName)
        {
            return item.GetType().GetProperty(propertName).GetValue(item, null).ToString();
        }
    }
}
