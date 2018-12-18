using System;

namespace Biblioteca
{
    public static class Titulo
    {
        public static void Cabecalho(string titulo)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--- " + titulo);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        public static void Rodape()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
