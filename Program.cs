using System;
using System.Collections.Generic;

class Program
{
	static List<string> historico = new List<string>(); // Lista para armazenar histórico
	
	static void Main(){
	
		
		while (true)
	
		{
		Console.Clear();
		Console.WriteLine("-----------------------------------------");
		Console.WriteLine("Calculadora Do Carlos 2025");
		Console.WriteLine("-----------------------------------------");
		Console.WriteLine("1 - Somar");
		Console.WriteLine("2 - Subtrair");
		Console.WriteLine("3 - Multiplicar");
		Console.WriteLine("4 - Dividir");
		Console.WriteLine("5 - Tabuada");
		Console.WriteLine("6 - Histórico");
		Console.WriteLine("S - Sair");
		Console.WriteLine("-----------------------------------------");

		Console.Write("Escolha uma opção: ");

		string opcao = Console.ReadLine().ToUpper();

		if (opcao == "S")
			break;

		Console.WriteLine("-----------------------------------------");



		float numero1;
		float numero2;
			
		double resultado = 0;
		switch (opcao)
		{
			case "1":
				numero1 = EscolhaNumero();
				numero2 = EscolhaNumero();
				resultado = numero1 + numero2;
				RegistrarOperacao($"{numero1} + {numero2} = {resultado}");
				MensagemResultado(resultado);
				break;
			case "2":
				numero1 = EscolhaNumero();
				numero2 = EscolhaNumero();
				resultado = numero1 - numero2;
				RegistrarOperacao($"{numero1} - {numero2} = {resultado}");
				MensagemResultado(resultado);
				break;
			case "3":
				numero1 = EscolhaNumero();
				numero2 = EscolhaNumero();
				resultado = numero1 * numero2;
				RegistrarOperacao($"{numero1} * {numero2} = {resultado}");
				MensagemResultado(resultado);
				break;
			case "4":
				numero1 = EscolhaNumero();
				numero2 = EscolhaNumero();
				if (numero1 == 0 || numero2 == 0)
				{
					Console.WriteLine("Não pode ter divisão por zero");
				}
				else
				{
					resultado = numero1 / numero2;
					RegistrarOperacao($"{numero1} / {numero2} = {resultado}");
					MensagemResultado(resultado);
				}
				break;
			case "5":
				numero1 = EscolhaNumero();
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine(i + " X " + numero1 + " = " + Math.Round(numero1*i, 2) );
				};
				break;
			case "6":
				ExibirHistorico();
				break;
			default:
				Console.WriteLine("\nOpção inválida!");
				Console.ReadLine();
				continue;
		}

		static float EscolhaNumero()
		{
			float numero = 0;

			Console.Write("Digite o Numero: ");
			numero = Convert.ToInt32(Console.ReadLine());

			return numero;
		}

		void MensagemResultado(double resultado){
		Console.WriteLine("-----------------------------------------");
		Console.WriteLine($"Resultado: {resultado}");
		Console.WriteLine("-----------------------------------------");
		}
		
		static void RegistrarOperacao(string operacao)
		{
			historico.Add(operacao); // Adiciona a operação ao histórico
		}
		
		static void ExibirHistorico()
		{
			Console.WriteLine("\n--------- Histórico de Operações ---------");
			if (historico.Count == 0)
			{
				Console.WriteLine("Nenhuma operação realizada ainda.");
			}
			else
			{
				foreach (var op in historico)
				{
					Console.WriteLine(op);
				}
			}
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Pressione ENTER para continuar...");
			Console.ReadLine();
		}
		Console.Write("Deseja continuar? (S/N): ");
		string opcaoContinuar = Console.ReadLine().ToUpper();

		if (opcaoContinuar != "S")
			break;
	
	}
	}
}
	


