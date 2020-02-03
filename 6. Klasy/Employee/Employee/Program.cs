using System;

class Program
{
    static void Main()
    {
        Employee employee1;

        Employee employee2 = new Employee();
        employee2.SetName("Janusz", "Nosacz");
        employee2.Save();

        // Modyfikowanie obiektu employee2 po jego zapisaniu.
        IncreaseSalary(employee2);

        // Wczytywanie danych do ebiektu employee1 z zapisanej wersji obiektu employee2.
        employee1 = DataStorage.Load("Janusz", "Nosacz");

        Console.WriteLine(
            $"{employee1.GetName()}: {employee1.Salary}");
    }

    static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "Wystarczające, by przeżyć";
    }
}