using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace ThreadId
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.Start(i);
            }

            Titulo.Rodape();
        }

        //IO - Tela(monitor), Rede e Armazenamento
        static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread: "+Id+" - Num: " + i + " - Id Interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
