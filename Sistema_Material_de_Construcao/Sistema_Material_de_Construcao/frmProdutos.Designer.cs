namespace Sistema_Material_de_Construcao
{
	partial class frmProdutos
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
			this.txtMargem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtVenda = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtCusto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbUnidade = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.cbCategoria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.txtEstoqueMinimo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtEstoqueAtual = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ckStatus = new System.Windows.Forms.CheckBox();
			this.dtpDataCadastro = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtCodigoBarra = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtAnotacoes = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnApagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btnExcluir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
			this.kryptonGroup1.Panel.SuspendLayout();
			this.kryptonGroup1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbUnidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCategoria)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonGroup1
			// 
			this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
			this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.kryptonGroup1.Name = "kryptonGroup1";
			// 
			// kryptonGroup1.Panel
			// 
			this.kryptonGroup1.Panel.Controls.Add(this.label1);
			this.kryptonGroup1.Panel.Controls.Add(this.pictureBox1);
			this.kryptonGroup1.Size = new System.Drawing.Size(1164, 63);
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
			this.label1.Location = new System.Drawing.Point(76, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cadastro de Produtos";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::Sistema_Material_de_Construcao.Properties.Resources.produtos;
			this.pictureBox1.Location = new System.Drawing.Point(12, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 53);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// txtMargem
			// 
			this.txtMargem.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtMargem.Location = new System.Drawing.Point(583, 364);
			this.txtMargem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMargem.Name = "txtMargem";
			this.txtMargem.Size = new System.Drawing.Size(112, 31);
			this.txtMargem.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtMargem.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtMargem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtMargem.StateCommon.Border.Rounding = 10;
			this.txtMargem.StateCommon.Border.Width = 2;
			this.txtMargem.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtMargem.TabIndex = 10;
			// 
			// txtVenda
			// 
			this.txtVenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtVenda.Location = new System.Drawing.Point(462, 364);
			this.txtVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtVenda.Name = "txtVenda";
			this.txtVenda.Size = new System.Drawing.Size(112, 31);
			this.txtVenda.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtVenda.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtVenda.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtVenda.StateCommon.Border.Rounding = 10;
			this.txtVenda.StateCommon.Border.Width = 2;
			this.txtVenda.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtVenda.TabIndex = 3;
			// 
			// txtCusto
			// 
			this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCusto.Location = new System.Drawing.Point(341, 364);
			this.txtCusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCusto.Name = "txtCusto";
			this.txtCusto.Size = new System.Drawing.Size(112, 31);
			this.txtCusto.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtCusto.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtCusto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtCusto.StateCommon.Border.Rounding = 10;
			this.txtCusto.StateCommon.Border.Width = 2;
			this.txtCusto.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtCusto.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(588, 412);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 15);
			this.label7.TabIndex = 9;
			this.label7.Text = "Unidade do Produto";
			// 
			// cbUnidade
			// 
			this.cbUnidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUnidade.DropDownWidth = 121;
			this.cbUnidade.Location = new System.Drawing.Point(583, 428);
			this.cbUnidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbUnidade.Name = "cbUnidade";
			this.cbUnidade.Size = new System.Drawing.Size(246, 29);
			this.cbUnidade.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
			this.cbUnidade.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
			this.cbUnidade.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.cbUnidade.StateCommon.ComboBox.Border.Rounding = 10;
			this.cbUnidade.StateCommon.ComboBox.Border.Width = 2;
			this.cbUnidade.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
			this.cbUnidade.TabIndex = 0;
			// 
			// cbCategoria
			// 
			this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategoria.DropDownWidth = 338;
			this.cbCategoria.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
			this.cbCategoria.Location = new System.Drawing.Point(341, 303);
			this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(354, 29);
			this.cbCategoria.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.White;
			this.cbCategoria.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Silver;
			this.cbCategoria.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Silver;
			this.cbCategoria.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.cbCategoria.StateCommon.ComboBox.Border.Rounding = 10;
			this.cbCategoria.StateCommon.ComboBox.Border.Width = 2;
			this.cbCategoria.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DimGray;
			this.cbCategoria.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
			this.cbCategoria.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
			this.cbCategoria.TabIndex = 3;
			// 
			// txtEstoqueMinimo
			// 
			this.txtEstoqueMinimo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtEstoqueMinimo.Location = new System.Drawing.Point(462, 425);
			this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
			this.txtEstoqueMinimo.Size = new System.Drawing.Size(112, 31);
			this.txtEstoqueMinimo.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtEstoqueMinimo.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtEstoqueMinimo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtEstoqueMinimo.StateCommon.Border.Rounding = 10;
			this.txtEstoqueMinimo.StateCommon.Border.Width = 2;
			this.txtEstoqueMinimo.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtEstoqueMinimo.TabIndex = 3;
			// 
			// txtEstoqueAtual
			// 
			this.txtEstoqueAtual.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtEstoqueAtual.Location = new System.Drawing.Point(341, 425);
			this.txtEstoqueAtual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtEstoqueAtual.Name = "txtEstoqueAtual";
			this.txtEstoqueAtual.Size = new System.Drawing.Size(112, 31);
			this.txtEstoqueAtual.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtEstoqueAtual.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtEstoqueAtual.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtEstoqueAtual.StateCommon.Border.Rounding = 10;
			this.txtEstoqueAtual.StateCommon.Border.Width = 2;
			this.txtEstoqueAtual.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtEstoqueAtual.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(460, 409);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 15);
			this.label6.TabIndex = 1;
			this.label6.Text = "Estoque Minimo";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(344, 409);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Estoque Atual";
			// 
			// txtDescricao
			// 
			this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDescricao.Location = new System.Drawing.Point(341, 237);
			this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(488, 31);
			this.txtDescricao.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtDescricao.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtDescricao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtDescricao.StateCommon.Border.Rounding = 10;
			this.txtDescricao.StateCommon.Border.Width = 2;
			this.txtDescricao.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtDescricao.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.groupBox2.Controls.Add(this.ckStatus);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(721, 352);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(108, 50);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status";
			// 
			// ckStatus
			// 
			this.ckStatus.AutoSize = true;
			this.ckStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckStatus.Location = new System.Drawing.Point(26, 21);
			this.ckStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ckStatus.Name = "ckStatus";
			this.ckStatus.Size = new System.Drawing.Size(56, 19);
			this.ckStatus.TabIndex = 0;
			this.ckStatus.Text = "Ativo";
			this.ckStatus.UseVisualStyleBackColor = true;
			// 
			// dtpDataCadastro
			// 
			this.dtpDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataCadastro.Location = new System.Drawing.Point(721, 303);
			this.dtpDataCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpDataCadastro.Name = "dtpDataCadastro";
			this.dtpDataCadastro.Size = new System.Drawing.Size(108, 29);
			this.dtpDataCadastro.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.dtpDataCadastro.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.dtpDataCadastro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.dtpDataCadastro.StateCommon.Border.Rounding = 10;
			this.dtpDataCadastro.StateCommon.Border.Width = 2;
			this.dtpDataCadastro.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(348, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Descrição";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(348, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nome";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(348, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Códigos de Barras";
			// 
			// txtNome
			// 
			this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNome.Location = new System.Drawing.Point(341, 170);
			this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(488, 31);
			this.txtNome.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtNome.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtNome.StateCommon.Border.Rounding = 10;
			this.txtNome.StateCommon.Border.Width = 2;
			this.txtNome.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtNome.TabIndex = 1;
			// 
			// txtCodigoBarra
			// 
			this.txtCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCodigoBarra.Location = new System.Drawing.Point(341, 107);
			this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCodigoBarra.Name = "txtCodigoBarra";
			this.txtCodigoBarra.Size = new System.Drawing.Size(488, 31);
			this.txtCodigoBarra.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtCodigoBarra.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtCodigoBarra.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtCodigoBarra.StateCommon.Border.Rounding = 10;
			this.txtCodigoBarra.StateCommon.Border.Width = 2;
			this.txtCodigoBarra.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtCodigoBarra.TabIndex = 0;
			// 
			// txtAnotacoes
			// 
			this.txtAnotacoes.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtAnotacoes.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
			this.txtAnotacoes.Location = new System.Drawing.Point(341, 485);
			this.txtAnotacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtAnotacoes.Multiline = true;
			this.txtAnotacoes.Name = "txtAnotacoes";
			this.txtAnotacoes.Size = new System.Drawing.Size(488, 104);
			this.txtAnotacoes.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtAnotacoes.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtAnotacoes.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtAnotacoes.StateCommon.Border.Rounding = 10;
			this.txtAnotacoes.StateCommon.Border.Width = 2;
			this.txtAnotacoes.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtAnotacoes.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(348, 286);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 15);
			this.label8.TabIndex = 11;
			this.label8.Text = "Categoria";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(726, 285);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(98, 15);
			this.label9.TabIndex = 12;
			this.label9.Text = "Data Cadastro";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(345, 346);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 15);
			this.label10.TabIndex = 13;
			this.label10.Text = "Custo";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(466, 347);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 15);
			this.label11.TabIndex = 14;
			this.label11.Text = "Venda";
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(579, 347);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(118, 13);
			this.label12.TabIndex = 15;
			this.label12.Text = "Margem de Lucro %";
			// 
			// btnApagar
			// 
			this.btnApagar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnApagar.Location = new System.Drawing.Point(12, 69);
			this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnApagar.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnApagar.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnApagar.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnApagar.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnApagar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnApagar.OverrideDefault.Border.Rounding = 5;
			this.btnApagar.OverrideDefault.Border.Width = 1;
			this.btnApagar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnApagar.Size = new System.Drawing.Size(58, 45);
			this.btnApagar.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnApagar.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnApagar.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnApagar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnApagar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnApagar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnApagar.StateCommon.Border.Rounding = 5;
			this.btnApagar.StateCommon.Border.Width = 1;
			this.btnApagar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
			this.btnApagar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
			this.btnApagar.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnApagar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnApagar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnApagar.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnApagar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnApagar.StateTracking.Border.Rounding = 5;
			this.btnApagar.StateTracking.Border.Width = 1;
			this.btnApagar.TabIndex = 16;
			this.btnApagar.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.borracha__1_;
			this.btnApagar.Values.Text = "";
			// 
			// btnSalvar
			// 
			this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Location = new System.Drawing.Point(81, 69);
			this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnSalvar.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnSalvar.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnSalvar.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnSalvar.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnSalvar.OverrideDefault.Border.Rounding = 5;
			this.btnSalvar.OverrideDefault.Border.Width = 1;
			this.btnSalvar.Size = new System.Drawing.Size(56, 45);
			this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnSalvar.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnSalvar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnSalvar.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnSalvar.StateCommon.Border.Rounding = 5;
			this.btnSalvar.StateCommon.Border.Width = 1;
			this.btnSalvar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
			this.btnSalvar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
			this.btnSalvar.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnSalvar.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnSalvar.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnSalvar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnSalvar.StateTracking.Border.Rounding = 5;
			this.btnSalvar.StateTracking.Border.Width = 1;
			this.btnSalvar.TabIndex = 17;
			this.btnSalvar.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.salvar;
			this.btnSalvar.Values.Text = "";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(85, 107);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(47, 15);
			this.label13.TabIndex = 18;
			this.label13.Text = "Salvar";
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(15, 105);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 15);
			this.label14.TabIndex = 19;
			this.label14.Text = "Apagar";
			// 
			// btnExcluir
			// 
			this.btnExcluir.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Location = new System.Drawing.Point(152, 69);
			this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.OverrideDefault.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnExcluir.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnExcluir.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnExcluir.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnExcluir.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnExcluir.OverrideDefault.Border.Rounding = 5;
			this.btnExcluir.OverrideDefault.Border.Width = 1;
			this.btnExcluir.Size = new System.Drawing.Size(56, 45);
			this.btnExcluir.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.btnExcluir.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.btnExcluir.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnExcluir.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnExcluir.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnExcluir.StateCommon.Border.Rounding = 5;
			this.btnExcluir.StateCommon.Border.Width = 1;
			this.btnExcluir.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
			this.btnExcluir.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
			this.btnExcluir.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.StateTracking.Border.Color1 = System.Drawing.Color.Transparent;
			this.btnExcluir.StateTracking.Border.Color2 = System.Drawing.Color.Transparent;
			this.btnExcluir.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
			this.btnExcluir.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.btnExcluir.StateTracking.Border.Rounding = 5;
			this.btnExcluir.StateTracking.Border.Width = 1;
			this.btnExcluir.TabIndex = 20;
			this.btnExcluir.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.perto;
			this.btnExcluir.Values.Text = "";
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(154, 107);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(51, 15);
			this.label15.TabIndex = 21;
			this.label15.Text = "Excluir";
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(344, 468);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 15);
			this.label16.TabIndex = 22;
			this.label16.Text = "Anotações";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::Sistema_Material_de_Construcao.Properties.Resources.R_removebg_preview;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(844, 340);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(266, 290);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::Sistema_Material_de_Construcao.Properties.Resources.materiais_construcao_removebg_preview;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(1, 297);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(335, 319);
			this.pictureBox3.TabIndex = 24;
			this.pictureBox3.TabStop = false;
			// 
			// frmProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1164, 600);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEstoqueMinimo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbUnidade);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtEstoqueAtual);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtAnotacoes);
			this.Controls.Add(this.txtMargem);
			this.Controls.Add(this.txtVenda);
			this.Controls.Add(this.txtCusto);
			this.Controls.Add(this.kryptonGroup1);
			this.Controls.Add(this.txtCodigoBarra);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpDataCadastro);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmProdutos";
			this.Text = "frmProdutos";
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
			this.kryptonGroup1.Panel.ResumeLayout(false);
			this.kryptonGroup1.Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
			this.kryptonGroup1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbUnidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCategoria)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox ckStatus;
		private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataCadastro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNome;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCodigoBarra;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbCategoria;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescricao;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEstoqueMinimo;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEstoqueAtual;
		private System.Windows.Forms.Label label7;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbUnidade;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMargem;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtVenda;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCusto;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAnotacoes;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnApagar;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnExcluir;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}