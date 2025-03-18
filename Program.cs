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
	Console.WriteLine("5 - Tabuada");
	Console.WriteLine("S - Sair");
	Console.WriteLine("-----------------------------------------");

	Console.Write("Escolha uma opção: ");

	string opcao = Console.ReadLine().ToUpper();

	if (opcao == "S")
		break;
	
	Console.WriteLine("-----------------------------------------");

	static double EscolhaNumero()
	{
	double numero = 0;

	Console.Write("Digite o Numero: ");
	numero = Convert.ToInt32(Console.ReadLine());

	return numero;
	}

	double numero1;
	double numero2;
		
	double resultado = 0;
	switch (opcao)
	{
		case "1":
			numero1 = EscolhaNumero();
			numero2 = EscolhaNumero();
			resultado = numero1 + numero2;
			MensagemResultado(resultado);
			break;
		case "2":
			numero1 = EscolhaNumero();
			numero2 = EscolhaNumero();
			resultado = numero1 - numero2;
			MensagemResultado(resultado);
			break;
		case "3":
			numero1 = EscolhaNumero();
			numero2 = EscolhaNumero();
			resultado = numero1 * numero2;
			MensagemResultado(resultado);
			break;
		case "4":
			numero1 = EscolhaNumero();
			numero2 = EscolhaNumero();
			resultado = numero1 / numero2;
			MensagemResultado(resultado);
			break;
		case "5":
			numero1 = EscolhaNumero();
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i + " X " + numero1 + " = " + Math.Round(numero1*i, 2) );
			};
			break;
		default:
			Console.WriteLine("\nOpção inválida!");
			Console.ReadLine();
			continue;
	}

	void MensagemResultado(double resultado){
	Console.WriteLine("-----------------------------------------");
	Console.WriteLine($"Resultado: {resultado}");
	Console.WriteLine("-----------------------------------------");
	}
	Console.Write("Deseja continuar? (S/N): ");
	string opcaoContinuar = Console.ReadLine().ToUpper();

	if (opcaoContinuar != "S")
		break;
}



