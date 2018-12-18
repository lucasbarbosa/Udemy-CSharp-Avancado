using Biblioteca;
using System;
using System.IO;
using System.Reflection;
using System.Web.Script.Serialization;

namespace DeserializarJSON
{
	class Program
	{
		static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            string arquivo = "SerializarJSON.json";
			StreamReader stream = Arquivos.ArquivoLer(arquivo);
			string conteudoArquivo = stream.ReadToEnd();

			JavaScriptSerializer serializador = new JavaScriptSerializer();
			Usuario usuario = (Usuario)serializador.Deserialize(conteudoArquivo, typeof(Usuario));

			Console.WriteLine("Usuario ({0}), CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);

            Titulo.Rodape();
        }
    }
}
