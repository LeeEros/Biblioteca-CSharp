using System;

namespace Biblioteca
{
	public class Livro
	{
		public int Id{ get; set;}
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public bool Disponivel { get; set; }
		
		public void ExibirInformacoes()
		{
			Console.WriteLine($"ID: {Id}\nTítulo: {Titulo}\n Autor: {Autor}");
		}
		
		public void ExibirInformacoes(bool exibirDisponibilidade)
		{
			ExibirInformacoes();
			
			if(exibirDisponibilidade)
			{
				Console.WriteLine($"Disponível: {Disponivel}");
			}
		}
	}
}