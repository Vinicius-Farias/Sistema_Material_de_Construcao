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
		private frmListaProdutos FrmListaProdutos;
		private frmProdutos FrmProdutos;
		private frmFuncionarios FrmFuncionarios;
		private frmClientes FrmClientes;
		private frmCategoria FrmCategoria;
		private frmUnidades FrmUnidades;
		private frmListarFuncionarios FrmListarFuncionarios;
		private frmListarCliente FrmListarCliente;

		private Image menuFechado = Properties.Resources.aplicativos__1_;
		private Image menuAberto = Properties.Resources.excluir_aplicativos__1_;
		public frmPrincipal()
		{
			InitializeComponent();
			ChamaListaProdutos();
		}

		bool menuExpand = false;

		private void menuTransicao_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				pnlMenu.Width += 10;
				if (pnlMenu.Width >= 201)
				{
					menuTransicao.Stop();
					menuExpand = true;
					btnMenu.Values.Image = menuAberto;
				}
			}
			else
			{
				pnlMenu.Width -= 10;
				if (pnlMenu.Width <= 60)
				{
					menuTransicao.Stop();
					menuExpand = false;
					btnMenu.Values.Image =  menuFechado;
				}
			}
			
		}

		private void timerResponsivo_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				if (FrmListaProdutos != null)
					FrmListaProdutos.Size = new System.Drawing.Size(1164, 600);

				if (FrmFuncionarios != null)
					FrmFuncionarios.Size = new System.Drawing.Size(1164, 600);

				if (FrmProdutos != null)
					FrmProdutos.Size = new System.Drawing.Size(1164, 600);

				if (FrmClientes != null)
					FrmClientes.Size = new System.Drawing.Size(1164, 600);

				if (FrmListarFuncionarios != null)
					FrmListarFuncionarios.Size = new System.Drawing.Size(1164, 600);

				if (FrmListarCliente != null)
					FrmListarCliente.Size = new System.Drawing.Size(1164, 600);

				timerResponsivo.Stop();
			}

		}

		public void ChamaListaCliente()
		{
			if (FrmListarCliente == null)
			{
				FrmListarCliente = new frmListarCliente(this);
				FrmListarCliente.FormClosed += FrmListarCliente_FormClosed;
				FrmListarCliente.MdiParent = this;
				FrmListarCliente.TopLevel = false;
				FrmListarCliente.Dock = DockStyle.Fill;
				FrmListarCliente.Show();
			}
			else
			{
				FrmListarCliente.Activate();
			}
		}

		private void FrmListarCliente_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmListarCliente = null;
		}

		public void ChamaListaFuncionario()
		{

			if (FrmListarFuncionarios == null)
			{
				FrmListarFuncionarios = new frmListarFuncionarios(this);
				FrmListarFuncionarios.FormClosed += FrmListarFuncionarios_FormClosed;
				FrmListarFuncionarios.MdiParent = this;
				FrmListarFuncionarios.TopLevel = false;
				FrmListarFuncionarios.Dock = DockStyle.Fill;
				FrmListarFuncionarios.Show();
			}
			else
			{
				FrmListarFuncionarios.Activate();
			}
		}
		private void FrmListarFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmListarFuncionarios = null;
		}

		public void ChamaListaProdutos()
		{
			if (FrmListaProdutos == null)
			{
				FrmListaProdutos = new frmListaProdutos(this);
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

		private void FrmListaProdutos_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmListaProdutos = null;
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			menuTransicao.Start();
			timerResponsivo.Start();
			
		}

		private void btnInicio_Click(object sender, EventArgs e)
		{
			ChamaListaProdutos();
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

		private void btnCliente_Click(object sender, EventArgs e)
		{
			if (FrmProdutos == null)
			{
				FrmClientes = new frmClientes();
				FrmClientes.FormClosed += FrmClientes_FormClosed;
				FrmClientes.MdiParent = this;
				FrmClientes.TopLevel = false;
				FrmClientes.Dock = DockStyle.Fill;
				FrmClientes.Show();
			}
			else
			{
				FrmClientes.Activate();
			}
		}

		private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
		{
			FrmClientes = null;
		}

		private void btnCategoria_Click(object sender, EventArgs e)
		{
			FrmCategoria = new frmCategoria();
			FrmCategoria.ShowDialog();
		}

		private void btnUnidade_Click(object sender, EventArgs e)
		{
			FrmUnidades = new frmUnidades();
			FrmUnidades.ShowDialog();
		}
	}
}
