using Biblioteca;
using System;
using System.Reflection;

namespace ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            string valor = "olá mundo!";
			Console.WriteLine(valor.FirstToUpper());

			Titulo.Rodape();
		}
	}
}
