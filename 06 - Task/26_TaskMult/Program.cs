using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using Biblioteca;
using System.Reflection;

namespace TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());

            string[] enderecos = new string[] {
                "http://www.google.com.br",
                "http://www.microsoft.com.br",
                "http://www.g1.com.br"
            };

            var listaEnd = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEnd.ToArray());

            Console.WriteLine("Programa finalizado!");

            Titulo.Rodape();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Valor: " + i + " - TaskID: " + Task.CurrentId);
            }
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download realizado para a página: "+end);
        }
    }
}
