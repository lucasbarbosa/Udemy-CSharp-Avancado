using Biblioteca;
using System;
using System.Linq;
using System.Reflection;

namespace LINQ_GROUP
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };
			
			var listaFiltradaDistinct = listaNum.Distinct();
			var listaFiltradaOrderBy = listaNum.OrderBy(x => x);

			foreach (var item in listaFiltradaOrderBy)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			var listaFiltradaGroupBy = listaNum.OrderBy(x => x).GroupBy(x => x);

			foreach (var item in listaFiltradaGroupBy)
			{
				Console.WriteLine(item.Key);
			}

			Titulo.Rodape();
		}
	}
}
