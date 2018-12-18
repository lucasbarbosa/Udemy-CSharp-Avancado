using Biblioteca;
using System;
using System.Linq;
using System.Reflection;

namespace LINQ
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            // LINQ e LAMBDA
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

			var listaFiltradaLinq = lista.Where(x => x > 10).OrderBy(x => x).Select(x => x);
			var listaFiltradaSql = from x in lista where x > 10 orderby x select x; ;

			foreach (var item in listaFiltradaSql)
			{
				Console.WriteLine(item);
			}

			Titulo.Rodape();
		}
	}
}
