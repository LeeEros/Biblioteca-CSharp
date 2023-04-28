using System;
using System.Globalization;

namespace Biblioteca{

	class Program{
		static void Main(string[]args){
			Biblioteca biblioteca = new Biblioteca();

			biblioteca.clientes.Add(new Cliente{Id = 1, Nome = "Jason",DataNascimento = new DateTime(2003,09,22),Telefone = "42 99818-4927"});
			biblioteca.clientes.Add(new Cliente{Id = 2, Nome = "Pirelson",DataNascimento = new DateTime(2000,12,01),Telefone = "49 97419-1419"});

			biblioteca.livros.Add(new Livro{Id = 1, Titulo = "Scrum", Autor = "Júlio Cezar", Disponivel = true});
			biblioteca.livros.Add(new Livro{Id = 2, Titulo = "SQL", Autor = "Neymar Jr", Disponivel = true});
			
			biblioteca.CarregarDados();

			biblioteca.EmprestarLivro(1, 1002);
			biblioteca.SalvarDados();
			
			biblioteca.EmprestarLivro(2, 1002);
			biblioteca.SalvarDados();
			
			biblioteca.DevolverLivro(2, 1002);
			biblioteca.SalvarDados();
		}
	}
}