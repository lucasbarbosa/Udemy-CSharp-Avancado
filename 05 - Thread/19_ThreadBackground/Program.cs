using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace ThreadBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(ThreadRepeticao);
                thread.IsBackground = true;
                thread.Start();
            }

            Titulo.Rodape();
        }

        //IO - Tela(monitor), Rede e Armazenamento
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Num: " + i);
            }

            Console.WriteLine("DataTime: " + DateTime.Now);
        }
    }
}
