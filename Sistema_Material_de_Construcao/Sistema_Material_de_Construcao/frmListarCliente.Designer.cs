namespace Sistema_Material_de_Construcao
{
	partial class frmListarCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnListaFuncionario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnListarProdutos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnBusca = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.txtPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.rbCPF = new System.Windows.Forms.RadioButton();
			this.rbCNPJ = new System.Windows.Forms.RadioButton();
			this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Endereco_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cep_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefone1_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefone2_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Cadastro_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nascimento_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacoes_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
			this.kryptonGroup1.Panel.SuspendLayout();
			this.kryptonGroup1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonGroup1
			// 
			this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
			this.kryptonGroup1.Name = "kryptonGroup1";
			// 
			// kryptonGroup1.Panel
			// 
			this.kryptonGroup1.Panel.Controls.Add(this.label1);
			this.kryptonGroup1.Panel.Controls.Add(this.pictureBox1);
			this.kryptonGroup1.Size = new System.Drawing.Size(1164, 60);
			this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.SystemColors.ControlDark;
			this.kryptonGroup1.StateCommon.Back.Color2 = System.Drawing.SystemColors.ControlDark;
			this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryptonGroup1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
			this.kryptonGroup1.StateCommon.Border.Width = 2;
			this.kryptonGroup1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.clientes;
			this.pictureBox1.Location = new System.Drawing.Point(11, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 43);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(54, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Listar Clientes";
			// 
			// btnListaFuncionario
			// 
			this.btnListaFuncionario.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListaFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListaFuncionario.Location = new System.Drawing.Point(11, 76);
			this.btnListaFuncionario.Name = "btnListaFuncionario";
			this.btnListaFuncionario.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListaFuncionario.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListaFuncionario.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaFuncionario.OverrideDefault.Border.Rounding = 5;
			this.btnListaFuncionario.OverrideDefault.Border.Width = 1;
			this.btnListaFuncionario.OverrideFocus.Back.Color1 = System.Drawing.Color.Gray;
			this.btnListaFuncionario.OverrideFocus.Back.Color2 = System.Drawing.Color.Gray;
			this.btnListaFuncionario.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaFuncionario.OverrideFocus.Border.Rounding = 5;
			this.btnListaFuncionario.OverrideFocus.Border.Width = 1;
			this.btnListaFuncionario.Size = new System.Drawing.Size(180, 33);
			this.btnListaFuncionario.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListaFuncionario.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListaFuncionario.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListaFuncionario.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListaFuncionario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaFuncionario.StateCommon.Border.Rounding = 5;
			this.btnListaFuncionario.StateCommon.Border.Width = 1;
			this.btnListaFuncionario.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListaFuncionario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.btnListaFuncionario.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.btnListaFuncionario.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListaFuncionario.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListaFuncionario.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaFuncionario.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaFuncionario.StateTracking.Border.Rounding = 5;
			this.btnListaFuncionario.StateTracking.Border.Width = 1;
			this.btnListaFuncionario.TabIndex = 2;
			this.btnListaFuncionario.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.funcionario_homem_alt;
			this.btnListaFuncionario.Values.Text = " Listar Funcionários";
			// 
			// btnListarProdutos
			// 
			this.btnListarProdutos.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListarProdutos.Location = new System.Drawing.Point(208, 76);
			this.btnListarProdutos.Name = "btnListarProdutos";
			this.btnListarProdutos.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListarProdutos.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListarProdutos.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListarProdutos.OverrideDefault.Border.Rounding = 5;
			this.btnListarProdutos.OverrideDefault.Border.Width = 1;
			this.btnListarProdutos.OverrideFocus.Back.Color1 = System.Drawing.Color.Gray;
			this.btnListarProdutos.OverrideFocus.Back.Color2 = System.Drawing.Color.Gray;
			this.btnListarProdutos.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListarProdutos.OverrideFocus.Border.Rounding = 5;
			this.btnListarProdutos.OverrideFocus.Border.Width = 1;
			this.btnListarProdutos.Size = new System.Drawing.Size(180, 33);
			this.btnListarProdutos.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListarProdutos.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListarProdutos.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListarProdutos.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListarProdutos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListarProdutos.StateCommon.Border.Rounding = 5;
			this.btnListarProdutos.StateCommon.Border.Width = 1;
			this.btnListarProdutos.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListarProdutos.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.btnListarProdutos.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.btnListarProdutos.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarProdutos.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListarProdutos.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListarProdutos.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListarProdutos.StateTracking.Border.Rounding = 5;
			this.btnListarProdutos.StateTracking.Border.Width = 1;
			this.btnListarProdutos.TabIndex = 12;
			this.btnListarProdutos.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.caixa_aberta__1_;
			this.btnListarProdutos.Values.Text = " Listar Produtos";
			// 
			// btnBusca
			// 
			this.btnBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBusca.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBusca.Location = new System.Drawing.Point(1119, 76);
			this.btnBusca.Name = "btnBusca";
			this.btnBusca.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnBusca.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnBusca.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnBusca.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnBusca.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnBusca.OverrideDefault.Border.Rounding = 5;
			this.btnBusca.OverrideDefault.Border.Width = 1;
			this.btnBusca.OverrideFocus.Back.Color1 = System.Drawing.Color.Gray;
			this.btnBusca.OverrideFocus.Back.Color2 = System.Drawing.Color.Gray;
			this.btnBusca.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnBusca.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnBusca.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnBusca.OverrideFocus.Border.Rounding = 5;
			this.btnBusca.OverrideFocus.Border.Width = 1;
			this.btnBusca.Size = new System.Drawing.Size(32, 35);
			this.btnBusca.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnBusca.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnBusca.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnBusca.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnBusca.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnBusca.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnBusca.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnBusca.StateCommon.Border.Rounding = 5;
			this.btnBusca.StateCommon.Border.Width = 1;
			this.btnBusca.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.btnBusca.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.btnBusca.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.btnBusca.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBusca.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnBusca.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnBusca.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnBusca.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnBusca.StateTracking.Border.Rounding = 5;
			this.btnBusca.StateTracking.Border.Width = 1;
			this.btnBusca.TabIndex = 14;
			this.btnBusca.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.procurar__1_;
			this.btnBusca.Values.Text = "";
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPesquisar.Location = new System.Drawing.Point(773, 76);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(345, 34);
			this.txtPesquisar.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtPesquisar.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtPesquisar.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.txtPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
			this.txtPesquisar.StateCommon.Border.Rounding = 5;
			this.txtPesquisar.StateCommon.Border.Width = 1;
			this.txtPesquisar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.txtPesquisar.TabIndex = 13;
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.AllowUserToResizeColumns = false;
			this.dgvClientes.AllowUserToResizeRows = false;
			this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvClientes.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.Nome_Cliente,
            this.Endereco_Cliente,
            this.Bairro_Cliente,
            this.Cep_Cliente,
            this.Cidade_Cliente,
            this.Estado_Cliente,
            this.Telefone1_Cliente,
            this.Telefone2_Cliente,
            this.Email_Cliente,
            this.Data_Cadastro_Cliente,
            this.Nascimento_Cliente,
            this.Observacoes_Cliente,
            this.btnEditar,
            this.btnExcluir});
			this.dgvClientes.Location = new System.Drawing.Point(11, 142);
			this.dgvClientes.MultiSelect = false;
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowHeadersVisible = false;
			this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClientes.Size = new System.Drawing.Size(1140, 446);
			this.dgvClientes.TabIndex = 15;
			// 
			// rbNome
			// 
			this.rbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbNome.AutoSize = true;
			this.rbNome.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.rbNome.ForeColor = System.Drawing.Color.White;
			this.rbNome.Location = new System.Drawing.Point(579, 86);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(66, 21);
			this.rbNome.TabIndex = 16;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// rbCPF
			// 
			this.rbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbCPF.AutoSize = true;
			this.rbCPF.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.rbCPF.ForeColor = System.Drawing.Color.White;
			this.rbCPF.Location = new System.Drawing.Point(651, 86);
			this.rbCPF.Name = "rbCPF";
			this.rbCPF.Size = new System.Drawing.Size(52, 21);
			this.rbCPF.TabIndex = 17;
			this.rbCPF.TabStop = true;
			this.rbCPF.Text = "CPF";
			this.rbCPF.UseVisualStyleBackColor = true;
			// 
			// rbCNPJ
			// 
			this.rbCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbCNPJ.AutoSize = true;
			this.rbCNPJ.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.rbCNPJ.ForeColor = System.Drawing.Color.White;
			this.rbCNPJ.Location = new System.Drawing.Point(710, 86);
			this.rbCNPJ.Name = "rbCNPJ";
			this.rbCNPJ.Size = new System.Drawing.Size(59, 21);
			this.rbCNPJ.TabIndex = 18;
			this.rbCNPJ.TabStop = true;
			this.rbCNPJ.Text = "CNPJ";
			this.rbCNPJ.UseVisualStyleBackColor = true;
			// 
			// Id_Cliente
			// 
			this.Id_Cliente.DataPropertyName = "Id_Cliente";
			this.Id_Cliente.HeaderText = "Id_Cliente";
			this.Id_Cliente.Name = "Id_Cliente";
			this.Id_Cliente.ReadOnly = true;
			this.Id_Cliente.Visible = false;
			// 
			// Nome_Cliente
			// 
			this.Nome_Cliente.DataPropertyName = "Nome_Cliente";
			this.Nome_Cliente.HeaderText = "Nome";
			this.Nome_Cliente.Name = "Nome_Cliente";
			this.Nome_Cliente.ReadOnly = true;
			this.Nome_Cliente.Width = 115;
			// 
			// Endereco_Cliente
			// 
			this.Endereco_Cliente.DataPropertyName = "Endereco_Cliente";
			this.Endereco_Cliente.HeaderText = "Endereço";
			this.Endereco_Cliente.Name = "Endereco_Cliente";
			this.Endereco_Cliente.ReadOnly = true;
			// 
			// Bairro_Cliente
			// 
			this.Bairro_Cliente.DataPropertyName = "Bairro_Cliente";
			this.Bairro_Cliente.HeaderText = "Bairro";
			this.Bairro_Cliente.Name = "Bairro_Cliente";
			this.Bairro_Cliente.ReadOnly = true;
			this.Bairro_Cliente.Width = 90;
			// 
			// Cep_Cliente
			// 
			this.Cep_Cliente.DataPropertyName = "Cep_Cliente";
			this.Cep_Cliente.HeaderText = "CEP";
			this.Cep_Cliente.Name = "Cep_Cliente";
			this.Cep_Cliente.ReadOnly = true;
			this.Cep_Cliente.Visible = false;
			// 
			// Cidade_Cliente
			// 
			this.Cidade_Cliente.DataPropertyName = "Cidade_Cliente";
			this.Cidade_Cliente.HeaderText = "Cidade";
			this.Cidade_Cliente.Name = "Cidade_Cliente";
			this.Cidade_Cliente.ReadOnly = true;
			this.Cidade_Cliente.Width = 90;
			// 
			// Estado_Cliente
			// 
			this.Estado_Cliente.DataPropertyName = "Estado_Cliente";
			this.Estado_Cliente.HeaderText = "Estado";
			this.Estado_Cliente.Name = "Estado_Cliente";
			this.Estado_Cliente.ReadOnly = true;
			this.Estado_Cliente.Width = 90;
			// 
			// Telefone1_Cliente
			// 
			this.Telefone1_Cliente.DataPropertyName = "Telefone1_Cliente";
			this.Telefone1_Cliente.HeaderText = "Telefone1";
			this.Telefone1_Cliente.Name = "Telefone1_Cliente";
			this.Telefone1_Cliente.ReadOnly = true;
			this.Telefone1_Cliente.Width = 90;
			// 
			// Telefone2_Cliente
			// 
			this.Telefone2_Cliente.DataPropertyName = "Telefone2_Cliente";
			this.Telefone2_Cliente.HeaderText = "Telefone2";
			this.Telefone2_Cliente.Name = "Telefone2_Cliente";
			this.Telefone2_Cliente.ReadOnly = true;
			this.Telefone2_Cliente.Width = 90;
			// 
			// Email_Cliente
			// 
			this.Email_Cliente.DataPropertyName = "Email_Cliente";
			this.Email_Cliente.HeaderText = "E_mail";
			this.Email_Cliente.Name = "Email_Cliente";
			this.Email_Cliente.ReadOnly = true;
			// 
			// Data_Cadastro_Cliente
			// 
			this.Data_Cadastro_Cliente.DataPropertyName = "Data_Cadastro_Cliente";
			this.Data_Cadastro_Cliente.HeaderText = "Data Cadastro";
			this.Data_Cadastro_Cliente.Name = "Data_Cadastro_Cliente";
			this.Data_Cadastro_Cliente.ReadOnly = true;
			// 
			// Nascimento_Cliente
			// 
			this.Nascimento_Cliente.DataPropertyName = "Nascimento_Cliente";
			this.Nascimento_Cliente.HeaderText = "Nascimento";
			this.Nascimento_Cliente.Name = "Nascimento_Cliente";
			this.Nascimento_Cliente.ReadOnly = true;
			this.Nascimento_Cliente.Width = 90;
			// 
			// Observacoes_Cliente
			// 
			this.Observacoes_Cliente.DataPropertyName = "Observacoes_Cliente";
			this.Observacoes_Cliente.HeaderText = "Observaçoes";
			this.Observacoes_Cliente.Name = "Observacoes_Cliente";
			this.Observacoes_Cliente.ReadOnly = true;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::Sistema_Material_de_Construcao.Properties.Resources.editar;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Width = 30;
			// 
			// btnExcluir
			// 
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = global::Sistema_Material_de_Construcao.Properties.Resources.excluir;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Width = 30;
			// 
			// frmListarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1164, 600);
			this.Controls.Add(this.rbCNPJ);
			this.Controls.Add(this.rbCPF);
			this.Controls.Add(this.rbNome);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnBusca);
			this.Controls.Add(this.txtPesquisar);
			this.Controls.Add(this.btnListarProdutos);
			this.Controls.Add(this.btnListaFuncionario);
			this.Controls.Add(this.kryptonGroup1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmListarCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmListarCliente";
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
			this.kryptonGroup1.Panel.ResumeLayout(false);
			this.kryptonGroup1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
			this.kryptonGroup1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListaFuncionario;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListarProdutos;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnBusca;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPesquisar;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.RadioButton rbCPF;
		private System.Windows.Forms.RadioButton rbCNPJ;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endereco_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cep_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento_Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes_Cliente;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}