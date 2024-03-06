﻿namespace Sistema_Material_de_Construcao
{
	partial class frmUnidades
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
			this.dgvUnidade = new System.Windows.Forms.DataGridView();
			this.Id_Unidade_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Unidade_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descricao_Unidade_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.btnExclui = new System.Windows.Forms.DataGridViewImageColumn();
			this.label15 = new System.Windows.Forms.Label();
			this.btnExcluir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.btnApagar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txtNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUnidade
			// 
			this.dgvUnidade.AllowUserToAddRows = false;
			this.dgvUnidade.AllowUserToDeleteRows = false;
			this.dgvUnidade.AllowUserToResizeColumns = false;
			this.dgvUnidade.AllowUserToResizeRows = false;
			this.dgvUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Unidade_Produtos,
            this.Nome_Unidade_Produtos,
            this.Descricao_Unidade_Produtos,
            this.btnEditar,
            this.btnExclui});
			this.dgvUnidade.Location = new System.Drawing.Point(12, 279);
			this.dgvUnidade.MultiSelect = false;
			this.dgvUnidade.Name = "dgvUnidade";
			this.dgvUnidade.ReadOnly = true;
			this.dgvUnidade.RowHeadersVisible = false;
			this.dgvUnidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUnidade.Size = new System.Drawing.Size(636, 221);
			this.dgvUnidade.TabIndex = 80;
			// 
			// Id_Unidade_Produtos
			// 
			this.Id_Unidade_Produtos.DataPropertyName = "Id_Unidade_Produtos";
			this.Id_Unidade_Produtos.HeaderText = "Id_Unidade_Produtos";
			this.Id_Unidade_Produtos.Name = "Id_Unidade_Produtos";
			this.Id_Unidade_Produtos.ReadOnly = true;
			this.Id_Unidade_Produtos.Visible = false;
			// 
			// Nome_Unidade_Produtos
			// 
			this.Nome_Unidade_Produtos.DataPropertyName = "Nome_Unidade_Produtos";
			this.Nome_Unidade_Produtos.HeaderText = "Nome";
			this.Nome_Unidade_Produtos.Name = "Nome_Unidade_Produtos";
			this.Nome_Unidade_Produtos.ReadOnly = true;
			this.Nome_Unidade_Produtos.Width = 250;
			// 
			// Descricao_Unidade_Produtos
			// 
			this.Descricao_Unidade_Produtos.DataPropertyName = "Descricao_Unidade_Produtos";
			this.Descricao_Unidade_Produtos.HeaderText = "Descrição";
			this.Descricao_Unidade_Produtos.Name = "Descricao_Unidade_Produtos";
			this.Descricao_Unidade_Produtos.ReadOnly = true;
			this.Descricao_Unidade_Produtos.Width = 300;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::Sistema_Material_de_Construcao.Properties.Resources.editar;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Width = 30;
			// 
			// btnExclui
			// 
			this.btnExclui.HeaderText = "";
			this.btnExclui.Image = global::Sistema_Material_de_Construcao.Properties.Resources.excluir;
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.ReadOnly = true;
			this.btnExclui.Width = 30;
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(156, 60);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(51, 15);
			this.label15.TabIndex = 79;
			this.label15.Text = "Excluir";
			// 
			// btnExcluir
			// 
			this.btnExcluir.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Location = new System.Drawing.Point(154, 12);
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
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.perto;
			this.btnExcluir.Values.Text = "";
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(17, 60);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 15);
			this.label14.TabIndex = 77;
			this.label14.Text = "Apagar";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(87, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(47, 15);
			this.label13.TabIndex = 76;
			this.label13.Text = "Salvar";
			// 
			// btnSalvar
			// 
			this.btnSalvar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Location = new System.Drawing.Point(83, 12);
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
			this.btnSalvar.TabIndex = 2;
			this.btnSalvar.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.salvar;
			this.btnSalvar.Values.Text = "";
			// 
			// btnApagar
			// 
			this.btnApagar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
			this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnApagar.Location = new System.Drawing.Point(14, 12);
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
			this.btnApagar.TabIndex = 4;
			this.btnApagar.Values.Image = global::Sistema_Material_de_Construcao.Properties.Resources.borracha__1_;
			this.btnApagar.Values.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(121, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 15);
			this.label1.TabIndex = 73;
			this.label1.Text = "Descrição";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(126, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 15);
			this.label2.TabIndex = 72;
			this.label2.Text = "Nome";
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(120, 172);
			this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDescricao.Multiline = true;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(413, 90);
			this.txtDescricao.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtDescricao.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtDescricao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtDescricao.StateCommon.Border.Rounding = 10;
			this.txtDescricao.StateCommon.Border.Width = 2;
			this.txtDescricao.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtDescricao.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.txtDescricao.TabIndex = 1;
			this.txtDescricao.WordWrap = false;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(120, 119);
			this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(413, 29);
			this.txtNome.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
			this.txtNome.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txtNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txtNome.StateCommon.Border.Rounding = 10;
			this.txtNome.StateCommon.Border.Width = 2;
			this.txtNome.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
			this.txtNome.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.txtNome.TabIndex = 0;
			// 
			// frmUnidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(660, 513);
			this.Controls.Add(this.dgvUnidade);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.txtNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmUnidades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.StateCommon.Back.Color1 = System.Drawing.Color.DimGray;
			this.StateCommon.Back.Color2 = System.Drawing.Color.DimGray;
			this.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
			this.StateCommon.Border.Color2 = System.Drawing.Color.DimGray;
			this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.StateCommon.Header.Back.Color1 = System.Drawing.Color.DimGray;
			this.StateCommon.Header.Back.Color2 = System.Drawing.Color.DimGray;
			this.StateCommon.Header.Border.Color1 = System.Drawing.Color.Transparent;
			this.StateCommon.Header.Border.Color2 = System.Drawing.Color.Transparent;
			this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
			this.StateCommon.Header.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
			this.Text = "Cadastro de Unidades";
			((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUnidade;
		private System.Windows.Forms.Label label15;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnExcluir;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
		private ComponentFactory.Krypton.Toolkit.KryptonButton btnApagar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescricao;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Unidade_Produtos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Unidade_Produtos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Unidade_Produtos;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.DataGridViewImageColumn btnExclui;
	}
}