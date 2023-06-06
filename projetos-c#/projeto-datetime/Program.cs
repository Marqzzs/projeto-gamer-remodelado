//progama para calcular a idade com datetime
int ano;
int idade;
int semanas;
int anoAtual = DateTime.Now.Year;
Console.WriteLine($"Digite o ano de nascimento:");
ano = int.Parse(Console.ReadLine());

idade = anoAtual - ano;
semanas = idade * 52;

Console.WriteLine($"A idade em anos é: {idade}, e em semanas é: {semanas}");


