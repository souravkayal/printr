using Newtonsoft.Json;
using System.Collections;

namespace Printmaster
{
    public static class Printr
    {
        /// <summary>
        /// Prints one or more objects to the console, mimicking Python's print().
        /// </summary>
        /// <param name="args">Objects to print</param>
        public static void Print(params object[] args)
        {
            string output = string.Join(" ", Array.ConvertAll(args, FormatObject));
            Console.WriteLine(output);
        }

        private static string FormatObject(object obj)
        {
            if (obj == null) return "null";
            if (obj is string s) return s;
            if (obj is Array arr) return FormatArray(arr); // ✅ Handle multi-dimensional arrays first
            if (obj is IEnumerable enumerable && !(obj is string)) return FormatEnumerable(enumerable);

            try { return JsonConvert.SerializeObject(obj, Formatting.None); }
            catch { return obj.ToString(); }
        }

        private static string FormatEnumerable(IEnumerable enumerable)
        {
            var items = new List<string>();
            foreach (var item in enumerable)
            {
                items.Add(FormatObject(item));
            }

            return "[ " + string.Join(", ", items) + " ]";
        }

        // Special method to format N-dimensional arrays
        private static string FormatArray(Array array)
        {
            if (array.Rank == 1) return FormatEnumerable(array);
            return FormatMultidimensionalArray(array, new int[array.Rank], 0);
        }

        private static string FormatMultidimensionalArray(Array array, int[] indices, int dimension)
        {
            int length = array.GetLength(dimension);
            List<string> parts = new();

            for (int i = 0; i < length; i++)
            {
                indices[dimension] = i;
                if (dimension == array.Rank - 1)
                {
                    parts.Add(FormatObject(array.GetValue(indices)));
                }
                else
                {
                    parts.Add(FormatMultidimensionalArray(array, indices, dimension + 1));
                }
            }

            return "[ " + string.Join(", ", parts) + " ]";
        }
    }
}

