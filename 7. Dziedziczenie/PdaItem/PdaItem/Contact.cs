using System;
using System.IO;
using static System.Environment;

namespace PdaItem
{
    public class Contact : PdaItem, IListable, IComparable
    {
        public Contact(string name, string address, string phone) :
            base(name)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public override string Name
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
            set
            {
                string[] names = value.Split(' ');
                // obsługę błędów pominięto
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public override string GetSummary()
        {
            return $"FirstName: { FirstName + NewLine }"
                + $"LastName: { LastName + NewLine }"
                + $"Address: {Address + NewLine }";
        }

        public string[] ColumnValues
        {
            get
            {
                return new string[]
                {
                    FirstName,
                    LastName,
                    Phone,
                    Address
                };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[] {
                    "Imię    ", " Nazwisko       ",
                    "Telefon     ",
                    "Adres                       "};
            }
        }
        #region IComparable Members
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Mniej niż zero - dana instancja ma wartość mneijszą niż obj
        /// Zero - dana instancja ma wartość równą obj
        /// Więcej niż zero - dana instancja ma wartość większą niż obj
        /// </returns>
        public int CompareTo(object obj)
        {
            int result;

            Contact contact = obj as Contact;

            if (obj == null)
            {
                // Dana instancja ma wartość większą niż obj.
                result = 1;
            }
            else if (obj.GetType() != typeof(Contact))
            {
                // Użycie w komunikacie operatora nameof z C# 6.0, aby
                // zapewnić spójność nazwy typu.
                throw new ArgumentException(
                    $"Parametr nie jest typu { nameof(Contact) }",
                    nameof(obj));
            }
            else if (Contact.ReferenceEquals(this, obj))
            {
                result = 0;
            }
            else
            {
                result = LastName.CompareTo(contact.LastName);
                if (result == 0)
                {
                    result = FirstName.CompareTo(contact.FirstName);
                }
            }
            return result;
        }
        #endregion

        #region Składowe interfejsu IListable
        string[] IListable.ColumnValues
        {
            get
            {
                return new string[]
                {
                    FirstName,
                    LastName,
                    Phone,
                    Address
                };
            }
        }
        #endregion
    }
}
