using Reflection.Modelo;
using System;
using System.Collections.Generic;

namespace Reflection
{
    public class Log
    {
        #region Classes

        public static List<Usuario5> usuarios = new List<Usuario5>();
        public static void GravarUsuario(Usuario5 usuario)
        {
            usuarios.Add((Usuario5)usuario.Clone());
        }

        public static List<Carro> carros = new List<Carro>();
        public static void GravarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        public static void ApresentarLogObjetos()
        {
            foreach (Usuario5 usuario in usuarios)
            {
                Console.WriteLine("Nome: {0}, Email: {1}, Senha: {2};", usuario.Nome, usuario.Email, usuario.Senha);
            }
            foreach (Carro carro in carros)
            {
                Console.WriteLine("Marca: {0}, Modelo: {1};", carro.Marca, carro.Modelo);
            }
        }

        #endregion

        #region Reflection

        public static List<Object> objetos = new List<object>();

        public static void Gravar(object obj)
        {
            objetos.Add(obj);
        }

        public static void ApresentarLogReflection()
        {
            foreach (object obj in objetos)
            {
                Console.WriteLine("---------Nome Classe: {0}--------", obj.GetType().Name);

                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine(prop.Name + ": " + prop.GetValue(obj));
                }
            }
        }

        #endregion
    }
}
