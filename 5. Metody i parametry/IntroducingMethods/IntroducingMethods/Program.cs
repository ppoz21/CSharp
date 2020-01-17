class IntroducingMethods
{
    public static void Main()
    {
        string firstName;
        string lastName;
        string fullName;
        string initials;

        System.Console.WriteLine("Hej, ty!");

        firstName = GetUserInput("Wprowadź imię: ");
        lastName = GetUserInput("Wprowadź nazwisko: ");

        fullName = GetFullName(firstName, lastName);
        initials = GetInitials(firstName, lastName);
        DisplayGrettings(fullName, initials);

        
    }

    static string GetUserInput(string prompt)
    {
        System.Console.Write(prompt);
        return System.Console.ReadLine();
    }

    static string GetFullName( //Metoda z ciałem w postaci wyrażenia wprowadzona w C# 6.0.
        string firstName, string lastName) =>
        $"{ firstName } { lastName }";

    static string GetInitials(string firstName, string lastName)
    {
        return $"{ firstName[0] }. { lastName[0] }.";
    }

    static void DisplayGrettings(string fullName, string initials)
    {
        System.Console.WriteLine(
            $"Witaj, { fullName }! Twoje inicjały to { initials }");
        return;
    }
}