// Define o namespace onde a classe Pessoa está localizada
namespace DesafioProjetoHospedagem.Models;

// Define a classe Pessoa
public class Pessoa
{
    // Construtor padrão, necessário para inicializar a classe sem parâmetros
    public Pessoa() { }

    // Construtor que permite inicializar a classe com um nome
    public Pessoa(string nome)
    {
        // Atribui o valor do parâmetro 'nome' à propriedade 'Nome'
        Nome = nome;
    }

    // Construtor que permite inicializar a classe com um nome e um sobrenome
    public Pessoa(string nome, string sobrenome)
    {
        // Atribui o valor do parâmetro 'nome' à propriedade 'Nome'
        Nome = nome;
        // Atribui o valor do parâmetro 'sobrenome' à propriedade 'Sobrenome'
        Sobrenome = sobrenome;
    }

    // Propriedade que armazena o nome da pessoa
    public string Nome { get; set; }

    // Propriedade que armazena o sobrenome da pessoa
    public string Sobrenome { get; set; }

    // Propriedade calculada que retorna o nome completo em maiúsculas
    // Concatena o nome e o sobrenome, separando-os por um espaço
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}
