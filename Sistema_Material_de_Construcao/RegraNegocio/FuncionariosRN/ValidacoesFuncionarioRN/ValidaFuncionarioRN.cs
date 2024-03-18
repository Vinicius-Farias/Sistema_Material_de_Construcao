using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.SelectFuncionario;
using RegraNegocio.VerificaCampos;

namespace RegraNegocio.FuncionariosRN.ValidacoesFuncionarioRN
{
	public class ValidaFuncionarioRN 
	{
		private DataTable dadosTabela;
		private AlteraFuncionarioRN AlteraFuncionario;
		private SalvarFuncionariosRN SalvarFuncionarios;
		private ValidaAlteraFuncionarioRN ValidaAlteraFuncionario;
		private PesquisarRGFuncionarioAD PesquisarRGFuncionario;
		private PesquisarCpfFuncionarioAD PesquisarCpfFuncionario;

		public  void ValidaFuncionario(int idFuncionario, string nome, string endereco, string bairro, string cep, string cidade, string email, DateTime nascimento,
			string telefone1, string telefone2, string rg, string cpf, string observacoes, DateTime dataCadastro)
		{
			try
			{
				VerificaCamposRN.ValidaTextBox(nome, "Nome");
				VerificaCamposRN.ValidaTextBox(endereco, "Endereço");
				VerificaCamposRN.ValidaTextBox(bairro, "Bairro");
				VerificaCamposRN.ValidaTextBox(cep, "CEP");
				VerificaCamposRN.ValidaTextBox(cidade, "Cidade");
				VerificaCamposRN.ValidaTextBox(email, "Email");
				VerificaCamposRN.ValidaTextBox(telefone1, "Telefone1");
				VerificaCamposRN.ValidaTextBox(rg, "RG");
				VerificaCamposRN.ValidaTextBox(cpf, "CPF");

				VerificaCamposRN.ValidaDataNascimento(nascimento, "Nascimento");
				VerificaCamposRN.ValidaDataCadastro(dataCadastro, "Cadastro");

				if (idFuncionario > 0)
				{
					ValidaAlteraFuncionario = new ValidaAlteraFuncionarioRN();
					ValidaAlteraFuncionario.ValidaAlteraFuncionario(idFuncionario, rg, cpf);

					AlteraFuncionario = new AlteraFuncionarioRN();
					AlteraFuncionario.AlteraFuncionario(idFuncionario, nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2,
					rg, cpf, observacoes, dataCadastro);
				}
				else
				{
					ValidaRG(rg);
					ValidaCPF(cpf);

					SalvarFuncionarios = new SalvarFuncionariosRN();
					SalvarFuncionarios.salvarFuncionarioRN(nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2, rg, cpf, observacoes, dataCadastro);
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void ValidaRG(string rg)
		{
			PesquisarRGFuncionario = new PesquisarRGFuncionarioAD();
			dadosTabela = new DataTable();
			dadosTabela = PesquisarRGFuncionario.PesquisarRGFuncionario(rg);

			if (dadosTabela.Rows.Count > 0)
				throw new Exception("RG já cadastrado tente outro!");
			
		}

		public void ValidaCPF(string cpf)
		{
			PesquisarCpfFuncionario = new PesquisarCpfFuncionarioAD();
			dadosTabela = new DataTable();
			dadosTabela = PesquisarCpfFuncionario.PesquisaCpfFuncionario(cpf);

			if (dadosTabela.Rows.Count > 0)
				throw new Exception("CPF já cadastrado tente outro!");
			
		}
		
	}
}
