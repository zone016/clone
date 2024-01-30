﻿namespace Clone.Console.Helpers;

public static class Printer
{
    private static void PrintMessage(string prefix, string message, ConsoleColor color, TextWriter? writer = default)
    {
        ForegroundColor = color;

        if (writer is null)
        {
            Write(prefix);
            ResetColor();

            WriteLine(message);
        }
        else
        {
            writer.Write(prefix);
            ResetColor();

            writer.WriteLine(message);
        }
    }

    public static void PrintSuccess(string message) => PrintMessage("suc: ", message, ConsoleColor.Green);

    public static void PrintInformational(string message) => PrintMessage("inf: ", message, ConsoleColor.DarkGray);

    public static void PrintWarning(string message) => PrintMessage("war: ", message, ConsoleColor.Yellow);

    public static void PrintGitStdout(string stdout) => PrintMessage("git: ", stdout, ConsoleColor.DarkGray);

    public static void PrintError(string stderr) => PrintMessage("err: ", stderr, ConsoleColor.Red, Error);
}