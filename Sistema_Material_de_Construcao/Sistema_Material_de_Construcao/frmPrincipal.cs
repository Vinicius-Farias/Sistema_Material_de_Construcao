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
	public partial class frmPrincipal : KryptonForm
	{
		frmListaProdutos FrmListaProdutos;
		public frmPrincipal()
		{
			InitializeComponent();
			TelaInicio();
		}

		bool menuExpand = false;

		private void TelaInicio()
		{
			if (FrmListaProdutos == null)
			{
				FrmListaProdutos = new frmListaProdutos();
				FrmListaProdutos.FormClosed += FrmListaProdutos_FormClosed;
				FrmListaProdutos.MdiParent = this;
				FrmListaProdutos.TopLevel = false;
				FrmListaProdutos.Dock = DockStyle.Fill;
				FrmListaProdutos.Show();
				
			}
			else
			{
				FrmListaProdutos.Activate();
				if (pnlMenu.Width <= 60)
				{
					FrmListaProdutos.Size = new System.Drawing.Size(1164, 600);
				}
			}
			
		}

		

		private void menuTransicao_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				pnlMenu.Width += 10;
				if (pnlMenu.Width >= 201)
				{
					menuTransicao.Stop();
					menuExpand = true;
				}
			}
			else
			{
				pnlMenu.Width -= 10;
				if (pnlMenu.Width <= 60)
				{
					menuTransicao.Stop();
					menuExpand = false;
				}
			}
			
		}

		private void FrmListaProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmListaProdutos = null;
		}

		private void timerResponsivo_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				if (FrmListaProdutos != null)
				{
					FrmListaProdutos.Size = new System.Drawing.Size(1164, 600);
					timerResponsivo.Stop();
				}
			}
				
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			menuTransicao.Start();
			timerResponsivo.Start();
			
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			TelaInicio();
		}

		
	}
}
