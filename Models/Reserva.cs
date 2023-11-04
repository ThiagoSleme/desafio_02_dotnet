



namespace desafioDois.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();

        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospede)
        {
            bool quantidadeHospedes = hospede.Count <= Suite?.Capacidade;

            if (quantidadeHospedes)
            {
                Hospedes = hospede;
            }
            else
            {
                throw new ArgumentException($"Quantidade de hospedes não pode exceder a capacidade da suite.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public int ObterQuantidadeHospedes()
        {
            int totalHospedes = Hospedes.Count;
            return totalHospedes;
        }

        public decimal CalcularDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                decimal desconto = (valorDiaria * 10) / 100;
                return valorDiaria - desconto;
            }
            return valorDiaria;
        }

    }
}