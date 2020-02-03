using System;
using System.IO;

class DataStorage
{
    // Zapisywanie obiektu employee w pliku
    // o nazwie odpowiadającej imieniu i nazwisku pracownika.
    // Kod do obsługi błędów został pominięty.
    public static void Store(Employee employee)
    {
        // Tworzenie obiektu typu FileStream z nazwą pliku
        // FirstNameLastName.dat. Parametr FileMode.Create powoduje
        // utworzenie nowego pliku lub zastąpienie wartości istniejącego.
        FileStream stream = new FileStream(
            employee.FirstName + employee.LastName + ".dat",
            FileMode.Create);

        // Tworzenie obiektu typu StreamWriter na potrzeby zapisu
        // tekstu w obiekcie FileStream
        StreamWriter writer = new StreamWriter(stream);

        // Zapis wszystkich danych dotyczących pracownika
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);

        // Zamyka obiekt typu StreamWriter i powiązany z nim strumień.
        writer.Dispose(); // Automatycznie zamyka strumień
    }

    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new Employee();
        // Tworzenie obiektu typu FileStream dla pliku o nazwie
        // FirstNameLastName.dat Parametr FileMode.Open powoduje
        // otwarcie istniejącego pliku lub zgłoszenie błędu
        FileStream stream = new FileStream(
            firstName + lastName + ".dat", FileMode.Open);

        // Tworzenie obiektu StreamReader przeznaczonego do odczytu tekstu z pliku
        StreamReader reader = new StreamReader(stream);

        // Wczytywanie każdego wiersza z pliku i zapisywanie
        // w danych w odpowiedniej właściwości.
        employee.FirstName = reader.ReadLine();
        employee.LastName = reader.ReadLine();
        employee.Salary = reader.ReadLine();

        // Zamykanie obiektu typu StreamReader i powiązanego z nim strumienia
        reader.Dispose(); // Automatycznie zamyka strumień

        return employee;
    }
}
