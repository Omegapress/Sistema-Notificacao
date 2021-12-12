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

            Console.WriteLine("*** Sistema de notificação de clientes 1.2***");
            Console.WriteLine("Informe código do cliente");
            var CodCliente = Console.ReadLine();
            Console.WriteLine("Informe mensagem a ser enviada: ");
            var Mensagem = Console.ReadLine();
            Console.WriteLine("Digite a opção de Envio 1 - EMAIL , 2 - SMS , 3 - VOICE");
            var modoEnvio = Console.ReadLine();

            if (modoEnvio == "1")
            {

                //SIMULA O ENVIO NO MODO EMAIL

                EnviarEmail(CodCliente, Mensagem);

            }

            else if (modoEnvio == "2")

            {

                //SIMULA O ENVIO NO MODO SMS

                EnviarSMS(CodCliente, Mensagem);

            }

            else if (modoEnvio == "3")
            {
                

                EnviarVoiceMail(CodCliente, Mensagem);

            }

            Console.ReadLine();

        }

        private static void EnviarVoiceMail(string CodCliente, string Mensagem)
        {

            // Simula gravação de um VoiceMail
            Console.WriteLine("Enviando VoiceMail para o cliente {0}", CodCliente);
            Console.WriteLine("VoiceMail: {0}", Mensagem);

        }

        private static void EnviarSMS(string CodCliente, string Mensagem)
        {

            // Simula gravação de um SMS
            Console.WriteLine("Enviando SMS para o cliente {0}", CodCliente);
            Console.WriteLine("SMS: {0}", Mensagem);

        }

        private static void EnviarEmail(string CodCliente, string Mensagem)
        {

            // Simula gravação de um Email
            Console.WriteLine("Enviando e-mail para o cliente {0}", CodCliente);
            Console.WriteLine("EMAIL: {0}", Mensagem);

        }

    }

}