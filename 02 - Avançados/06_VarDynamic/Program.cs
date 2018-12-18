using Biblioteca;
using System;
using System.Reflection;

namespace VarDynamic
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            object t1 = "";
			object t2 = 123;
			t2 = "";

			var v1 = "";
			var v2 = 456;
			//ERRO: v2 = "";
			//ERRO: var v3;

			dynamic d1;
			dynamic d2 = new Usuario { Nome = "José" };

			Console.WriteLine(d2.Nome);
			//ERRO: Console.WriteLine(d2.Senha);

			d2 = "";

			Titulo.Rodape();
		}

		class Usuario
		{
			public string Nome { get; set; }
		}
	}
}
