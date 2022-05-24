Calculadora calc = new Calculadora(0);

do {
    Console.Clear();

    Console.WriteLine("====== Calculadora ======");
    Console.WriteLine("1) Sumar\n2) Restar\n3) Multiplicar\n4) Dividir\n5) Limpiar");

    string entrada = Console.ReadLine();
    int operacion = 0;

    while (!Int32.TryParse(entrada, out operacion) || operacion < 1 || operacion > 10) {
        Console.WriteLine("Error! Debe ingresar una opción válida");
        entrada = Console.ReadLine();
    }

    // Console.Clear();

    double num = 0;
    if (operacion != 5) {
        Console.Write("Número: ");
        entrada = Console.ReadLine();
        while (!Double.TryParse(entrada, out num)) {
            Console.WriteLine("Error! Debe ingresar un número válido");
            entrada = Console.ReadLine();
        }
    }

    switch (operacion) {
        case 1:
            calc.Sumar(num);
            break;
        case 2:
            calc.Restar(num);
            break;
        case 3:
            calc.Multiplicar(num);
            break;
        case 4:
            calc.Dividir(num);
            break;
            
        case 5:
            calc.Limpiar();
            break;
    }

    Console.WriteLine("Presione <E> para dejar de operar y mostrar el resultado. Cualquier otra tecla para seguir operando.");

} while (Console.ReadKey(false).Key != ConsoleKey.E);

Console.ReadKey(false);
Console.WriteLine("Resultado: " + calc.Resultado);
