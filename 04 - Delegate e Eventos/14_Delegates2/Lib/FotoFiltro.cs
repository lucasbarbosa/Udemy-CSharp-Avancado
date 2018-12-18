using System;

namespace Delegates2.Lib
{
	public class FotoFiltro
	{
		public void Colorir(Foto foto)
		{
			Console.WriteLine("FotoFiltro > Colorir: "+foto.Nome);
		}

		public void GerarThumb(Foto foto)
		{
			Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
		}

		public void PretoBranco(Foto foto)
		{
			Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
		}

		public void RedimensionarTamanhoMedio(Foto foto)
		{
			Console.WriteLine("FotoFiltro > RedimensionarTamanhoMedio: " + foto.Nome);
		}
	}
}
