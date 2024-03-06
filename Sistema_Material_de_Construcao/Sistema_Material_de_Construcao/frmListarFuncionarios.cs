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
	public partial class frmListarFuncionarios : KryptonForm
	{
		frmPrincipal FrmPrincipal;
		public frmListarFuncionarios(frmPrincipal frmPrincipal)
		{
			InitializeComponent();
			this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
			this.FrmPrincipal = frmPrincipal;
		}

		private void btnBusca_Click(object sender, EventArgs e)
		{

		}

		private void btnListarProdutos_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaProdutos();
			this.Close();
		}

		private void btnListaCliente_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaCliente();
			this.Close();
		}
	}
}
