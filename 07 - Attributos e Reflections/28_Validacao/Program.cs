using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Usuario3 usuario_t1 = new Usuario3();
            ValidationContext contexto_t1 = new ValidationContext(usuario_t1);
            List<ValidationResult> resultados_t1 = new List<ValidationResult>();

            if(!Validator.TryValidateObject(usuario_t1, contexto_t1, resultados_t1))
            {
                foreach(var erro in resultados_t1)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.WriteLine();

            Usuario3 usuario_t2 = new Usuario3() { Nome = "José", Email = "jose", Senha = "1234" };
            ValidationContext contexto_t2 = new ValidationContext(usuario_t2);
            List<ValidationResult> resultados_t2 = new List<ValidationResult>();

            if (!Validator.TryValidateObject(usuario_t2, contexto_t2, resultados_t2, true))
            {
                foreach (var erro in resultados_t2)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Titulo.Rodape();
        }
    }
}
