using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ConectionBanco
{
	internal class Conexao
	{
		private static string conexao = @"Data Source=DESKTOP-GG2GURI\SQLEXPRESS;Initial Catalog=Construcao;User ID=SA;Password=Farias123.;";

		internal static string stringConexao
		{
			get { return conexao; }
		}
	}
}
