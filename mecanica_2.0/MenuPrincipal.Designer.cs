namespace mecanica_2._0
{
    partial class MenuPrincipal
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblTituloTop = new System.Windows.Forms.Label();
            this.btnSair = new Guna.UI2.WinForms.Guna2GradientButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCadVeiculos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCadUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panelLeft.Controls.Add(this.lblCadastro);
            this.panelLeft.Controls.Add(this.lblLogo);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.btnCadVeiculos);
            this.panelLeft.Controls.Add(this.btnCadUser);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(267, 641);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.panelTop.Controls.Add(this.btnSair);
            this.panelTop.Controls.Add(this.lblTituloTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(267, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(948, 70);
            this.panelTop.TabIndex = 2;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(65, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(118, 32);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Mechanic";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCadastro.Location = new System.Drawing.Point(13, 78);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(70, 19);
            this.lblCadastro.TabIndex = 3;
            this.lblCadastro.Text = "Cadastros";
            // 
            // lblTituloTop
            // 
            this.lblTituloTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloTop.AutoSize = true;
            this.lblTituloTop.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTituloTop.Location = new System.Drawing.Point(440, 22);
            this.lblTituloTop.Name = "lblTituloTop";
            this.lblTituloTop.Size = new System.Drawing.Size(80, 32);
            this.lblTituloTop.TabIndex = 0;
            this.lblTituloTop.Text = "Home";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.Animated = true;
            this.btnSair.BorderRadius = 10;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.btnSair.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSair.Image = global::mecanica_2._0.Properties.Resources.LogOut;
            this.btnSair.Location = new System.Drawing.Point(892, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            this.picLogo.Image = global::mecanica_2._0.Properties.Resources.LogoEx;
            this.picLogo.Location = new System.Drawing.Point(12, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(44, 37);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnCadVeiculos
            // 
            this.btnCadVeiculos.Animated = true;
            this.btnCadVeiculos.BorderRadius = 10;
            this.btnCadVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVeiculos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadVeiculos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadVeiculos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadVeiculos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(24)))), ((int)(((byte)(139)))));
            this.btnCadVeiculos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(4)))), ((int)(((byte)(86)))));
            this.btnCadVeiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnCadVeiculos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCadVeiculos.Image = global::mecanica_2._0.Properties.Resources.CadVehicle;
            this.btnCadVeiculos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadVeiculos.Location = new System.Drawing.Point(12, 154);
            this.btnCadVeiculos.Name = "btnCadVeiculos";
            this.btnCadVeiculos.Size = new System.Drawing.Size(238, 47);
            this.btnCadVeiculos.TabIndex = 0;
            this.btnCadVeiculos.Text = "Cadastrar Veiculos";
            // 
            // btnCadUser
            // 
            this.btnCadUser.Animated = true;
            this.btnCadUser.BorderRadius = 10;
            this.btnCadUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(24)))), ((int)(((byte)(139)))));
            this.btnCadUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(4)))), ((int)(((byte)(86)))));
            this.btnCadUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUser.ForeColor = System.Drawing.Color.White;
            this.btnCadUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCadUser.Image = global::mecanica_2._0.Properties.Resources.CadUser;
            this.btnCadUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadUser.Location = new System.Drawing.Point(12, 101);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(238, 47);
            this.btnCadUser.TabIndex = 0;
            this.btnCadUser.Text = "Cadastrar Usuarios";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1215, 641);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2GradientButton btnCadUser;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblCadastro;
        private Guna.UI2.WinForms.Guna2GradientButton btnCadVeiculos;
        private System.Windows.Forms.Label lblTituloTop;
        private Guna.UI2.WinForms.Guna2GradientButton btnSair;
    }
}