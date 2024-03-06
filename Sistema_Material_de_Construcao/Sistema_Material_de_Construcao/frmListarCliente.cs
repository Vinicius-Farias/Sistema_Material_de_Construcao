using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Sistema_Material_de_Construcao
{
	public partial class frmListarCliente : KryptonForm
	{
		frmPrincipal FrmPrincipal;
		public frmListarCliente(frmPrincipal frmPrincipal)
		{
			InitializeComponent();
			this.FrmPrincipal = frmPrincipal;
		}

		private void btnListaFuncionario_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaFuncionario();
			this.Close();
		}

		private void btnListarProdutos_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaProdutos();
			this.Close();
		}
	}
}
