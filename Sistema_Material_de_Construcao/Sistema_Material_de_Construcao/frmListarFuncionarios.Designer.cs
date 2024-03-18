namespace Sistema_Material_de_Construcao
{
	partial class frmListarFuncionarios
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnListaCliente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnBusca = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.txtPes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.btnListarProdutos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgvFuncionario = new System.Windows.Forms.DataGridView();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.rbCPF = new System.Windows.Forms.RadioButton();
			this.Id_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Endereco_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cep_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nascimento_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefone1_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefone2_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rg_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cpf_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacoes_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data_Cadastro_Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
			this.kryptonGroup1.Panel.SuspendLayout();
			this.kryptonGroup1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
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
			this.label1.Location = new System.Drawing.Point(55, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Listar Funcionarios";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.funcionários;
			this.pictureBox1.Location = new System.Drawing.Point(11, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 43);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnListaCliente
			// 
			this.btnListaCliente.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListaCliente.Location = new System.Drawing.Point(214, 77);
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
			this.btnListaCliente.TabIndex = 5;
			this.btnListaCliente.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.usuarios;
			this.btnListaCliente.Values.Text = " Listar Clientes";
			this.btnListaCliente.Click += new System.EventHandler(this.btnListaCliente_Click);
			// 
			// btnBusca
			// 
			this.btnBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBusca.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBusca.Location = new System.Drawing.Point(1113, 77);
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
			this.btnBusca.TabIndex = 3;
			this.btnBusca.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.procurar__1_;
			this.btnBusca.Values.Text = "";
			this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
			// 
			// txtPes
			// 
			this.txtPes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPes.Location = new System.Drawing.Point(767, 77);
			this.txtPes.Name = "txtPes";
			this.txtPes.Size = new System.Drawing.Size(345, 34);
			this.txtPes.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtPes.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtPes.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.txtPes.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
			this.txtPes.StateCommon.Border.Rounding = 5;
			this.txtPes.StateCommon.Border.Width = 1;
			this.txtPes.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.txtPes.TabIndex = 0;
			// 
			// btnListarProdutos
			// 
			this.btnListarProdutos.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnListarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListarProdutos.Location = new System.Drawing.Point(14, 77);
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
			this.btnListarProdutos.TabIndex = 4;
			this.btnListarProdutos.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.caixa_aberta__1_;
			this.btnListarProdutos.Values.Text = " Listar Produtos";
			this.btnListarProdutos.Click += new System.EventHandler(this.btnListarProdutos_Click);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.editar;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 30;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::Sistema_Material_de_Construcao.Properties.Resources.excluir;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Width = 30;
			// 
			// dgvFuncionario
			// 
			this.dgvFuncionario.AllowUserToAddRows = false;
			this.dgvFuncionario.AllowUserToDeleteRows = false;
			this.dgvFuncionario.AllowUserToResizeColumns = false;
			this.dgvFuncionario.AllowUserToResizeRows = false;
			this.dgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFuncionario.BackgroundColor = System.Drawing.Color.Silver;
			this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Funcionario,
            this.Nome_Funcionario,
            this.Endereco_Funcionario,
            this.Bairro_Funcionario,
            this.Cep_Funcionario,
            this.Cidade_Funcionario,
            this.Email_Funcionario,
            this.Nascimento_Funcionario,
            this.Telefone1_Funcionario,
            this.Telefone2_Funcionario,
            this.Rg_Funcionario,
            this.Cpf_Funcionario,
            this.Observacoes_Funcionario,
            this.Data_Cadastro_Funcionario,
            this.btnEditar,
            this.btnExcluir});
			this.dgvFuncionario.Location = new System.Drawing.Point(11, 142);
			this.dgvFuncionario.MultiSelect = false;
			this.dgvFuncionario.Name = "dgvFuncionario";
			this.dgvFuncionario.ReadOnly = true;
			this.dgvFuncionario.RowHeadersVisible = false;
			this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFuncionario.Size = new System.Drawing.Size(1140, 446);
			this.dgvFuncionario.TabIndex = 6;
			this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
			// 
			// rbNome
			// 
			this.rbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbNome.AutoSize = true;
			this.rbNome.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.rbNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rbNome.Location = new System.Drawing.Point(607, 88);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(66, 21);
			this.rbNome.TabIndex = 1;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// rbCPF
			// 
			this.rbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbCPF.AutoSize = true;
			this.rbCPF.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.rbCPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.rbCPF.Location = new System.Drawing.Point(693, 88);
			this.rbCPF.Name = "rbCPF";
			this.rbCPF.Size = new System.Drawing.Size(52, 21);
			this.rbCPF.TabIndex = 2;
			this.rbCPF.TabStop = true;
			this.rbCPF.Text = "CPF";
			this.rbCPF.UseVisualStyleBackColor = true;
			// 
			// Id_Funcionario
			// 
			this.Id_Funcionario.DataPropertyName = "Id_Funcionario";
			this.Id_Funcionario.HeaderText = "Id_Funcionario";
			this.Id_Funcionario.Name = "Id_Funcionario";
			this.Id_Funcionario.ReadOnly = true;
			this.Id_Funcionario.Visible = false;
			// 
			// Nome_Funcionario
			// 
			this.Nome_Funcionario.DataPropertyName = "Nome_Funcionario";
			this.Nome_Funcionario.HeaderText = "Nome";
			this.Nome_Funcionario.Name = "Nome_Funcionario";
			this.Nome_Funcionario.ReadOnly = true;
			// 
			// Endereco_Funcionario
			// 
			this.Endereco_Funcionario.DataPropertyName = "Endereco_Funcionario";
			this.Endereco_Funcionario.HeaderText = "Endereço";
			this.Endereco_Funcionario.Name = "Endereco_Funcionario";
			this.Endereco_Funcionario.ReadOnly = true;
			this.Endereco_Funcionario.Width = 80;
			// 
			// Bairro_Funcionario
			// 
			this.Bairro_Funcionario.DataPropertyName = "Bairro_Funcionario";
			this.Bairro_Funcionario.HeaderText = "Bairro";
			this.Bairro_Funcionario.Name = "Bairro_Funcionario";
			this.Bairro_Funcionario.ReadOnly = true;
			this.Bairro_Funcionario.Width = 80;
			// 
			// Cep_Funcionario
			// 
			this.Cep_Funcionario.DataPropertyName = "Cep_Funcionario";
			dataGridViewCellStyle1.Format = "99999-99";
			dataGridViewCellStyle1.NullValue = null;
			this.Cep_Funcionario.DefaultCellStyle = dataGridViewCellStyle1;
			this.Cep_Funcionario.HeaderText = "CEP";
			this.Cep_Funcionario.Name = "Cep_Funcionario";
			this.Cep_Funcionario.ReadOnly = true;
			this.Cep_Funcionario.Visible = false;
			// 
			// Cidade_Funcionario
			// 
			this.Cidade_Funcionario.DataPropertyName = "Cidade_Funcionario";
			this.Cidade_Funcionario.HeaderText = "Cidade";
			this.Cidade_Funcionario.Name = "Cidade_Funcionario";
			this.Cidade_Funcionario.ReadOnly = true;
			this.Cidade_Funcionario.Width = 70;
			// 
			// Email_Funcionario
			// 
			this.Email_Funcionario.DataPropertyName = "Email_Funcionario";
			this.Email_Funcionario.HeaderText = "E-mail";
			this.Email_Funcionario.Name = "Email_Funcionario";
			this.Email_Funcionario.ReadOnly = true;
			// 
			// Nascimento_Funcionario
			// 
			this.Nascimento_Funcionario.DataPropertyName = "Nascimento_Funcionario";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.Nascimento_Funcionario.DefaultCellStyle = dataGridViewCellStyle2;
			this.Nascimento_Funcionario.HeaderText = "Nascimento";
			this.Nascimento_Funcionario.Name = "Nascimento_Funcionario";
			this.Nascimento_Funcionario.ReadOnly = true;
			this.Nascimento_Funcionario.Width = 90;
			// 
			// Telefone1_Funcionario
			// 
			this.Telefone1_Funcionario.DataPropertyName = "Telefone1_Funcionario";
			this.Telefone1_Funcionario.HeaderText = "Telefone1";
			this.Telefone1_Funcionario.Name = "Telefone1_Funcionario";
			this.Telefone1_Funcionario.ReadOnly = true;
			this.Telefone1_Funcionario.Width = 80;
			// 
			// Telefone2_Funcionario
			// 
			this.Telefone2_Funcionario.DataPropertyName = "Telefone2_Funcionario";
			this.Telefone2_Funcionario.HeaderText = "Telefone2";
			this.Telefone2_Funcionario.Name = "Telefone2_Funcionario";
			this.Telefone2_Funcionario.ReadOnly = true;
			this.Telefone2_Funcionario.Width = 80;
			// 
			// Rg_Funcionario
			// 
			this.Rg_Funcionario.DataPropertyName = "Rg_Funcionario";
			this.Rg_Funcionario.HeaderText = "RG";
			this.Rg_Funcionario.Name = "Rg_Funcionario";
			this.Rg_Funcionario.ReadOnly = true;
			this.Rg_Funcionario.Width = 90;
			// 
			// Cpf_Funcionario
			// 
			this.Cpf_Funcionario.DataPropertyName = "Cpf_Funcionario";
			dataGridViewCellStyle3.Format = "999,999,999-99";
			dataGridViewCellStyle3.NullValue = null;
			this.Cpf_Funcionario.DefaultCellStyle = dataGridViewCellStyle3;
			this.Cpf_Funcionario.HeaderText = "CPF";
			this.Cpf_Funcionario.Name = "Cpf_Funcionario";
			this.Cpf_Funcionario.ReadOnly = true;
			this.Cpf_Funcionario.Width = 85;
			// 
			// Observacoes_Funcionario
			// 
			this.Observacoes_Funcionario.DataPropertyName = "Observacoes_Funcionario";
			this.Observacoes_Funcionario.HeaderText = "Observaçoes";
			this.Observacoes_Funcionario.Name = "Observacoes_Funcionario";
			this.Observacoes_Funcionario.ReadOnly = true;
			// 
			// Data_Cadastro_Funcionario
			// 
			this.Data_Cadastro_Funcionario.DataPropertyName = "Data_Cadastro_Funcionario";
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			this.Data_Cadastro_Funcionario.DefaultCellStyle = dataGridViewCellStyle4;
			this.Data_Cadastro_Funcionario.HeaderText = "Data Cadastro";
			this.Data_Cadastro_Funcionario.Name = "Data_Cadastro_Funcionario";
			this.Data_Cadastro_Funcionario.ReadOnly = true;
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
			// frmListarFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(1164, 600);
			this.Controls.Add(this.rbCPF);
			this.Controls.Add(this.rbNome);
			this.Controls.Add(this.dgvFuncionario);
			this.Controls.Add(this.btnListarProdutos);
			this.Controls.Add(this.btnBusca);
			this.Controls.Add(this.txtPes);
			this.Controls.Add(this.btnListaCliente);
			this.Controls.Add(this.kryptonGroup1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmListarFuncionarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmListarFuncionarios";
			this.Load += new System.EventHandler(this.frmListarFuncionarios_Load);
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
			this.kryptonGroup1.Panel.ResumeLayout(false);
			this.kryptonGroup1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
			this.kryptonGroup1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListaCliente;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnBusca;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPes;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnListarProdutos;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
		private System.Windows.Forms.DataGridView dgvFuncionario;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.RadioButton rbCPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endereco_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cep_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rg_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cpf_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes_Funcionario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro_Funcionario;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}