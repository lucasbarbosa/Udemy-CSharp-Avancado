using System;

namespace Delegates2.Lib
{
	public class FotoProcessador
	{
		public delegate void FotoFiltroHandler(Foto foto);

		public static FotoFiltroHandler filtros;

		public static void Processar(Foto foto)
		{
			filtros(foto);

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
		}

		public static void ProcessarMetodos(Foto foto)
		{
			var filtros = new FotoFiltro();
			filtros.Colorir(foto);
			filtros.GerarThumb(foto);
			filtros.PretoBranco(foto);
			filtros.RedimensionarTamanhoMedio(foto);

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
		}
	}
}
