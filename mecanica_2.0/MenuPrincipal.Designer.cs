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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCadVeiculos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCadUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSair = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTituloTop = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.panelLeft.Controls.Add(this.lblCadastro);
            this.panelLeft.Controls.Add(this.lblLogo);
            this.panelLeft.Controls.Add(this.picLogo);
            this.panelLeft.Controls.Add(this.btnCadVeiculos);
            this.panelLeft.Controls.Add(this.btnCadUser);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 607);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
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
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
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
            this.btnCadVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadVeiculos.Animated = true;
            this.btnCadVeiculos.BorderRadius = 10;
            this.btnCadVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadVeiculos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadVeiculos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadVeiculos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadVeiculos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnCadVeiculos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCadVeiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnCadVeiculos.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCadVeiculos.Image = global::mecanica_2._0.Properties.Resources.CadVehicle;
            this.btnCadVeiculos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadVeiculos.Location = new System.Drawing.Point(12, 154);
            this.btnCadVeiculos.Name = "btnCadVeiculos";
            this.btnCadVeiculos.Size = new System.Drawing.Size(192, 47);
            this.btnCadVeiculos.TabIndex = 0;
            this.btnCadVeiculos.Text = "Cadastrar Veiculos";
            // 
            // btnCadUser
            // 
            this.btnCadUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadUser.Animated = true;
            this.btnCadUser.BorderRadius = 10;
            this.btnCadUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnCadUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCadUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUser.ForeColor = System.Drawing.Color.White;
            this.btnCadUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCadUser.Image = global::mecanica_2._0.Properties.Resources.CadUser;
            this.btnCadUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadUser.Location = new System.Drawing.Point(12, 101);
            this.btnCadUser.Name = "btnCadUser";
            this.btnCadUser.Size = new System.Drawing.Size(192, 47);
            this.btnCadUser.TabIndex = 0;
            this.btnCadUser.Text = "Cadastrar Usuarios";
            this.btnCadUser.Click += new System.EventHandler(this.btnCadUser_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.panelTop.Controls.Add(this.btnSair);
            this.panelTop.Controls.Add(this.lblTituloTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(215, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(870, 46);
            this.panelTop.TabIndex = 2;
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
            this.btnSair.Location = new System.Drawing.Point(814, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 1;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTituloTop
            // 
            this.lblTituloTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloTop.AutoSize = true;
            this.lblTituloTop.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTituloTop.Location = new System.Drawing.Point(395, 7);
            this.lblTituloTop.Name = "lblTituloTop";
            this.lblTituloTop.Size = new System.Drawing.Size(80, 32);
            this.lblTituloTop.TabIndex = 0;
            this.lblTituloTop.Text = "Home";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(215, 46);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(870, 561);
            this.panelMain.TabIndex = 3;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 100;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1085, 607);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
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
        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}