using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.VerificaCampos
{
	internal class VerificaCamposRN
	{
		internal static void ValidaTextBox(string textBox, string nome)
		{
			if (string.IsNullOrEmpty(textBox))
				throw new Exception($"O campo {nome} não pode ser vazio!");
		}

		internal static void ValidaDataNascimento(DateTime nascimento, string nome)
		{
			if (nascimento.Date == DateTime.Today || nascimento.Date > DateTime.Today)
				throw new Exception($"A data de {nome} não pode está na data atual ou maior doque ela!");
		}

		internal static void ValidaDataCadastro(DateTime dataCadastro, string nome)
		{
			if (dataCadastro.Date > DateTime.Today)
				throw new Exception($"A data de {nome} não pode ser maior doque a data atual!");
		}
	}
}
