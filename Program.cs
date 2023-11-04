using desafioDois.Models;


List<Pessoa> hospedes = new List<Pessoa>();

// criacao pessoa
Pessoa p1 = new(nome: "Hospede 1", sobreNome: "Fulano");
Pessoa p2 = new(nome: "Hospede 2", sobreNome: "Fulano");
Pessoa p3 = new(nome: "Hospede 3", sobreNome: "Fulano");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);



// criacao suite
Suite suite = new(tipoSuite: "Presidencial", capacidade: 5, valorDiaria: 30);


// nova reserva
Reserva novaReserva = new(diasReservados: 20);
novaReserva.CadastrarSuite(suite);
novaReserva.CadastrarHospedes(hospedes);

//
Console.WriteLine($"Quantidade de Hospedes: {novaReserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {novaReserva.CalcularDiaria()}");











