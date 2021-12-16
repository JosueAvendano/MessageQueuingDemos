using System;
using System.Messaging;

namespace MessageQueuingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Revisa si ya existen en las colas privadas en la cola "queue"
            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\private$\queue"))
            {
                messageQueue = new MessageQueue(@".\private$\queue");
                //El label de la carpeta de queue se va a llamar testing queue -> cola de prueba
                messageQueue.Label = "testing queue";
            }
            //Si no existe una cola, me la crea dentro de la ruta de \private\queue y le coloco un label a la cola, un titulo y un mensaje
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
