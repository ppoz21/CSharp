using System;

class Employee
{
    /*private string FirstName;

    // Getter dla pola FirstName
    public string GetFirstName()
    {
        return FirstName;
    }

    // Setter dla pola FirstName
    public void SetFirstName(string newFirstName)
    {
        if (newFirstName != null && newFirstName != "")
        {
            FirstName = newFirstName;
        }
    }*/

    // Właściwości FirstName
    public string FirstName
    {
        get
        {
            return _FirstName;
        }
        set
        {
            _FirstName = value;
        }
    }
    private string _FirstName;

    //private string LastName;

    // Getter dla pola LastName
    /*public string GetLastName()
    {
        return LastName;
    }

    // Setter dla pola LastName
    public void SetLastName(string newLastName)
    {
        if (newLastName != null && newLastName != "")
        {
            LastName = newLastName;
        }
    }*/

    public void Initialize(
        string newFirstName, string newLastName)
    {
        // Używanie właściwości także wewnątrz
        // klasy Employee
        FirstName = newFirstName;
        LastName = newLastName;
    }


    public string LastName
    {
        get => _LastName;
        set
        {
            // Sprawdzanie poprawności w trakcie przypisywania wartości włąściwości LastName
            if (value == null)
            {
                // Zgłaszanie błędu
                throw new ArgumentNullException("value");
            }
            else
            {
                // Usuwanie odstępów wokół nazwiska
                value = value.Trim();
                if (value == "")
                {
                    // Zgłaszanie błędu
                    throw new ArgumentException(
                        "Właściwość LastName nie może być pusta.", "value");
                }
                else
                    _LastName = value;
            }
        }
    }

    private string _LastName;

    public string Salary;
    private string Password;
    private bool IsAuthenticated;

    public bool Logon(string password)
    {
        if (password == Password)
        {
            IsAuthenticated = true;
        }
        return IsAuthenticated;
    }

    public bool GetIsAuthenticated()
    {
        return IsAuthenticated;
    }

    public string GetName()
    {
        return $"{FirstName} {LastName}";
    }

    public void SetName(
        string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine(
            $"Imię i nazwisko zmieniono na '{this.GetName()}'.");
    }

    public void Save()
    {
        DataStorage.Store(this);
    }
}