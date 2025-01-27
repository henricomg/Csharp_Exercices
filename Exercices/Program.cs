int option;

do
{
    Console.WriteLine("Digite um número de opção de exercício:");
    Console.WriteLine("1. Verificar se o número é primo");
    Console.WriteLine("2. Imprimir uma sequência de Fibonacci");
    Console.WriteLine("3. Sair");
    Console.Write("Digite a opção desejada: ");

    if (int.TryParse(Console.ReadLine(), out option))
    {
        if (option >= 1 && option <= 3)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Você escolheu a opção 1");
                    Console.WriteLine(IsPrime());
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Você escolheu a opção 2");
                    Fibonacci();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("O número deve corresponder a uma opção");
            Console.ReadKey();
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite um número.");
        Console.ReadKey();
        Console.Clear();
    }
} while (option != 3);

string IsPrime()
{
    int number;
    Console.WriteLine("Informe o número a verificar se é primo:");
    if(int.TryParse(Console.ReadLine(), out number))
    {
        if (number % 2 == 1 && number % number == 0)
        {
            return "Sim, ele é primo";
        }
        else
        {
            return "Não, não é primo";
        }
    }
    else
    {
        return "Favor informar um número inteiro.";
    };
}

void Fibonacci()
{
    int qtd, soma, numA = 1, numB = 0, count = 0;
    Console.WriteLine("Quantos números gostaria de gerar?");
    if (int.TryParse(Console.ReadLine(), out qtd))
    {
        Console.WriteLine("Reposta:");
        while(count < qtd)
        {
            Console.Write(numA+",");
            soma = numA + numB;
            numB = numA;
            numA = soma;
            count++;
        }
    }
    else
    {
        Console.WriteLine("Favor informar um número inteiro.");
    };
}