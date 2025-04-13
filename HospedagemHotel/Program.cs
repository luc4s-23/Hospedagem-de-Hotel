using HospedagemHotel.Models;
using HospedagemHotel.Models.Reserva;

List <Pessoa> Hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa("Lucas","Daniel");
Pessoa pessoa2 = new Pessoa("Luana","Magno");

Hospedes.Add(pessoa1);
Hospedes.Add(pessoa2);

Suite suite = new Suite("Premium", 2, 30);

Reserva reserva = new Reserva(diasReservados: 3);

reserva.CadastrarHospede(Hospedes);
reserva.CadastrarSuite(suite);

Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Total: {reserva.CalcularValorTotal():C}");