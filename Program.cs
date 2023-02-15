using System.Security.Cryptography.X509Certificates;

namespace Part_4._5___Intro_to_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

        // --------------------------------------------------------------------------------- ONE

            Console.WriteLine("ASCII Art");

            HelloWorldArt();
            TruckArt();
            LuckyArt();
            Console.WriteLine("");

        // --------------------------------------------------------------------------------- TWO

            Console.WriteLine("Knock Knock Joke");

            KnockKnockJoke();

        }

        // --------------------------------------------------------------------------------- ONE
        public static void HelloWorldArt()
        {
            Console.WriteLine(" ___  ___  _______   ___       ___       ________          ___       __   ________  ________  ___       ________  ___       \r\n|\\  \\|\\  \\|\\  ___ \\ |\\  \\     |\\  \\     |\\   __  \\        |\\  \\     |\\  \\|\\   __  \\|\\   __  \\|\\  \\     |\\   ___ \\|\\  \\      \r\n\\ \\  \\\\\\  \\ \\   __/|\\ \\  \\    \\ \\  \\    \\ \\  \\|\\  \\       \\ \\  \\    \\ \\  \\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\    \\ \\  \\_|\\ \\ \\  \\     \r\n \\ \\   __  \\ \\  \\_|/_\\ \\  \\    \\ \\  \\    \\ \\  \\\\\\  \\       \\ \\  \\  __\\ \\  \\ \\  \\\\\\  \\ \\   _  _\\ \\  \\    \\ \\  \\ \\\\ \\ \\  \\    \r\n  \\ \\  \\ \\  \\ \\  \\_|\\ \\ \\  \\____\\ \\  \\____\\ \\  \\\\\\  \\       \\ \\  \\|\\__\\_\\  \\ \\  \\\\\\  \\ \\  \\\\  \\\\ \\  \\____\\ \\  \\_\\\\ \\ \\__\\   \r\n   \\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\_______\\ \\_______\\       \\ \\____________\\ \\_______\\ \\__\\\\ _\\\\ \\_______\\ \\_______\\|__|   \r\n    \\|__|\\|__|\\|_______|\\|_______|\\|_______|\\|_______|        \\|____________|\\|_______|\\|__|\\|__|\\|_______|\\|_______|   ___ \r\n                                                                                                                       |\\__\\\r\n                                                                                                                       \\|__|\r\n                                                                                                                            ");
        }
        
        public static void TruckArt()
        {
            Console.WriteLine("──────▄▌▐▀▀▀▀▀▀▀▀▀▀▀▀▌\r\n───▄▄██▌█░░░░░░░░░░░░▐\r\n▄▄▄▌▐██▌█░░░░░░░░░░░░▐\r\n███████▌█▄▄▄▄▄▄▄▄▄▄▄▄▌\r\n▀O▀▀▀▀▀▀▀OO▀▀▀▀▀▀OO▀\r\n");
        }

        public static void LuckyArt()
        {
            Console.WriteLine("█▄████─█▄████─█▄████\r\n▀▀─▄█▀─▀▀─▄█▀─▀▀─▄█▀\r\n──▄██────▄██────▄██\r\n─▄██▀───▄██▀───▄██▀\r\n─███────███────███\r\n");
        }

        // --------------------------------------------------------------------------------- TWO
        public static void KnockKnockJoke()
        {
            Console.WriteLine("");
            Console.WriteLine("Knock Knock");
            Thread.Sleep(1500);
            Console.WriteLine("**Press ENTER to continue**");
            Console.ReadLine();
            Console.WriteLine("Who's there?");
            Console.ReadLine();
            Console.WriteLine("A broken pencil");
            Console.ReadLine();
            Console.WriteLine("A broken pencil who?");
            Console.ReadLine();
            Console.WriteLine("Never mind, it's pointless");
            Thread.Sleep(2000);
            Console.WriteLine(".....");

        }
    }
}