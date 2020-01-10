class Palindrome
{
    static void Main()
    {
        string reverse, palindrome;
        char[] temp;

        System.Console.Write("Wprowadź palindrom: ");
        palindrome = System.Console.ReadLine();

        // Usuwanie odstępów i przekształcanie liter na małe
        reverse = palindrome.Replace(" ", "");
        reverse = reverse.ToLower();

        // Przekształcenie w tablicę
        temp = reverse.ToCharArray();

        // Odwracanie kolejności elementów w tablicy
        System.Array.Reverse(temp);

        // Przekształcanie tablicy z powrotem w łańcuch znaków i
        // sprawdzenie, czy odwrócony łańcuch jest identyczny z pierwotnym
        if(reverse == new string(temp))
        {
            System.Console.WriteLine(
                $"\"{palindrome}\" jest palindromem.");
        }
        else
        {
            System.Console.WriteLine(
                $"\"{palindrome}\" NIE jest palindromem.");
        }
    }
}