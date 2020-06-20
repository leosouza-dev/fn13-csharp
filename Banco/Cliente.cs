namespace Banco
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

    }
}