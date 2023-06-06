using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) {
            int resultado = valor1 * valor2 * i;
            Console.WriteLine("{0} x {1} x {2} = {3}", valor1, valor2, i, resultado);
        }
    }
}