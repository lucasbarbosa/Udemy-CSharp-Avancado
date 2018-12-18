using Biblioteca;
using System.Reflection;

namespace Atributo
{
    [MeuAtributo("Atributo Classe", Descricao = "Descricao do Atributo")]
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Titulo.Rodape();
        }
    }
}
