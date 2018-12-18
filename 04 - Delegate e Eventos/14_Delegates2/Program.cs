using Biblioteca;
using Delegates2.Lib;
using System.Reflection;

namespace Delegates2
{
	class Program
	{
		static void Main(string[] args)
		{
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);
            
            Foto foto = new Foto() { Nome = "foto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
			FotoProcessador.ProcessarMetodos(foto);

			// Tela - Cadastro de Usuário: Thumb (Foto de perfil)
			Foto foto1 = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
			FotoProcessador.filtros = new FotoFiltro().GerarThumb;
			FotoProcessador.Processar(foto1);

			// Tela - Cadastro de Produtos: Colorir + Tamanho Médio
			Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
			FotoProcessador.filtros = new FotoFiltro().Colorir;
			FotoProcessador.filtros += new FotoFiltro().RedimensionarTamanhoMedio;
			FotoProcessador.Processar(foto2);

			// Tela - Cadastro de Albuns do Usuário (Retrô): Preto e branco
			Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
			FotoProcessador.filtros = new FotoFiltro().PretoBranco;
			FotoProcessador.Processar(foto3);

			Titulo.Rodape();
		}
	}
}
