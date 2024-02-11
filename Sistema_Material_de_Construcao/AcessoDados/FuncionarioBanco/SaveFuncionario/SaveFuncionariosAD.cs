using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco
{
	public class SaveFuncionariosAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		public void SaveFuncionarios(string nome, string endereco, string bairro, string cep, string cidade, string email, DateTime nascimento, string telefone1, 
			string telefone2, string rg, string cpf, string observacoes, DateTime dataCadastro)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Funcionario (Nome_Funcionario, Endereco_Funcionario, Bairro_Funcionario, Cep_Funcionario, Cidade_Funcionario, ");
					sql.Append("Email_Funcionario, Nascimento_Funcionario, Telefone1_Funcionario, Telefone2_Funcionario Rg_Funcionario, Cpf_Funcionario, ");
					sql.Append("Observacoes_Funcionario, Data_Cadastro_Funcionario)");

					sql.Append("VALUES (@nome, @endereco, @bairro, @cep, @cidade, @email, @nascimento, @telefone1, @telefone2, @rg, @cpf, @observacoes, @dataCadastro)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
					comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
					comandoSql.Parameters.Add(new SqlParameter("@email", email));
					comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
					comandoSql.Parameters.Add(new SqlParameter("@telefone1", telefone1));
					comandoSql.Parameters.Add(new SqlParameter("@telefone2", telefone2));
					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@observacoes", observacoes));
					comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SalvarFuncionario, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
	}
}
