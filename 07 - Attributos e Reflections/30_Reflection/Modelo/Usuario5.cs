namespace Reflection.Modelo
{
    public class Usuario5 // : ICloneable
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public object Clone()
        {
            return new Usuario5() { Nome = this.Nome, Email = this.Email, Senha = this.Senha };
        }
    }
}
