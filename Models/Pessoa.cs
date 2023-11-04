

namespace desafioDois.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }

        private string? _nome;

        public string? Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        private string? _sobreNome;

        public string? SobreNome
        {
            get => _sobreNome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobre nome deve ser preenchido.");
                }

                _sobreNome = value;
            }
        }
    }
}