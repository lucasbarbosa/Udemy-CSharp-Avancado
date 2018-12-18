using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQ_JOIN
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            List<Autor> listaAutor = new List<Autor>();
			listaAutor.Add(new Autor { Id = 1, Nome = "Leonardo" });
			listaAutor.Add(new Autor { Id = 2, Nome = "Maria" });
			listaAutor.Add(new Autor { Id = 3, Nome = "José" });

			List<Livro> listaLivro = new List<Livro>();
			listaLivro.Add(new Livro { Id = 1, AutorID = 2, Titulo = "Amor amado" });
			listaLivro.Add(new Livro { Id = 2, AutorID = 2, Titulo = "Bem amado" });
			listaLivro.Add(new Livro { Id = 3, AutorID = 3, Titulo = "Um espião em Washington" });
			listaLivro.Add(new Livro { Id = 4, AutorID = 1, Titulo = "A vida na terra" });

			var listaJoin = from livro in listaLivro
							join autor in listaAutor
							on livro.AutorID equals autor.Id
							select new { Livro = livro.Titulo, Autor = autor.Nome };

			foreach(var item in listaJoin)
			{
				Console.WriteLine("Livro: "+ item.Livro + " - Autor: "+item.Autor);
			}
			
			Titulo.Rodape();
		}
	}
}
