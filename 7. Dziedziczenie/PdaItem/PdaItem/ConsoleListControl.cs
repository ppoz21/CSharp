using System;
namespace PdaItem
{
    public class ConsoleListControl
    {
        public static void List(string[] headers, IListable[] items)
        {
            int[] columnWidths = DisplayHeaders(headers);
            for (int count = 0; count < items.Length; count++)
            {
                string[] values = items[count].ColumnValues;
                DisplayItemRow(columnWidths, values);
            }
        }
        /// <summary>Wyświetla nagłówki kolumn</summary>
        /// <returns>Zwraca tablicę szerokości kolumn</returns>
        private static int[] DisplayHeaders(string[] headers)
        {
            // ..
            return 0;
        }

        private static void DisplayItemRow(
            int[] columnWidths, string[] values)
        {
            // ..
        }
    }
}
