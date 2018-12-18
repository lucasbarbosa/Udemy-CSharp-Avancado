using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQ_OBJ
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            List<Usuario> lista = new List<Usuario>();

			lista.Add(new Usuario { Nome = "José", Email = "jose@gmail.com" });
			lista.Add(new Usuario { Nome = "Maria", Email = "maria@hotmail.com" });
			lista.Add(new Usuario { Nome = "João", Email = "jose@ig.com" });
			lista.Add(new Usuario { Nome = "Felipe", Email = "felipe@gmail.com" });
			lista.Add(new Usuario { Nome = "Elias", Email = "elias@gmail.com" });

			var listaFiltrada = lista.Where(x => x.Email.Contains("@gmail.com")).OrderBy(x => x.Nome);

			foreach (var item in listaFiltrada)
			{
				Console.WriteLine(item.Nome + " - " + item.Email);
			}

			Titulo.Rodape();
		}
	}
}
