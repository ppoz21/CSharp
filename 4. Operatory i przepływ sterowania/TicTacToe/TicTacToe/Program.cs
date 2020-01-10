#define CSHARP2PLUS

using System;

#pragma warning disable 1030

public class TicTacToeGame
{
    public static void Main()
    {
        int[] playerPositions = { 0, 0 };

        int currentPlayer = 1;

        int winner = 0;

        string input = null;


        for(int turn = 1; turn <= 10; turn++)
        {
            DisplayBoard(playerPositions);

            #region Wykrywanie końca gry
            if(EndGame(winner, turn, input))
            {
                break;
            }
            #endregion

            input = NextMove(playerPositions, currentPlayer);

            winner = DetermineWinner(playerPositions);

            currentPlayer = (currentPlayer == 2) ? 1 : 2;
        }
    }

    private static string NextMove(int[] playersPositions, int currentPlayer)
    {
        string input;

        bool validMove;
        do
        {
            Console.WriteLine($"\nGracz {currentPlayer} - wprowadź ruch: ");
            input = Console.ReadLine();
            validMove = ValidateAndMove(playersPositions, currentPlayer, input);
        }
        while (!validMove);

        return input;
    }

    static bool EndGame(int winner, int turn, string input)
    {
        bool endGame = false;
        if(winner > 0)
        {
            Console.WriteLine($"\nGracz {winner} wygrał!!!");
            endGame = true;
        }
        else if (turn == 10)
        {
            Console.WriteLine("\nGra zakończona remisem!");
            endGame = true;
        }
        else if (input == "" || input == "quit")
        {
            Console.WriteLine("Gracz zakończył rozgrywkę");
            endGame = true;
        }
        return endGame;
    }
    static int DetermineWinner(int[] playersPositions)
    {
        int winner = 0;

        int[] winningMasks =
        {
            7, 56, 448, 73, 146, 292, 84, 273
        };

        foreach(int mask in winningMasks)
        {
            if((mask & playersPositions[0]) == mask)
            {
                winner = 1;
                break;
            }
            else if ((mask & playersPositions[1]) == mask)
            {
                winner = 2;
                break;
            }
        }
        return winner;
    }
    static bool ValidateAndMove(int[] playerPositions, int currentPlayer, string input)
    {
        bool valid = false;

        switch(input)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
#warning "Dozwolone jest wielokrotne wprowadzenie tego samego ruchu"
                int shifter;
                int position;

                shifter = int.Parse(input) - 1;

                position = 1 << shifter;

                playerPositions[currentPlayer - 1] |= position;

                valid = true;
                break;
            case "":
            case "quit":
                valid = true;
                break;
            default:
                Console.WriteLine(
                    "Błąd: Wprowadź wartość od 1 do 9. " +
                    "Naciśnij Enter, aby zakończyć.");
                break;
        }
        return valid;
    }
    static void DisplayBoard(int[] playerPositions)
    {
        string[] borders =
        {
            "|", "|", "\n---+---+---\n", "|", "|",
            "\n---+---+---\n", "|", "|", ""
        };

        int border = 0;

#if CSHARP2PLUS
        Console.Clear();
#endif
        for(int position = 1; position <= 256; position <<=1, border++)
        {
            char token = CalculateToken(
                playerPositions, position);
            Console.Write($" {token} { borders[border] }");
        }
    }
    static char CalculateToken(int[] playerPositions, int position)
    {
        char[] players = { 'X', 'Y' };

        char token;

        if((position & playerPositions[0]) == position)
        {
            token = players[0];
        }
        else if((position & playerPositions[1]) == position)
        {
            token = players[1];
        }
        else
        {
            token = ' ';
        }
        return token;
    }
#line 113 "TicTacToe.cs"
    // miejsce na wygenerowany kod
#line default
}