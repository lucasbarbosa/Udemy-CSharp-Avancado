using Biblioteca;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace TaskExecute
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Task.Run(()=>Metodo01());
            Task.Run(() => Metodo01());
            Task.Factory.StartNew(Metodo01);

            Titulo.Rodape();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Valor: "+i+" - TaskID: "+Task.CurrentId);
            }
        }
    }
}
