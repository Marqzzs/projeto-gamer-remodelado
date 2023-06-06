//projeto de idade

//entrada de dados
//nome
//idade

Console.WriteLine(@$"
-----------------------
/   Bora ver a          /
/   Sua idade amigão    /
/   de diversas formas  /
-----------------------
");

Console.WriteLine($"Por favor, digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo {nome} :)");

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

float meses = idade * 12;

float dias = idade * 365;

float horas = dias* 24;

float minutos = horas * 60;

Console.WriteLine($"Calculando:");


Console.WriteLine($"Sua idade em meses: {meses}, em dias: {dias}, em horas: {horas} e em minutos: {minutos}");



Console.WriteLine($"Muito obrigado por usar o nosso sistema {nome} inte a proxima");











