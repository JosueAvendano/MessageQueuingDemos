using System;
using System.Messaging;

namespace MessageQueuingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Revisa si ya existen colas en las cola "queue"
            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\private$\queue"))
            {
                messageQueue = new MessageQueue(@".\private$\queue");
                messageQueue.Label = "testing queue";
            }
            else
            {
                MessageQueue.Create(@".\private$\queue");
                messageQueue = new MessageQueue(@".\private$\queue");
                messageQueue.Label = "Newly created queue";
            }
            messageQueue.Send("Esta es una prueba de mensaje encolado en MSMQ", "Cola");
            //messageQueue.Send("Segunda prueba de mesajeria de colas", "Cola_2");
            //messageQueue.Send("Hoy es miercoles 15 de diciembre", "Cola_3");
        }
    }
}
