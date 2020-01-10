class ProgrammingLanguages
{
    static void Main()
    {
        string[] languages = new string[]{
            "C#", "COBOL", "Java",
            "C++", "Visual Basic", "Pascal",
            "Python", "R", "F#"};
        System.Array.Sort(languages);

        string searchString = "Python";
        int index = System.Array.BinarySearch(
            languages, searchString);
        System.Console.WriteLine(
            "Język przyszłości, "
            + $"{ searchString }, jest dostępny pod indeksem { index }");

        System.Console.WriteLine();
        System.Console.WriteLine(
            $"{ "Pierwszy element",-20 }\t{ "Ostatni element",-20}");
        System.Console.WriteLine(
            $"{ "----------------",-20 }\t{ "----------------",-20 }");
        System.Console.WriteLine(
            $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
        System.Array.Reverse(languages);
        System.Console.WriteLine(
            $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
        System.Array.Clear(languages, 0, languages.Length);
        System.Console.WriteLine(
            $"{ languages[0],-20 }\t{ languages[languages.Length - 1],-20 }");
        System.Console.WriteLine(
            $"Po wywołaniu Clear wielkość tablicy to: { languages.Length }");

    }
}