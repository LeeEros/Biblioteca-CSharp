using System;

namespace Biblioteca
{
	public class Funcionario : Pessoa
	{
		public int IdFuncionario{ get; set; }
		
		public string CargoFuncionario{ get; set; }
		
		public DateTime DataAdmissao{ get; set; }
	}
}