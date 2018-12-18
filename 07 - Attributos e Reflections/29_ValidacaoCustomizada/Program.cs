using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ValidacaoCustomizada
{
    class Program
    {
        static void Main(string[] args)
        {
            Titulo.Cabecalho(Assembly.GetCallingAssembly().GetName().Name);

            Usuario4 usuario = new Usuario4() { Nome = "José", Email = "jose", Senha = "123456" };
            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (!Validator.TryValidateObject(usuario, contexto, resultados, true))
            {
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Titulo.Rodape();
        }
    }
}
