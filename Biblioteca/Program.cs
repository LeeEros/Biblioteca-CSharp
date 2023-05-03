using System;

namespace Biblioteca
{
	class Program 
	{
		static void Main (string[] args)
		{
			// Instancia o objeto biblioteca (lógica do negócio)
			Biblioteca biblioteca = new Biblioteca();
			
			// adicionando clientes
			biblioteca.clientes.Add(new Cliente {Id = 1, Nome = "Jaspion",
			DataNascimento = new DateTime(1971, 01, 10), Telefone = "4133715858"});
			
			biblioteca.clientes.Add(new Cliente {Id = 2, Nome = "Satangos",
			DataNascimento = new DateTime(1954, 10, 30), Telefone = "4133715858"});
			
			biblioteca.clientes.Add(new Cliente {Id = 3, Nome = "Akira",
			DataNascimento = new DateTime(1970, 11, 28), Telefone = "6666666666"});
			
			// adicionando livros
			biblioteca.livros.Add(new Livro {Id = 1001, Titulo = "Dom Casrrumo",
			Autor = "Machado de Assis", Disponivel = true});
			
			biblioteca.livros.Add(new Livro {Id = 1002, Titulo = "O Cortiço",
			Autor = "Aluíso Azevedo", Disponivel = true});
			
			biblioteca.CarregarDados();
			// emprestando o livro
			biblioteca.EmprestarLivro(3, 1002);
			biblioteca.SalvarDados();
			
			//Teste emprestimo
			//biblioteca.EmprestarLivro(1, 1002);					
			
			//devolvendo o livro
			biblioteca.DevolverLivro(1, 1001);
			
			biblioteca.SalvarDados();											
		}
	}
	
}
