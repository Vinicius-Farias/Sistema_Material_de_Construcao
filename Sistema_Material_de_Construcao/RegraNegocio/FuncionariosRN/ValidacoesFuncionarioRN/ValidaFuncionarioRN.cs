using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.SelectFuncionario;

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
				ValidaTextBox(nome, "Nome");
				ValidaTextBox(endereco, "Endereço");
				ValidaTextBox(bairro, "Bairro");
				ValidaTextBox(cep, "CEP");
				ValidaTextBox(cidade, "Cidade");
				ValidaTextBox(email, "Email");
				ValidaTextBox(telefone1, "Telefone1");
				ValidaTextBox(rg, "RG");
				ValidaTextBox(cpf, "CPF");

				ValidaDataNascimento(nascimento);
				ValidaDataCadastro(dataCadastro);

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

		private void ValidaTextBox(string textBox, string nome)
		{
			if (string.IsNullOrEmpty(textBox))
				throw new Exception($"O campo {nome} não pode ser vazio!");
		}

		private void ValidaDataNascimento(DateTime nascimento)
		{
			if (nascimento.Date == DateTime.Today || nascimento.Date > DateTime.Today)
				throw new Exception("A data de Nascimento não pode está na data atual ou maior doque ela!");
		}

		private void ValidaDataCadastro(DateTime dataCadastro)
		{
			if (dataCadastro.Date > DateTime.Today)
				throw new Exception("A data de Cadastro não pode ser maior doque a data atual!");
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
