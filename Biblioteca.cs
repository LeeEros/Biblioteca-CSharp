using System;
using System.Collections.Generic;

namespace Biblioteca
{
	public class Biblioteca
	{
		public List<Cliente> clientes = new List<Cliente>();
		public List<Livro> livros = new List<Livro>();
		public List<Emprestimo> emprestimos = new List<Emprestimo>();
		
		public void EmprestarLivro(int IdCliente, int IdLivro)
		{
			Livro livro = livros.Find(livro => livro.IdLivro == IdLivro);
			
			if(livro == null)
			{
				Console.WriteLine("Livro não encontrado ou indisponível.");
				return;
			}
			
			Cliente cliente = clientes.Find(cliente => cliente.IdCliente == IdCliente);
			
			if(cliente == null)
			{
				Console.WriteLine("Cliente não encontrado");
				return;
			}
			
			Emprestimo emprestimo = new Emprestimo()
			{
				IdEmprestimo = emprestimos.Count + 1,
				ClienteEmprestimo = cliente,
				LivroEmprestado = livro,
				DataEmprestimo = DateTime.Today,
				DataDevolucaoPrevista = DateTime.Today.AddDays(7)				
			};
			
			livro.Disponivel = false;
			emprestimos.Add(emprestimo);
		}
		
				public void DevolverLivro(int idCliente, int idLivro)
			{
				Livro livro = livros.Find(livro => livro.IdLivro == idLivro);
				
				if(livro == null)
				{
					Console.Write("Livro não encontrado.");
					return;
				}
				
				Emprestimo emprestimo = emprestimos.Find(emprestimo.ClienteEmprestimo.IdCliente == idCliente 
				&& emprestimo.LivroEmprestado.IdLivro == idLivro);
				
				if(emprestimo == null)
				{
					Console.WriteLine("Cliente não encontrado");
					return;
				}
				
				emprestimo.LivroEmprestado.Disponivel = true;
				emprestimo.DataDevolucao = DateTime.Today;
				
				Console.WriteLine("Livro devolvido com sucesso!");
				
			} 
		
	}
}