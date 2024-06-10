using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiot.Common
{
    public static class Extensions
    {
        /// <summary>
        /// Рандомно перемешивает элементы текущей коллекции
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> array)
        {
            var List = array.ToList();

            for (int i = 0; i < List.Count; i++)
            {
                var randomIndex = new Random().Next(0, List.Count - 1);
                (List[i], List[randomIndex]) = (List[randomIndex], List[i]);
            }

            return List;
        }
        public static string NullIfEmpty(this string value)
        {
            if (value == string.Empty) return null;
            return value;
        }
    }
}
