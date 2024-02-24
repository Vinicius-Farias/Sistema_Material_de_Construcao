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
		frmProdutos FrmProdutos;
		frmFuncionarios FrmFuncionarios;
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
					FrmListaProdutos.Size = new System.Drawing.Size(1164, 600);
					
				if(FrmFuncionarios != null)
					FrmFuncionarios.Size = new System.Drawing.Size(1164, 600);

				if (FrmProdutos != null)
					FrmProdutos.Size = new System.Drawing.Size(1164, 600);

				timerResponsivo.Stop();
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

		private void btnProdutos_Click(object sender, EventArgs e)
		{

			if (FrmProdutos == null)
			{
				FrmProdutos = new frmProdutos();
				FrmProdutos.FormClosed += FrmProdutos_FormClosed;
				FrmProdutos.MdiParent = this;
				FrmProdutos.TopLevel = false;
				FrmProdutos.Dock = DockStyle.Fill;
				FrmProdutos.Show(); 
			} 
			else
			{
				FrmProdutos.Activate();
			}

		}

		private void FrmProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmProdutos = null;
		}

		private void btnFuncionario_Click(object sender, EventArgs e)
		{
			if (FrmProdutos == null)
			{
				FrmFuncionarios = new frmFuncionarios();
				FrmFuncionarios.FormClosed += FrmFuncionarios_FormClosed;
				FrmFuncionarios.MdiParent = this;
				FrmFuncionarios.TopLevel = false;
				FrmFuncionarios.Dock = DockStyle.Fill;
				FrmFuncionarios.Show();
			}
			else
			{
				FrmFuncionarios.Activate();
			}
		}

		private void FrmFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmFuncionarios = null;
		}
	}
}
