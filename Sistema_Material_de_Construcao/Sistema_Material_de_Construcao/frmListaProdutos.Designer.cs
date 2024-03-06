namespace Sistema_Material_de_Construcao
{
	partial class frmListaProdutos
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnListaFuncionario = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.btnListaCliente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnBusca = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.dgvProdutos = new System.Windows.Forms.DataGridView();
			this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo_Barras_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descricao_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id_Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Unidade_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Categoria_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estoque_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estoque_Atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Situacao_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Anotacoes_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Cadastro_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
			this.kryptonGroup1.Panel.SuspendLayout();
			this.kryptonGroup1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(55, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listar Produtos";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.caixa_aberta;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 43);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnListaFuncionario
			// 
			this.btnListaFuncionario.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListaFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListaFuncionario.Location = new System.Drawing.Point(14, 75);
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
			this.btnListaFuncionario.Click += new System.EventHandler(this.btnListaFuncionario_Click);
			// 
			// kryptonTextBox1
			// 
			this.kryptonTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.kryptonTextBox1.Location = new System.Drawing.Point(773, 75);
			this.kryptonTextBox1.Name = "kryptonTextBox1";
			this.kryptonTextBox1.Size = new System.Drawing.Size(345, 34);
			this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryptonTextBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
			this.kryptonTextBox1.StateCommon.Border.Rounding = 5;
			this.kryptonTextBox1.StateCommon.Border.Width = 1;
			this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.kryptonTextBox1.TabIndex = 0;
			// 
			// btnListaCliente
			// 
			this.btnListaCliente.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListaCliente.Location = new System.Drawing.Point(213, 75);
			this.btnListaCliente.Name = "btnListaCliente";
			this.btnListaCliente.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListaCliente.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListaCliente.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaCliente.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaCliente.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaCliente.OverrideDefault.Border.Rounding = 5;
			this.btnListaCliente.OverrideDefault.Border.Width = 1;
			this.btnListaCliente.OverrideFocus.Back.Color1 = System.Drawing.Color.Gray;
			this.btnListaCliente.OverrideFocus.Back.Color2 = System.Drawing.Color.Gray;
			this.btnListaCliente.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaCliente.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaCliente.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaCliente.OverrideFocus.Border.Rounding = 5;
			this.btnListaCliente.OverrideFocus.Border.Width = 1;
			this.btnListaCliente.Size = new System.Drawing.Size(180, 33);
			this.btnListaCliente.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnListaCliente.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnListaCliente.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListaCliente.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaCliente.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaCliente.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnListaCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaCliente.StateCommon.Border.Rounding = 5;
			this.btnListaCliente.StateCommon.Border.Width = 1;
			this.btnListaCliente.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListaCliente.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.btnListaCliente.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.btnListaCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListaCliente.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.btnListaCliente.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnListaCliente.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnListaCliente.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnListaCliente.StateTracking.Border.Rounding = 5;
			this.btnListaCliente.StateTracking.Border.Width = 1;
			this.btnListaCliente.TabIndex = 3;
			this.btnListaCliente.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.usuarios;
			this.btnListaCliente.Values.Text = " Listar Clientes";
			this.btnListaCliente.Click += new System.EventHandler(this.btnListaCliente_Click);
			// 
			// btnBusca
			// 
			this.btnBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBusca.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBusca.Location = new System.Drawing.Point(1119, 75);
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
			this.btnBusca.TabIndex = 1;
			this.btnBusca.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.procurar__1_;
			this.btnBusca.Values.Text = "";
			// 
			// dgvProdutos
			// 
			this.dgvProdutos.AllowUserToAddRows = false;
			this.dgvProdutos.AllowUserToDeleteRows = false;
			this.dgvProdutos.AllowUserToResizeColumns = false;
			this.dgvProdutos.AllowUserToResizeRows = false;
			this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProdutos.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Codigo_Barras_Produto,
            this.Nome_Produto,
            this.Descricao_Produto,
            this.Id_Unidade,
            this.Nome_Unidade_Produtos,
            this.Id_Categoria,
            this.Nome_Categoria_Produtos,
            this.Estoque_Minimo,
            this.Estoque_Atual,
            this.Valor_Compra,
            this.Valor_Venda,
            this.Margem,
            this.Situacao_Produto,
            this.Anotacoes_Produtos,
            this.Data_Cadastro_Produto,
            this.btnEditar,
            this.btnExcluir});
			this.dgvProdutos.Location = new System.Drawing.Point(12, 142);
			this.dgvProdutos.MultiSelect = false;
			this.dgvProdutos.Name = "dgvProdutos";
			this.dgvProdutos.ReadOnly = true;
			this.dgvProdutos.RowHeadersVisible = false;
			this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProdutos.Size = new System.Drawing.Size(1140, 446);
			this.dgvProdutos.TabIndex = 4;
			// 
			// Id_Produto
			// 
			this.Id_Produto.DataPropertyName = "Id_Produto";
			this.Id_Produto.HeaderText = "Id_Produto";
			this.Id_Produto.Name = "Id_Produto";
			this.Id_Produto.ReadOnly = true;
			this.Id_Produto.Visible = false;
			// 
			// Codigo_Barras_Produto
			// 
			this.Codigo_Barras_Produto.DataPropertyName = "Codigo_Barras_Produto";
			this.Codigo_Barras_Produto.HeaderText = "Código de Barras";
			this.Codigo_Barras_Produto.Name = "Codigo_Barras_Produto";
			this.Codigo_Barras_Produto.ReadOnly = true;
			this.Codigo_Barras_Produto.Width = 130;
			// 
			// Nome_Produto
			// 
			this.Nome_Produto.DataPropertyName = "Nome_Produto";
			this.Nome_Produto.HeaderText = "Nome";
			this.Nome_Produto.Name = "Nome_Produto";
			this.Nome_Produto.ReadOnly = true;
			this.Nome_Produto.Width = 130;
			// 
			// Descricao_Produto
			// 
			this.Descricao_Produto.DataPropertyName = "Descricao_Produto";
			this.Descricao_Produto.HeaderText = "Descrição";
			this.Descricao_Produto.Name = "Descricao_Produto";
			this.Descricao_Produto.ReadOnly = true;
			this.Descricao_Produto.Visible = false;
			// 
			// Id_Unidade
			// 
			this.Id_Unidade.DataPropertyName = "Id_Unidade";
			this.Id_Unidade.HeaderText = "Id_Unidade";
			this.Id_Unidade.Name = "Id_Unidade";
			this.Id_Unidade.ReadOnly = true;
			this.Id_Unidade.Visible = false;
			// 
			// Nome_Unidade_Produtos
			// 
			this.Nome_Unidade_Produtos.DataPropertyName = "(nNome_Unidade_Produtosenhum)";
			this.Nome_Unidade_Produtos.HeaderText = "Nome Unidade";
			this.Nome_Unidade_Produtos.Name = "Nome_Unidade_Produtos";
			this.Nome_Unidade_Produtos.ReadOnly = true;
			this.Nome_Unidade_Produtos.Width = 130;
			// 
			// Id_Categoria
			// 
			this.Id_Categoria.DataPropertyName = "Id_Categoria";
			this.Id_Categoria.HeaderText = "Id_Categoria";
			this.Id_Categoria.Name = "Id_Categoria";
			this.Id_Categoria.ReadOnly = true;
			this.Id_Categoria.Visible = false;
			// 
			// Nome_Categoria_Produtos
			// 
			this.Nome_Categoria_Produtos.DataPropertyName = "Nome_Categoria_Produtos";
			this.Nome_Categoria_Produtos.HeaderText = "Nome Categoria";
			this.Nome_Categoria_Produtos.Name = "Nome_Categoria_Produtos";
			this.Nome_Categoria_Produtos.ReadOnly = true;
			this.Nome_Categoria_Produtos.Width = 130;
			// 
			// Estoque_Minimo
			// 
			this.Estoque_Minimo.DataPropertyName = "Estoque_Minimo";
			this.Estoque_Minimo.HeaderText = "Estoque Minimo";
			this.Estoque_Minimo.Name = "Estoque_Minimo";
			this.Estoque_Minimo.ReadOnly = true;
			this.Estoque_Minimo.Width = 60;
			// 
			// Estoque_Atual
			// 
			this.Estoque_Atual.DataPropertyName = "Estoque_Atual";
			this.Estoque_Atual.HeaderText = "Estoque Atual";
			this.Estoque_Atual.Name = "Estoque_Atual";
			this.Estoque_Atual.ReadOnly = true;
			this.Estoque_Atual.Width = 60;
			// 
			// Valor_Compra
			// 
			this.Valor_Compra.DataPropertyName = "Valor_Compra";
			this.Valor_Compra.HeaderText = "Valor Compra";
			this.Valor_Compra.Name = "Valor_Compra";
			this.Valor_Compra.ReadOnly = true;
			this.Valor_Compra.Width = 70;
			// 
			// Valor_Venda
			// 
			this.Valor_Venda.DataPropertyName = "Valor_Venda";
			this.Valor_Venda.HeaderText = "Valor Venda";
			this.Valor_Venda.Name = "Valor_Venda";
			this.Valor_Venda.ReadOnly = true;
			this.Valor_Venda.Width = 70;
			// 
			// Margem
			// 
			this.Margem.DataPropertyName = "Margem";
			this.Margem.HeaderText = "Margem";
			this.Margem.Name = "Margem";
			this.Margem.ReadOnly = true;
			this.Margem.Width = 70;
			// 
			// Situacao_Produto
			// 
			this.Situacao_Produto.DataPropertyName = "Situacao_Produto";
			this.Situacao_Produto.HeaderText = "Situação";
			this.Situacao_Produto.Name = "Situacao_Produto";
			this.Situacao_Produto.ReadOnly = true;
			// 
			// Anotacoes_Produtos
			// 
			this.Anotacoes_Produtos.DataPropertyName = "Anotacoes_Produtos";
			this.Anotacoes_Produtos.HeaderText = "Anotações";
			this.Anotacoes_Produtos.Name = "Anotacoes_Produtos";
			this.Anotacoes_Produtos.ReadOnly = true;
			this.Anotacoes_Produtos.Visible = false;
			// 
			// Data_Cadastro_Produto
			// 
			this.Data_Cadastro_Produto.DataPropertyName = "Data_Cadastro_Produto";
			this.Data_Cadastro_Produto.HeaderText = "Data Cadastro";
			this.Data_Cadastro_Produto.Name = "Data_Cadastro_Produto";
			this.Data_Cadastro_Produto.ReadOnly = true;
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
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.editar;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Width = 30;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::Sistema_Material_de_Construcao.Properties.Resources.excluir;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.ReadOnly = true;
			this.dataGridViewImageColumn2.Width = 30;
			// 
			// frmListaProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1164, 600);
			this.Controls.Add(this.dgvProdutos);
			this.Controls.Add(this.btnBusca);
			this.Controls.Add(this.btnListaCliente);
			this.Controls.Add(this.kryptonTextBox1);
			this.Controls.Add(this.btnListaFuncionario);
			this.Controls.Add(this.kryptonGroup1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmListaProdutos";
			this.Text = "frmListaProdutos";
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
			this.kryptonGroup1.Panel.ResumeLayout(false);
			this.kryptonGroup1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
			this.kryptonGroup1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListaFuncionario;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListaCliente;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnBusca;
		private System.Windows.Forms.DataGridView dgvProdutos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Unidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Unidade_Produtos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Categoria;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Categoria_Produtos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Minimo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Atual;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Compra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Venda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Margem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Situacao_Produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Anotacoes_Produtos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro_Produto;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
	}
}