using System;
namespace PdaItem
{
    public class Publication : IListable
    {
        public Publication(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public string[] ColumnValues
        {
            get
            {
                return new string[]
                {
                    Title,
                    Author,
                    Year.ToString()
                };
                
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[]
                {
                    "Tytuł                                      ",
                    "Autor              ",
                    "Rok         "
                };
            }
        }
    }
    // ...
}
