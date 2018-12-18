using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace ThreadMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Console.WriteLine("Início do programa.");
            Thread.Sleep(3000);
            Console.WriteLine("Término do programa.");

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            // Prosseguir depois de executar a Thread
            t1.Join();

            Console.WriteLine("01 - Término do programa.");
            Console.WriteLine("02 - Término do programa.");
            Console.WriteLine("03 - Término do programa.");
            Console.WriteLine("04 - Término do programa.");
            Console.WriteLine("05 - Término do programa.");

            Titulo.Rodape();
        }

        //IO - Tela(monitor), Rede e Armazenamento
        static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread: " + Id + " - Num: " + i + " - Id Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
