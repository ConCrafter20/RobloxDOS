//Insisialize
Console.CursorVisible = false;
//Variables
//Main Screen
Console.WriteLine("Welcome to the Roblox DOS Installer [1.7.4]");
Console.WriteLine(" ");
Console.WriteLine(" ______________________________");
Console.WriteLine("|                              |");
Console.WriteLine("|   I: Install                 |");
Console.WriteLine("|   F1: Cancel Setup           |");
Console.WriteLine("|                              |");
Console.WriteLine("|                              |");
Console.WriteLine("|______________________________|");

//User Input Screen 1
if (Console.ReadKey().Key == ConsoleKey.F1)
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Ooops something went wrong! CODE: 0x883234");
    Thread.Sleep(7000);
    Console.ForegroundColor = ConsoleColor.White;
}
if (Console.ReadKey().Key == ConsoleKey.I)
{
    Console.Clear();
}



//partition selecter
//code lul
Console.WriteLine("What partition do you want to install RobloxDOS?");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ________________________________________________________________________");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|    1: Unpartitioned Space 2504 MB                                      |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|    Press the Number for Selection                                      |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|________________________________________________________________________|");

//User Input Screen 2
#pragma warning disable IDE0059



if (Console.ReadKey().Key == ConsoleKey.D1)
{
    Console.Clear();
    Console.WriteLine("Please Wait while everything is being prepared");
}
else if (Console.ReadKey().Key == ConsoleKey.NumPad1)
{
    Console.Clear();
    Console.WriteLine("Please Wait while everything is being prepared");
}
else if (Console.ReadKey().Key != ConsoleKey.NumPad1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ooops something went wrong! CODE: 0x883234");
    Thread.Sleep(7000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Please Wait while everything is being prepared");
    Thread.Sleep(5000);
}
else if (Console.ReadKey().Key != ConsoleKey.D1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ooops something went wrong! CODE: 0x883234");
    Thread.Sleep(7000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Console.WriteLine("Please Wait while everything is being prepared");
    Thread.Sleep(5000);
}
Thread.Sleep(60000);


Console.Clear();
Console.WriteLine("Oh no looks like you dont have the right file system!");
Console.WriteLine("Do you want to format from NTFS to RbxFS?");

Console.WriteLine("[Y/N]yes or no?");

Console.Write("Answer: ");
string yon = Console.ReadLine();

if (yon == "Y" || yon == "y")
{
    Console.Clear();
    Console.WriteLine("Formatting...");
    Thread.Sleep(500000);
    Console.Clear();
}

Console.WriteLine("");