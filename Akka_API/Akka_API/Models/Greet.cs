namespace Akka_API.Models
{
   public class Greet
    {
        public string Who { get; private set; }

        public Greet(string who)
        {
            Who = who;
        }

        public override string ToString()
        {
            return $"El actor {Who} ha sido conocido";
        }
    }
}
