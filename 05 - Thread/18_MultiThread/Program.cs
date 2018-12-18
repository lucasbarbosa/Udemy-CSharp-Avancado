using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start();
            }

            Console.WriteLine("Programa finalizado.");

            Titulo.Rodape();
        }

        //IO - Tela(monitor), Rede e Armazenamento
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Num: " + i);
            }
        }
    }
}
