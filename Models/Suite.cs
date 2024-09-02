// Define o namespace onde a classe Suite está localizada
namespace DesafioProjetoHospedagem.Models
{
    // Define a classe Suite
    public class Suite
    {
        // Construtor padrão, necessário para inicializar a classe sem parâmetros
        public Suite() { }

        // Construtor que permite inicializar a classe com os valores tipoSuite, capacidade e valorDiaria
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            // Atribui o valor do parâmetro 'tipoSuite' à propriedade 'TipoSuite'
            TipoSuite = tipoSuite;
            // Atribui o valor do parâmetro 'capacidade' à propriedade 'Capacidade'
            Capacidade = capacidade;
            // Atribui o valor do parâmetro 'valorDiaria' à propriedade 'ValorDiaria'
            ValorDiaria = valorDiaria;
        }

        // Propriedade que armazena o tipo da suíte (ex: Luxo, Standard, etc.)
        public string TipoSuite { get; set; }

        // Propriedade que armazena a capacidade máxima da suíte (número de hóspedes que ela comporta)
        public int Capacidade { get; set; }

        // Propriedade que armazena o valor da diária da suíte
        public decimal ValorDiaria { get; set; }
    }
}
