using Biblioteca;
using System;
using System.IO;
using System.Reflection;
using System.Web.Script.Serialization;

namespace SerializarJSON
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Usuario usuario = new Usuario
			{
				Nome = "Maria da Costa Silva",
				CPF = "222.222.222-22",
				Email = "maria.costa@email.com"
			};

			string arquivo = "SerializarJSON.json";
			StreamWriter stream = Arquivos.ArquivoEscrever(arquivo);

			JavaScriptSerializer serializador = new JavaScriptSerializer();
			string usuarioSerializado = serializador.Serialize(usuario);

			stream.WriteLine(usuarioSerializado);
			stream.Close();

			Console.WriteLine("Usuário adicionado.");

            Titulo.Rodape();
        }
	}
}
