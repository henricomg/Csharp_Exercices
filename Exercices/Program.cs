using System.Collections.Immutable;
using System.Text;

int option;

do
{
    Console.WriteLine("Digite um número de opção de exercício:");
    Console.WriteLine("1. Verificar se o número é primo");
    Console.WriteLine("2. Imprimir uma sequência de Fibonacci");
    Console.WriteLine("3. Imprimir uma pirâmide no console");
    Console.WriteLine("4. Calculo de IMC");
    Console.WriteLine("5. Sair");
    Console.Write("Digite a opção desejada: ");

    if (int.TryParse(Console.ReadLine(), out option))
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
            case 3:
                Console.WriteLine("");
                Console.WriteLine("Você escolheu a opção 3");
                Pyramid();
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                Console.WriteLine("");
                Console.WriteLine("Você escolheu a opção 4");
                IMC();
                Console.Clear();
                break;
            case 5:
                Console.WriteLine("Sair..");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Digite um número.");
        Console.ReadKey();
        Console.Clear();
    }
} while (option != 5);

string IsPrime()
{
    Console.Clear();
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
    Console.Clear();

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

void Pyramid()
{
    Console.Clear();

    int heigth;
    Console.WriteLine("Qual será a altura da sua pirâmide?");
    if (int.TryParse(Console.ReadLine(), out heigth))
    {
        // for para cada linha
        for (int i = 1; i <= heigth; i++)
        {
            StringBuilder sb = new StringBuilder();

            //Imprime os espaços
            sb.Append(' ', heigth - i);

            //imprime os '#'
            sb.Append('#', 2 * i - 1);

            //nova linha
            Console.WriteLine(sb.ToString());
        }
    }
    else
    {
        Console.WriteLine("Favor informar um número inteiro.");
    };
}

void IMC()
{
    Console.Clear();

    string path = "imc.txt";
    string option = "";
    while(option != "3")
    {
        Console.WriteLine("------------IMC--------------");
        Console.WriteLine("1 - Adicionar registro");
        Console.WriteLine("2 - Consultar registros");
        Console.WriteLine("3 - Voltar para o menu");
        Console.WriteLine("-----------------------------");

        Console.WriteLine();
        Console.WriteLine("Escolha uma opção:");
        option = Console.ReadLine();
        Console.Clear();

        if (option == "1")
        {
            string name, result;
            int age;
            double weight, height, imc;

            Console.WriteLine("");
            Console.WriteLine("Informe o nome: ");
            name = Console.ReadLine();
            Console.WriteLine("Informe a idade: ");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Informe a altura: ");
            double.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("Informe o peso: ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine();
            Console.WriteLine("Calculando o IMC..");
            Console.WriteLine();
            imc = weight / (height * height);
            Console.WriteLine("Resultado: " + imc);
            if(imc < 18.5)
            {
                result = "Peso abaixo do normal";
            }else if (imc >= 18.50 && imc < 25)
            {
                result = "Peso normal";
            }else if (imc >= 25 && imc < 30)
            {
                result = "Sobre peso";
            }else if (imc >= 30 && imc < 35)
            {
                result = "Grau de obesidade 1";
            }else if (imc >= 35 && imc < 40)
            {
                result = "Grau de obesidade II";
            }
            else
            {
                result = "Grau de obesidade III";
            }
            Console.WriteLine(result);
            Console.ReadKey();
            Console.Clear();

            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("==============================");
            sw.WriteLine("Name: {0}", name);
            sw.WriteLine("Age: {0}", age);
            sw.WriteLine("Height: {0}", height);
            sw.WriteLine("Weight: {0}", weight);
            sw.WriteLine("Imc: {0}", imc);
            sw.WriteLine("");
            sw.WriteLine("{0}", result);
            sw.Close();
        }

        if(option == "2")
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.ReadLine();
            Console.Clear();
        }
    }
}