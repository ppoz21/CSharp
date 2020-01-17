using System;
using System.Net;

class Downloader
{
    static int Main(string[] args)
    {
        int result;
        string targetFileName;
        string url;
        switch(args.Length)
        {
            default:
                // Należy podać dokładnie dwa argumenty, w przeciwnym razie kod zgłosi błąd.
                Console.WriteLine(
                    "BŁĄD: należy podać adres URL"
                    + " i nazwę pliku.");
                targetFileName = null;
                url = null;
                break;
            case 2:
                url = args[0];
                targetFileName = args[1];
                break;
        }

        if (targetFileName != null && url != null)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, targetFileName);
            result = 0;
        }
        else
        {
            Console.WriteLine(
                "Użytkowanie: Downloader.exe <URL> <nazwa_docelowego_pliku>");
            result = 1;
        }
        return result;
    }
}
