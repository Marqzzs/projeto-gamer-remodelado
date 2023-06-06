Console.WriteLine(@$"Digite a operação desejada:
'+' para somar
'-' para subtrair
'*' para multiplicar
'/' para dividir
");
char operação = char.Parse(Console.ReadLine());

Console.Write($"Digite o primeiro valor:");
float num1= float.Parse(Console.ReadLine());

Console.Write($"Digite o segundo valor valor:");
float num2= float.Parse(Console.ReadLine());

float resultado = 0;

switch (operação)
{
    case '+':
        resultado = num1 + num2;
        break;
    
    case '-':
        resultado = num1 - num2;
        break;

    case '*':
        resultado = num1 * num2;
        break;

    case '/':
        resultado = num1 / num2;
        break;

    default:
    Console.WriteLine($"operação não identificada");
        break;
}

Console.WriteLine($"O resultado é: {resultado}");

