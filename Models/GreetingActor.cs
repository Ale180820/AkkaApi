using System;
using Akka.Actor;

namespace AkkaAPI
{
    /// <summary>
    /// The actor class
    /// </summary>
    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            // Tell the actor to respond to the Greet message
            Receive<Greet>(greet => Console.WriteLine($"Hello {greet.Who}", ConsoleColor.Green));
        }
        protected override void PreStart() => Console.WriteLine("Good Morning, we are awake!", ConsoleColor.Green);

        protected override void PostStop() => Console.WriteLine("Good Night, going to bed!", ConsoleColor.Red);
    }
}