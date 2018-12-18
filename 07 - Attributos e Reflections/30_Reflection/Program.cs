using Biblioteca;
using Reflection.Modelo;
using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Usuario5 usuario = new Usuario5()
            {
                Nome = "José",
                Email = "jose.costa@gmail.com",
                Senha = "123456ab"
            };

            Log.GravarUsuario(usuario);
            Log.Gravar(usuario.Clone());
            
            usuario.Nome = "José Costa";

            Log.GravarUsuario(usuario);
            Log.Gravar(usuario.Clone());
            
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };

            Log.GravarCarro(carro);
            Log.Gravar(carro);

            Log.ApresentarLogObjetos();

            Console.WriteLine();

            Log.ApresentarLogReflection();

            Console.WriteLine("Log gravado!");
            
            Titulo.Rodape();
        }
    }
}
