using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco.UpdateFuncionario
{
	public class UpdateFuncionarioAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void UpdateFuncionario(int idFuncionario, string nome, string endereco, string bairro, string cep, string cidade, string email, DateTime nascimento, string telefone1,
			string telefone2, string rg, string cpf, string observacoes, DateTime dataCadastro)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Funcionario ");
					sql.Append("SET Nome_Funcionario = @nome, Endereco_Funcionario = @endereco, Bairro_Funcionario = @bairro, Cep_Funcionario = @cep, ");
					sql.Append("Cidade_Funcionario = @cidade, Email_Funcionario = @email, Nascimento_Funcionario = @nascimento, Telefone1_Funcionario = @telefone1, ");
					sql.Append("Telefone2_Funcionario = @telefone2, Rg_Funcionario = @rg, Cpf_Funcionario = @cpf, ");
					sql.Append("Observacoes_Funcionario = @observacoes, Data_Cadastro_Funcionario = @dataCadastro");

					sql.Append("WHERE (Id_Funcionario = @idFuncionario)");

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
					comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();

				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método UpdateFuncionario. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
