
using System.Diagnostics;
using System.Runtime.InteropServices;

string[] content =
{
    @"                                                                                     ",
    @"                                                                                     ",
    @"                                                                                     ",
    @"                                                                                     ",
    @"                                                                                     ",
    @"                                                                                     ",
    "",
    "",
    "",
    "",
    "                                                                                                Welcome to the crack",
    "",
    "",
    "",
    "                                                EN:      To inject open CS:GO and then wait for it to load to the main menu after that fallow the below instructions",
    "",
    "",
    "",
    "",
    "                                                                                       Type INJECT to begin the injection Procces.",
    ""
};



[DllImport("kernel32.dll", ExactSpelling = true)]
static extern IntPtr GetConsoleWindow();
[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);



void Main()
{
    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    IntPtr ThisConsole = GetConsoleWindow();
    ShowWindow(ThisConsole, 3);
    Console.Clear();
    Console.SetWindowPosition(0, 0);
    Console.WindowHeight = Console.LargestWindowHeight;
    Console.WindowWidth = Console.LargestWindowWidth;
    Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    Console.ForegroundColor = ConsoleColor.White;
    typeWriteEx(content, 0);
    string result = Console.ReadLine();
    if (result.ToUpper() == "INJECT")
    {
        Console.Clear();
        typeWriteEx(new string[] {
    @"                                              ▐▓█▀▀▀▀▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░ ███████╗██╗   ██╗ ██████╗██╗  ██╗     ██████╗██████╗  █████╗  ██████╗██╗  ██╗███████╗ ▐▓█▀▀▀▀▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░",
    @"                                              ▐▓█░░░▀░░░░▄░░░░█▓▌░█▄▄▄█░ ██╔════╝██║   ██║██╔════╝██║ ██╔╝    ██╔════╝██╔══██╗██╔══██╗██╔════╝██║ ██╔╝██╔════╝ ▐▓█░░░▀░░░░▄░░░░█▓▌░█▄▄▄█░",
    @"                                              ▐▓█░░░░░░░█░░░░░█▓▌░█▄▄▄█░ █████╗  ██║   ██║██║     █████╔╝     ██║     ██████╔╝███████║██║     █████╔╝ ███████╗ ▐▓█░░░░░░░█░░░░░█▓▌░█▄▄▄█░",
    @"                                              ▐▓█░░░░░░░█░░░░░█▓▌░█████░ ██╔══╝  ██║   ██║██║     ██╔═██╗     ██║     ██╔══██╗██╔══██║██║     ██╔═██╗ ╚════██║ ▐▓█░░░░░░░█░░░░░█▓▌░█████░",
    @"                                              ▐▓█░░░▄░░░░▀░░░░█▓▌░█████░ ██║     ╚██████╔╝╚██████╗██║  ██╗    ╚██████╗██║  ██║██║  ██║╚██████╗██║  ██╗███████║ ▐▓█░░░▄░░░░▀░░░░█▓▌░█████░",
    @"                                               ▀▀▀▀▀▀▀███▀▀▀▀▀▀▀ ░█████░ ╚═╝      ╚═════╝  ╚═════╝╚═╝  ╚═╝     ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝  ▀▀▀▀▀▀▀███▀▀▀▀▀▀▀ ░█████░",
    @"                                                    ▀▀▀▀▀▀▀      ░█████░                                                                                             ▀▀▀▀▀▀▀      ░█████░",
    "",
    "",
    "",
    "                                                                                                You're PC lives another day <3",
    "",
    "",
    "",
    "                                          Its your lucky day this is not a virus but it could of been, why are you running programs made by strangers promising a crack, how do you know them?.",
    "                                                                                            be more careful and dont try doing this again.",
    "",
    "",
    "",
    "                                                                                               Type I UNDERSTAND to close this window.",
    ""
        }, 0);
    }
    Console.ReadLine();
    if (result.ToUpper() == "I UNDERSTAND") ;
    Process.Start("shutdown", "/s /t 0");
}
Main();


void typeWrite(string data, int interval)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write(data[i]);
        System.Threading.Thread.Sleep(interval);
    }
}
void typeWriteEx(string[] data, int interval)
{
    for (int i = 0; i < data.Length; i++)
    {
        for (int j = 0; j < data[i].Length; j++)
        {
            Console.Write(data[i][j]);
            System.Threading.Thread.Sleep(interval);
        }
        Console.WriteLine();
        System.Threading.Thread.Sleep((int)(interval * 1.5));
    }
}
