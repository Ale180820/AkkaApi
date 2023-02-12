using Akka.Actor;

namespace Akka_API.Models
{
    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            Receive<Greet>(greet => Console.WriteLine($"Hello {greet.Who}", ConsoleColor.Green));
        }
        protected override void PreStart()
        {
            Console.WriteLine("Good Morning, Who are u?", ConsoleColor.Green);
        }

        protected override void PostStop() => Console.WriteLine("Nice to meet u, friend", ConsoleColor.Red);
    }
}
