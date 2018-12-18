using System.Web.Script.Serialization;
using System.IO;
using Biblioteca;

namespace Generics
{
	public class Serializador
	{
		public static void Serializar(object obj)
		{
			string arquivo = obj.GetType().Name + ".txt";
			StreamWriter stream = Arquivos.ArquivoEscrever(arquivo);

			JavaScriptSerializer serializador = new JavaScriptSerializer();
			string objetoSerializado = serializador.Serialize(obj);

			stream.Write(objetoSerializado);
			stream.Close();
		}

		public static T Deserializar<T>()
		{
			string arquivo = typeof(T).Name+".txt";
			StreamReader stream = Arquivos.ArquivoLer(arquivo);

			string conteudo = stream.ReadToEnd();

			JavaScriptSerializer serializador = new JavaScriptSerializer();
			T objeto = serializador.Deserialize<T>(conteudo);

			return objeto;
		}
	}
}
