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
	public partial class frmListaProdutos : KryptonForm
	{

		private frmPrincipal FrmPrincipal;	

		public frmListaProdutos(frmPrincipal FrmPrincipal)
		{
			InitializeComponent();

			this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
			this.FrmPrincipal = FrmPrincipal;
		}

		public void btnListaFuncionario_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaFuncionario();
			this.Close();
		}

		private void btnListaCliente_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaCliente();
			this.Close();
		}
	}
}
