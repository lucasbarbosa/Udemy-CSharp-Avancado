using Biblioteca;
using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Usuario usuario = new Usuario
            {
                Nome = "Carlos da Costa Silva",
                CPF = "111.111.111-11",
                Email = "carlos.costa@email.com"
            };

            string arquivo = "SerializarXML.xml";
            StreamWriter stream = Arquivos.ArquivoEscrever(arquivo);

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            serializador.Serialize(stream, usuario);

            Console.WriteLine("Usuário adicionado.");

            Titulo.Rodape();
        }
    }
}
