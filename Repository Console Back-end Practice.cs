using System;
using System.Net.Mail;
using System.Text;
using System.Threading;

class Program
{
    static async Task Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.OutputEncoding = Encoding.UTF8;
        {
            await Task.Delay(1000);

            Console.WriteLine("User Detected.");
            await Task.Delay(1000);

            Console.WriteLine("User Detected.");
            await Task.Delay(1000);

            Console.WriteLine("User Detected.");
            await Task.Delay(1000);

            await Typewriter("You are entering restricted area.", 105);
            Console.WriteLine();

            await Task.Delay(2000);

            await Typewriter("You are not allowed in this Property.", 110);
            Console.WriteLine();

            await Typewriter("Leave immediately.", 110);
            Console.WriteLine();

            await Task.Delay(1000);

            Console.WriteLine("Leave.");
                await Task.Delay(1000);

            Console.WriteLine("Leave.");
            await Task.Delay(1000);

            Console.WriteLine("Leave.");
            await Task.Delay(1000);

            static async Task Typewriter(string text, int delay)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    await Task.Delay(delay);
                }
            }
        }
    }
}