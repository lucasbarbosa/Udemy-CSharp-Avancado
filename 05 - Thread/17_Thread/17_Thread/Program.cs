using Biblioteca;
using System;
using System.Reflection;
using System.Threading;

namespace _17_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Main: " + i);
            }

            Titulo.Rodape();
        }

        //IO - Tela(monitor), Rede e Armazenamento
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Num: "+i);
            }
        }
    }
}
