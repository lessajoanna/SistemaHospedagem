using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

try
{

    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = new List<Pessoa>();

    Pessoa p1 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");
    Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Silva");
    Pessoa p3 = new Pessoa(nome: "Joanna", sobrenome: "Lessa");

    hospedes.Add(p1);
    hospedes.Add(p2);
    // hospedes.Add(p3);

    // Cria a suíte
    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 150);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: 10);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Suíte {suite.TipoSuite} para até {suite.Capacidade} hóspedes");
    Console.WriteLine($"Reserva para: {reserva.ObterQuantidadeHospedes()} hóspedes");
    Console.WriteLine($"Valor da diária: R$ {suite.ValorDiaria}");
    Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
    Console.WriteLine($"Total a pagar: R$ {reserva.CalcularValorDiaria()}");
}
catch (Exception e)
{
    Console.WriteLine($"Erro: {e.Message}");
}