namespace mecanica_2._0.Forms
{
    partial class GerenciarUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toggleDGV = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblUsuariosCadastrados = new System.Windows.Forms.Label();
            this.dtgUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnMais = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnContrato = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnEnderecos = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtTelefones = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnPessoais = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnFechar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelExibir = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.guna2Panel1.Controls.Add(this.toggleDGV);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.lblUsuariosCadastrados);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1405, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // toggleDGV
            // 
            this.toggleDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleDGV.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleDGV.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleDGV.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDGV.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDGV.Location = new System.Drawing.Point(1346, 24);
            this.toggleDGV.Name = "toggleDGV";
            this.toggleDGV.Size = new System.Drawing.Size(35, 20);
            this.toggleDGV.TabIndex = 2;
            this.toggleDGV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDGV.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleDGV.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleDGV.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleDGV.CheckedChanged += new System.EventHandler(this.toggleDGV_CheckedChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator1.TabIndex = 1;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // lblUsuariosCadastrados
            // 
            this.lblUsuariosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUsuariosCadastrados.AutoSize = true;
            this.lblUsuariosCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuariosCadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosCadastrados.ForeColor = System.Drawing.Color.White;
            this.lblUsuariosCadastrados.Location = new System.Drawing.Point(594, 14);
            this.lblUsuariosCadastrados.Name = "lblUsuariosCadastrados";
            this.lblUsuariosCadastrados.Size = new System.Drawing.Size(217, 32);
            this.lblUsuariosCadastrados.TabIndex = 0;
            this.lblUsuariosCadastrados.Text = "Modo Visualização";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgUsuarios.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgUsuarios.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgUsuarios.Location = new System.Drawing.Point(0, 60);
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersVisible = false;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(1405, 452);
            this.dtgUsuarios.TabIndex = 2;
            this.dtgUsuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dtgUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dtgUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgUsuarios.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dtgUsuarios.ThemeStyle.GridColor = System.Drawing.Color.DarkOrange;
            this.dtgUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))));
            this.dtgUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgUsuarios.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgUsuarios.ThemeStyle.ReadOnly = true;
            this.dtgUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.dtgUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dtgUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.dtgUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellClick);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.guna2Separator2.Location = new System.Drawing.Point(0, 512);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnMais);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnContrato);
            this.panel1.Controls.Add(this.btnEnderecos);
            this.panel1.Controls.Add(this.txtTelefones);
            this.panel1.Controls.Add(this.btnPessoais);
            this.panel1.Controls.Add(this.guna2Separator3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 61);
            this.panel1.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Animated = true;
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BorderRadius = 10;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(896, 0);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(16);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 51);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseTransparentBackground = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(1017, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(25, 51);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Animated = true;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderRadius = 10;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(1042, 0);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 51);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseTransparentBackground = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnMais
            // 
            this.btnMais.Animated = true;
            this.btnMais.BackColor = System.Drawing.Color.Transparent;
            this.btnMais.BorderRadius = 10;
            this.btnMais.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMais.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMais.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMais.Enabled = false;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMais.ForeColor = System.Drawing.Color.White;
            this.btnMais.Location = new System.Drawing.Point(1163, 0);
            this.btnMais.Margin = new System.Windows.Forms.Padding(16);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(121, 51);
            this.btnMais.TabIndex = 6;
            this.btnMais.Text = "Mais";
            this.btnMais.UseTransparentBackground = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Animated = true;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BorderRadius = 10;
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(1284, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(16);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 51);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseTransparentBackground = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Animated = true;
            this.btnContrato.BackColor = System.Drawing.Color.Transparent;
            this.btnContrato.BorderRadius = 10;
            this.btnContrato.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnContrato.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContrato.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContrato.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContrato.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContrato.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContrato.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnContrato.ForeColor = System.Drawing.Color.White;
            this.btnContrato.IndicateFocus = true;
            this.btnContrato.Location = new System.Drawing.Point(363, 0);
            this.btnContrato.Margin = new System.Windows.Forms.Padding(12);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(121, 51);
            this.btnContrato.TabIndex = 5;
            this.btnContrato.Text = "Contrato";
            this.btnContrato.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnContrato.UseTransparentBackground = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btnEnderecos
            // 
            this.btnEnderecos.Animated = true;
            this.btnEnderecos.BackColor = System.Drawing.Color.Transparent;
            this.btnEnderecos.BorderRadius = 10;
            this.btnEnderecos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEnderecos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnderecos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnderecos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnderecos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnderecos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnderecos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnderecos.ForeColor = System.Drawing.Color.White;
            this.btnEnderecos.IndicateFocus = true;
            this.btnEnderecos.Location = new System.Drawing.Point(242, 0);
            this.btnEnderecos.Margin = new System.Windows.Forms.Padding(12);
            this.btnEnderecos.Name = "btnEnderecos";
            this.btnEnderecos.Size = new System.Drawing.Size(121, 51);
            this.btnEnderecos.TabIndex = 5;
            this.btnEnderecos.Text = "Endereços";
            this.btnEnderecos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnEnderecos.UseTransparentBackground = true;
            this.btnEnderecos.Click += new System.EventHandler(this.btnEnderecos_Click);
            // 
            // txtTelefones
            // 
            this.txtTelefones.Animated = true;
            this.txtTelefones.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefones.BorderRadius = 10;
            this.txtTelefones.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.txtTelefones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTelefones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txtTelefones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtTelefones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txtTelefones.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTelefones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefones.ForeColor = System.Drawing.Color.White;
            this.txtTelefones.IndicateFocus = true;
            this.txtTelefones.Location = new System.Drawing.Point(121, 0);
            this.txtTelefones.Margin = new System.Windows.Forms.Padding(12);
            this.txtTelefones.Name = "txtTelefones";
            this.txtTelefones.Size = new System.Drawing.Size(121, 51);
            this.txtTelefones.TabIndex = 5;
            this.txtTelefones.Text = "Telefones";
            this.txtTelefones.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txtTelefones.UseTransparentBackground = true;
            this.txtTelefones.Click += new System.EventHandler(this.txtTelefones_Click);
            // 
            // btnPessoais
            // 
            this.btnPessoais.Animated = true;
            this.btnPessoais.BackColor = System.Drawing.Color.Transparent;
            this.btnPessoais.BorderRadius = 10;
            this.btnPessoais.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPessoais.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPessoais.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPessoais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPessoais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPessoais.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPessoais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPessoais.ForeColor = System.Drawing.Color.White;
            this.btnPessoais.IndicateFocus = true;
            this.btnPessoais.Location = new System.Drawing.Point(0, 0);
            this.btnPessoais.Margin = new System.Windows.Forms.Padding(12);
            this.btnPessoais.Name = "btnPessoais";
            this.btnPessoais.Size = new System.Drawing.Size(121, 51);
            this.btnPessoais.TabIndex = 5;
            this.btnPessoais.Text = "Informações Pessoais";
            this.btnPessoais.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btnPessoais.UseTransparentBackground = true;
            this.btnPessoais.Click += new System.EventHandler(this.txtPessoais_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.guna2Separator3.Location = new System.Drawing.Point(0, 51);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator3.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFechar.Animated = true;
            this.btnFechar.BorderRadius = 10;
            this.btnFechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFechar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnFechar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnFechar.Image = global::mecanica_2._0.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(1369, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 32);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelExibir
            // 
            this.panelExibir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExibir.Location = new System.Drawing.Point(0, 583);
            this.panelExibir.Name = "panelExibir";
            this.panelExibir.Size = new System.Drawing.Size(1405, 264);
            this.panelExibir.TabIndex = 4;
            // 
            // GerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1405, 843);
            this.Controls.Add(this.panelExibir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarUsuarios";
            this.Text = "Cadastrar Usuarios";
            this.Load += new System.EventHandler(this.GerenciarUsuarios_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblUsuariosCadastrados;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgUsuarios;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton btnPessoais;
        private Guna.UI2.WinForms.Guna2TileButton txtTelefones;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleDGV;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2TileButton btnEnderecos;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2TileButton btnContrato;
        private Guna.UI2.WinForms.Guna2Button btnMais;
        private Guna.UI2.WinForms.Guna2GradientButton btnFechar;
        private System.Windows.Forms.Panel panelExibir;
    }
}