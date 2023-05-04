using System;

namespace Biblioteca
{
	class Program 
	{
		static void Main (string[] args)
		{
			// Instancia o objeto biblioteca (lógica do negócio)
			Biblioteca biblioteca = new Biblioteca();			
			biblioteca.CarregarDados();		
			
			int opcao;
			
			do
			{
				Console.Clear();
				Console.WriteLine("-- Bem vindo à Biblioteca! --");
				Console.WriteLine("Selecione uma Opção");
				Console.WriteLine("1 - Cadastro");
				Console.WriteLine("2 - Consulta");
				Console.WriteLine("3 - Empréstimos");
				Console.WriteLine("4 - Devoluções");
				Console.WriteLine("0 - Sair");
				
				int.TryParse(Console.ReadLine(), out opcao);
				
				switch(opcao)
				{
					case 1:
						Cadastro(biblioteca);
						break;
					case 2: 
						Consulta(biblioteca);
						break;
					case 3:
						Emprestimo(biblioteca);
						break;
					case 4:
						Devolucoes(biblioteca);
						break;
					case 0:
						Console.WriteLine("Encerrando o sistema...");
						Console.ReadKey();
						break;					
				}
												
			} while (opcao != 0);				
		}
		
		static void Cadastro(Biblioteca biblioteca)
		{
			
		}
		
		static void Consulta(Biblioteca biblioteca)
		{
			
		}
		
		static void Emprestimo(Biblioteca biblioteca)
		{
			
		}
		
		static void Devolucoes(Biblioteca biblioteca)
		{
			
		}
	}
	
}
