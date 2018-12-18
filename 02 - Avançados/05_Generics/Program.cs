using Biblioteca;
using Generics.Modelo;
using System;
using System.Reflection;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Uno" };
			Casa casa = new Casa() { Endereco = "Cotia", Cidade = "Estrada do Embú, 1234" };
			Usuario2 usuario = new Usuario2() { Nome = "João Santos Silva", Email = "joao.santos@gmail.com", Senha = "123456" };

			Serializador.Serializar(carro);
			Serializador.Serializar(casa);
			Serializador.Serializar(usuario);

			Carro carro2 = Serializador.Deserializar<Carro>();
			Casa casa2 = Serializador.Deserializar<Casa>();
			Usuario2 usuario2 = Serializador.Deserializar<Usuario2>();

			Console.WriteLine("Carro: {0} - {1}", carro2.Marca, carro2.Modelo);
			Console.WriteLine("Casa: {0} - {1}", casa2.Endereco, casa2.Cidade);
			Console.WriteLine("Usuário: {0} - {1}", usuario2.Nome, usuario2.Email);

			Titulo.Rodape();
		}
	}
}
