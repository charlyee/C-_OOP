using System;

namespace Abstraction
{
    abstract class SecretMessage
    {
        public void mySecretMessage()
        {
            Console.WriteLine("This is my secret message!");
        }
    }

    class PublicMessage : SecretMessage
    {
        public void myPublicMessage()
        {
            Console.WriteLine("Everyone can see this message!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PublicMessage myPubMsg = new PublicMessage();
            myPubMsg.myPublicMessage();
            myPubMsg.mySecretMessage();
        }
    }
}
