using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Material_de_Construcao
{
	internal class FuncionarioIT
	{
		internal static int idFuncionario { get; set; }
		internal static string nome { get; set; }
		internal static string endereco { get; set; }
		internal static string bairro { get; set; }
		internal static string cep { get; set; }
		internal static string cidade { get; set; }
		internal static string email { get; set; }
		internal static DateTime nascimento { get; set; }
		internal static string telefone1 { get; set; }
		internal static string telefone2 { get; set; }
		internal static string observacoes { get; set; }
		internal static DateTime dataCadastro { get; set; }

		private static string rg;

		private static string cpf;

		internal static string Rg
		{
			get { return rg; }
			set { rg = value; }
		}

		internal static string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}

	}
}
