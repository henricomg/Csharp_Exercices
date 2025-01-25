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
                    Console.WriteLine("Você escolheu a opção 1");
                    IsPrime();
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

void IsPrime()
{
    int number;
    Console.WriteLine("Informe o número a verificar se é primo:");
    int.TryParse(Console.ReadLine(), out number);


}