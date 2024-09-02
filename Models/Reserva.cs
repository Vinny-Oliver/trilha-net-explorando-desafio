namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        // Propriedade que armazena a lista de hóspedes da reserva
        public List<Pessoa> Hospedes { get; set; }

        // Propriedade que armazena a suíte associada à reserva
        public Suite Suite { get; set; }

        // Propriedade que armazena o número de dias reservados
        public int DiasReservados { get; set; }

        // Construtor padrão, necessário para inicializar a classe sem parâmetros
        public Reserva() { }

        // Construtor que permite inicializar a reserva com um número de dias reservados
        public Reserva(int diasReservados)
        {
            // Atribui o valor recebido ao número de dias reservados
            DiasReservados = diasReservados;
        }

        // Método para cadastrar os hóspedes na reserva
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a capacidade da suíte é suficiente para o número de hóspedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                // Se a capacidade for suficiente, os hóspedes são atribuídos à propriedade Hospedes
                Hospedes = hospedes;
            }
            else
            {
                // Se a capacidade não for suficiente, lança uma exceção com uma mensagem explicativa
                throw new ArgumentException("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        // Método para cadastrar a suíte na reserva
        public void CadastrarSuite(Suite suite)
        {
            // Atribui a suíte recebida à propriedade Suite
            Suite = suite;
        }

        // Método para obter a quantidade de hóspedes na reserva
        public int ObterQuantidadeHospedes()
        {
            // Retorna o número de hóspedes na lista Hospedes
            // Se a lista for nula (não houver hóspedes), retorna 0
            return Hospedes?.Count ?? 0;
        }

        // Método para calcular o valor total da diária com base nos dias reservados
        public decimal CalcularValorDiaria()
        {
            // Calcula o valor total da diária multiplicando o número de dias reservados pelo valor da diária da suíte
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Verifica se os dias reservados são 10 ou mais para aplicar um desconto de 10%
            if (DiasReservados >= 10)
            {
                // Aplica o desconto de 10% ao valor total da diária
                valor *= 0.9m;
            }

            // Retorna o valor total da diária (com ou sem desconto)
            return valor;
        }
    }
}
