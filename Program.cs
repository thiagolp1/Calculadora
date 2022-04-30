string opcaoDesejada;
double a, b, resultado;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        
        Console.WriteLine("soma A + B \n");
        Console.WriteLine("Digite os valores");

        Console.Write("A =");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("B =");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a + b;
        Console.WriteLine($"{a} + {b} é {resultado}");
        
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;
    case "-":
        Console.WriteLine("subtração A - B \n");
        Console.WriteLine("Digite os valores");

        Console.Write("A =");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("B =");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a - b;
        Console.WriteLine($"{a} - {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;
    case "*":
        
        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
    case "/":
        Console.WriteLine("divisão A / B \n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("não é possivel dividir 0");
        }
        else 
        {
            resultado = a / b;
            Console.WriteLine($"{a} multiplicado por {b} é {resultado}");
        }
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");