using System.IO;

public static class LineCounter
{
    // pierwszy argument (jeśli podany) określ,a przeszukiwany katalog
    // domyślnie używamy katalog bieżący
    public static void Main(string[] args)
    {
        int totalLineCount = 0;


        if (args.Length > 1)
        {
            totalLineCount =
                DirectoryCountLines(args[0], args[1]);
        }
        if (args.Length > 0)
        {
            totalLineCount =
                DirectoryCountLines(args[0]);
        }
        else
        {
            totalLineCount =
                DirectoryCountLines();
        }

        System.Console.WriteLine(totalLineCount);
    }

    static int DirectoryCountLines()
    {
        return DirectoryCountLines(Directory.GetCurrentDirectory());
    }

    static int DirectoryCountLines(string directory)
    {
        return DirectoryCountLines(directory, "*.cs");
    }

    static int DirectoryCountLines(string directory, string extension)
    {
        int lineCount = 0;

        foreach (string file in Directory.GetFiles(directory, extension))
        {
            lineCount += CountLines(file);
        }

        foreach(string subdirectory in Directory.GetDirectories(directory))
        {
            lineCount += DirectoryCountLines(subdirectory);
        }

        return lineCount;
    }
    private static int CountLines(string file)
    {
        string line;
        int lineCount = 0;
        FileStream stream =
            new FileStream(file, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        line = reader.ReadLine();

        while (line != null)
        {
            if (line.Trim() != "")
            {
                lineCount++;
            }
            line = reader.ReadLine();
        }

        reader.Close(); // Automatycznie zamyka strumień
        return lineCount;
    }
}
