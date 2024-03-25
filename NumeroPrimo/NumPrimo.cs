using System;

class Program
{
    static bool EhPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        var limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0) return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se é primo: ");
        if(int.TryParse(Console.ReadLine(), out int numero))
        {
            bool resultado = EhPrimo(numero);
            if(resultado)
                Console.WriteLine($"{numero} é um número primo.");
            else
                Console.WriteLine($"{numero} não é um número primo.");
        }
        else
        {
            Console.WriteLine("Por favor, digite um número válido.");
        }
    }
}
