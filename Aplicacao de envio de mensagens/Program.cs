using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaNotificacao
{

    class Program
    {

        static void Main(string[] args)
        {
            //Inicio do Programa de notificação de Cliente

            Console.WriteLine("*** Sistema de notificação de clientes 1.1***");
            Console.WriteLine("Informe código do cliente");
            var CodCliente = Console.ReadLine();
            Console.WriteLine("Informe mensagem a ser enviada: ");
            var Mensagem = Console.ReadLine();
            Console.WriteLine("Digite a opção de Envio 1 - EMAIL , 2 - SMS , 3 - VOICE");
            var modoEnvio = Console.ReadLine();

            if (modoEnvio == "1")
            {

                //SIMULA O ENVIO NO MODO EMAIL

                Console.WriteLine("Enviado EMAIL para o cliente {0}", CodCliente);
                Console.WriteLine("EMAIL: {0}", Mensagem);               

            }

            else if (modoEnvio == "2")

            {

                //SIMULA O ENVIO NO MODO SMS

                Console.WriteLine("Enviado SMS para o cliente {0}", CodCliente);
                Console.WriteLine("SMS: {0}", Mensagem);

            }

            else if (modoEnvio == "3")
            {
                //SIMULA O ENVIO NO MODO VOICE

                Console.WriteLine("Enviado VOICEMAIL para o cliente {0}", CodCliente);
                Console.WriteLine("VOICEMAIL: {0}", Mensagem);

            }

            Console.ReadLine();

        }

    }

}