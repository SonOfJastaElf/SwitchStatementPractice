using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject to study?");
            var subject = (Console.ReadLine());

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Oh, so you're a numbers person, cool!");
                    break;
                case "History":
                    Console.WriteLine("If we don't learn from it, we're doomed to repeat it.");
                    break;
                case "English":
                    Console.WriteLine("Maybe you're a bibliophile.");
                    break;
                case "Science":
                    Console.WriteLine("I wonder which particular science you like...");
                    break;
                case "Foreign Languages":
                    Console.WriteLine("Kinda sucks that we can't travel much of anywhere right now.");
                    break;
                case "Music":
                    Console.WriteLine("Awesome!  I like that, too.  If it sounds good, it IS good!");
                    break;
                default:
                    Console.WriteLine("I've never studied that.  But you do you.");
                    break;
            }
        }
    }
}
