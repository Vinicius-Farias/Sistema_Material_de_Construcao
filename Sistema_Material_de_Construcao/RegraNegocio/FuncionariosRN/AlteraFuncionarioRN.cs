﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.UpdateFuncionario;

namespace RegraNegocio.FuncionariosRN
{
	internal class AlteraFuncionarioRN
	{
		UpdateFuncionarioAD AlteraFuncionarioAD;

		internal void AlteraFuncionario(int idFuncionario, string nome, string endereco, string bairro, string cep, string cidade, string email, DateTime nascimento,
			string telefone1, string telefone2, string rg, string cpf, string observacoes, DateTime dataCadastro)
		{
			try
			{
				AlteraFuncionarioAD = new UpdateFuncionarioAD();
				AlteraFuncionarioAD.UpdateFuncionario(idFuncionario, nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2, 
					rg, cpf, observacoes, dataCadastro);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
