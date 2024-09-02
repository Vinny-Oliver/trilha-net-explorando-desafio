// Importa o namespace System.Text, que contém classes para manipulação de texto
using System.Text;
// Importa o namespace DesafioProjetoHospedagem.Models, onde estão definidas as classes usadas neste código
using DesafioProjetoHospedagem.Models;

// Define a codificação de saída do console para UTF-8, garantindo que caracteres especiais sejam exibidos corretamente
Console.OutputEncoding = Encoding.UTF8;

// Cria uma lista de objetos do tipo Pessoa, que representará os hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

// Cria um objeto Pessoa com o nome "Hóspede 1 e 2" e o atribui à variável p1 e p2
Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

// Adiciona o objeto p1 (Hóspede 1 e 2) à lista de hóspedes
hospedes.Add(p1);
hospedes.Add(p2);

// Cria um objeto Suite com tipo "Premium", capacidade para 3 pessoas, e valor da diária de 30
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria um objeto Reserva, especificando que os hóspedes ficarão 30 dias
Reserva reserva = new Reserva(diasReservados: 30);
// Associa a suíte criada à reserva
reserva.CadastrarSuite(suite);
// Associa a lista de hóspedes à reserva
reserva.CadastrarHospedes(hospedes);

// Exibe no console a quantidade de hóspedes na reserva, chamando o método ObterQuantidadeHospedes()
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Exibe no console o valor total da diária para a reserva, chamando o método CalcularValorDiaria()
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
