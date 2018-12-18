using Biblioteca;
using System;
using System.Reflection;

namespace Nullable
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            // Struct - Por Valor
            //ERRO: int i = null;
            int i = int.MinValue;

			// Class - Por referência
			object o = null;

			Nullable<int> Idade1 = null;
			int? Idade2 = null;

			Titulo.Rodape();
		}
	}
}
