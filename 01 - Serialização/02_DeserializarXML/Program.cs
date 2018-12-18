using Biblioteca;
using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            string arquivo = "SerializarXML.xml";
            StreamReader stream = Arquivos.ArquivoLer(arquivo);

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine("Usuario ({0}), CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);

            Titulo.Rodape();
        }
    }
}
