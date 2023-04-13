using System;
using System.Collections.Generic;

namespace Biblioteca
{
	public class Biblioteca
	{
		public List<Cliente> clientes = new List<Cliente>();
		public List<Livro> livros = new List<Livro>();
		public List<Emprestimo> emprestimos = new List<Emprestimo>();
		
		public void EmprestarLivro(int idCliente, int idLivro)
		{
			Livro livro = livros.Find(livro => livro.Id == idLivro);
			
			if(livro == null)
			{
				Console.WriteLine("Livro não encontrado ou indisponível.");
				return;
			}
			
			Cliente cliente = clientes.Find(c => c.Id == IdCliente);
			
			if(cliente == null)
			{
				Console.WriteLine("Cliente não encontrado");
				return;
			}
			
			Emprestimo emprestimo = new Emprestimo()
			{
				Id = emprestimos.Count + 1,
				ClienteEmprestimo = cliente,
				LivroEmprestado = livro,
				DataEmprestimo = DateTime.Today,
				DataDevolucaoPrevista = DateTime.Today.AddDays(7)				
			};
			
			livro.Disponivel = false;
			emprestimos.Add(emprestimo);
			
			Console.WriteLine("Livro empretado com sucesso");
		}
	}
}