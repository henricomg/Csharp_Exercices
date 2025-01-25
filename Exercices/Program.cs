int option;

do
{
    Console.WriteLine("Digite um número de opção de exercício:");
    Console.WriteLine("1. Verificar se o número é primo");
    Console.WriteLine("2. Sair");
    Console.Write("Digite a opção desejada: ");

    if (int.TryParse(Console.ReadLine(), out option))
    {
        if (option >= 1 && option <= 2)
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
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("O número deve corresponder a uma opção!");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite um número.");
    }
} while (option != 2);

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
        return "Favor informar um número.";
    };
}