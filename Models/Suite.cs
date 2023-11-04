

namespace desafioDois.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        private string? _tipoSuite;

        public string? TipoSuite
        {
            get => _tipoSuite;
            set
            {
                _tipoSuite = value;
            }
        }

        private int _capacidade;

        public int Capacidade
        {
            get => _capacidade;
            set
            {
                _capacidade = value;
            }
        }

        private decimal _valorDiaria;

        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set
            {
                _valorDiaria = value;
            }
        }
    }
}