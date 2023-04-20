using System;

namespace Biblioteca
{
	class Program
	{		
		static void Main(string[] args)
		{
			//Instância o objeto biblioteca (lógica do negócio)
			Biblioteca biblioteca = new Biblioteca();
			
			biblioteca.clientes.Add(new Cliente {IdCliente = 1, Nome = "Preophahensky",
			DataNascimento = new DateTime(1971, 01, 10), TelefoneCliente = "42984437275"});
			
			biblioteca.clientes.Add(new Cliente {IdCliente = 2, Nome = "Yukihira",
			DataNascimento = new DateTime(1954, 10, 30), TelefoneCliente = "4298441515"});
			
			biblioteca.livros.Add(new Livro {IdLivro =  1010, TituloLivro = "Dom Casmurro",
			AutorLivro = "Machado de Assis", Disponivel = true});	
			
			biblioteca.livros.Add(new Livro {IdLivro =  1015, TituloLivro = "Dom Casmurro",
			AutorLivro = "Machado de Assis", Disponivel = true});	
			
			//biblioteca.EmprestarLivro(1, 1002);
			

		}
	}
}