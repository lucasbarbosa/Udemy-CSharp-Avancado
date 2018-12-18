using System.IO;

namespace Biblioteca
{
    public static class Arquivos
    {
        public static string CaminhoBase()
        {
            var path = @"C:\Lucas.Teixeira.Files\TestsProjects\Udemy\CSharpAvancado\_Arquivos\";
            // var path = @"C:\Estudos\Dotnet\Udemy\CSharpAvancado\_Arquivos\";
			
			return path;
        }

        public static StreamReader ArquivoLer(string arquivo)
        {
            string diretorio = CaminhoBase();

            StreamReader stream = new StreamReader(diretorio + arquivo);
            return stream;
        }

        public static StreamWriter ArquivoEscrever(string arquivo)
        {
            string diretorio = CaminhoBase();

            StreamWriter stream = new StreamWriter(diretorio + arquivo);
            return stream;
        }
    }
}
