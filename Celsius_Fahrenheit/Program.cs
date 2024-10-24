using System;

class Program
{
    static void Main(string[] args)
    {
        char repetir;

        do
        {
            // Ler a temperatura em Celsius
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // Converter para Fahrenheit
            double fahrenheit = celsius * 9 / 5 + 32;

            // Mostrar o resultado
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);

            // Perguntar se o usuário deseja repetir
            Console.Write("Deseja repetir o programa? (s/n): ");
            repetir = char.Parse(Console.ReadLine());

        } while (repetir == 's' || repetir == 'S');
    }
}
