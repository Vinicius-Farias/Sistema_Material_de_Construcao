using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco.SelectFuncionario
{
	public class PesquisarNomeFuncionarioAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisarNomeFuncionario(string nome)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Funcionario ");
					sql.Append("WHERE Nome_Funcionario LIKE '%'+@nome+'%' ");
					sql.Append("ORDER BY Id_Funcionario DESC");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método  PesquisarNomeFuncionario. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
