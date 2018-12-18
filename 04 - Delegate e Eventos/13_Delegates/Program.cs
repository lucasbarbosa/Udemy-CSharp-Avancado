using Biblioteca;
using System;
using System.Reflection;

namespace Delegates
{
	class Program
	{
		delegate int Calcula(int a, int b);

		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            /*
			var so = Somar(10, 20);
			var su = Subtrair(20, 10);
			*/

            Calcula Calc1 = new Calcula(Somar);
			Calcula Calc2 = new Calcula(Subtrair);

			var so = Calc1(10, 20);
			var su = Calc2(30, 15);

			Console.WriteLine("Soma: " + so);
			Console.WriteLine("Subtração: " + su);

			Titulo.Rodape();
		}

		static int Somar(int a, int b)
		{
			return a + b;
		}

		static int Subtrair(int a, int b)
		{
			return a - b;
		}
	}
}
