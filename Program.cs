while (true)
{
	Console.Clear();
	Console.WriteLine("-----------------------------------------");
	Console.WriteLine("Calculadora Tabajara 2025");
	Console.WriteLine("-----------------------------------------");
	Console.WriteLine("1 - Somar");
	Console.WriteLine("2 - Subtrair");
	Console.WriteLine("3 - Multiplicar");
	Console.WriteLine("4 - Dividir");
	Console.WriteLine("S - Sair");
	Console.WriteLine("-----------------------------------------");

	Console.Write("Escolha uma opção: ");

	string opcao = Console.ReadLine().ToUpper();

	if (opcao == "S")
		break;
	
	Console.WriteLine("-----------------------------------------");

	Console.Write("Digite o primeiro número: ");
	int numero1 = Convert.ToInt32(Console.ReadLine());

	Console.Write("Digite o segundo número: ");
	int numero2 = Convert.ToInt32(Console.ReadLine());

	int resultado = 0;

	switch (opcao)
	{
		case "1":
			resultado = numero1 + numero2;
			break;
		case "2":
			resultado = numero1 - numero2;
			break;
		case "3":
			resultado = numero1 * numero2;
			break;
		case "4":
			resultado = numero1 / numero2;
			break;
		default:
			Console.WriteLine("\nOpção inválida!");
			Console.ReadLine();
			continue;
	}

	Console.WriteLine("-----------------------------------------");
	Console.WriteLine($"Resultado: {resultado}");
	Console.WriteLine("-----------------------------------------");

	Console.Write("Deseja continuar? (S/N): ");
	string opcaoContinuar = Console.ReadLine().ToUpper();

	if (opcaoContinuar != "S")
		break;
}