using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace ThreadSafe
{
    class Program
    {
        static int Rede = 0;
        static object variavelDeControle = 0;

        //IO - Input/Output - Lento (Tela, Rede, Armazenamento, Impressora-Rede)
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Console.WriteLine("Dataini: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.IsBackground = true;
                thread.Start();
            }

            Titulo.Rodape();
        }

        static void ThreadRepeticao()
        {
            // FIFO - First In, First Out
            for (int i = 0; i < 50; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Num: " + i);
                    Rede++;
                }
            }

            Console.WriteLine("DataTime: " + DateTime.Now);
        }
    }
}
