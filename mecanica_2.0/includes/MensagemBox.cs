using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace mecanica_2._0.includes
{
    public partial class MensagemBox : Form
    {
        public MensagemBox()
        {
            InitializeComponent();
            animForm.AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
        }
        bool btnok, btnsim, btncancelar, btnnao = false;
        public enum Icons
        {
            None = 0,
            Info = 1,
            Question = 2,
            Warning = 3,
            Error = 4
        }
        public enum Buttons
        {
            OK = 0,
            OKCancel = 1,
            YesNo = 2,
            YesNoCancel = 3
        }
        private void ConfigurarIcon(Icons icon)
        {
            switch (icon)
            {
                // por enquanto vai ficar com icones aleatorios para teste
                case Icons.Info:
                    picIcon.Image = Properties.Resources.info2;

                    break;
                case Icons.Question:
                    picIcon.Image = Properties.Resources.fechar;
                    break;
                case Icons.Warning:
                    picIcon.Image = Properties.Resources.cep;
                    break;
                case Icons.Error:
                    picIcon.Image = Properties.Resources.bairro1;
                    break;
                default:
                    picIcon.Visible = false;
                    break;
            }
        }
        private void ConfigurarBotoes(Buttons buttons)
        {
            switch (buttons)
            {
                case Buttons.OK:
                    btnOk.Visible = true;
                    btnOk.Left = (this.ClientSize.Width - btnOk.Width) / 2;
                    break;

                case Buttons.OKCancel:
                    btnOk.Visible = true;
                    btnCancelar.Visible = true;
                    btnOk.Left = (this.ClientSize.Width / 2) - btnOk.Width - 10;
                    btnCancelar.Left = (this.ClientSize.Width / 2) + 10;
                    break;

                case Buttons.YesNo:
                    btnSim.Visible = true;
                    btnNao.Visible = true;
                    btnSim.Left = (this.ClientSize.Width / 2) - btnOk.Width - 10;
                    btnNao.Left = (this.ClientSize.Width / 2) + 10;
                    break;

                default:
                    btnOk.Visible = true;
                    btnOk.Left = (this.ClientSize.Width - btnOk.Width) / 2;
                    break;
            }
        }
        public DialogResult Box(string titulo, string mensagem, Buttons buttons, Icons icon)
        {
            lblTitulo.Text = titulo;
            lblDescricao.Text = mensagem;

            ConfigurarIcon(icon);
            ConfigurarBotoes(buttons);

            return this.ShowDialog();
        }
        private void btn_click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            if (btn.Name == btnNao.Name) { this.DialogResult = DialogResult.No; }
            else if (btn.Name == btnSim.Name) { this.DialogResult = DialogResult.Yes; }
            else if (btn.Name == btnCancelar.Name) { this.DialogResult = DialogResult.Cancel; }
            else if (btn.Name == btnOk.Name) { this.DialogResult = DialogResult.OK; }
        }     
        private void btn_Enter(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            if (btn.Name == btnNao.Name){btnnao = true;}
            else if (btn.Name == btnSim.Name){btnsim = true;}
            else if (btn.Name == btnCancelar.Name){btncancelar = true;}
            else if (btn.Name == btnOk.Name){btnok = true;}
            timerCrescer.Start();
        }
        private void btn_Leave(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            if (btn.Name == btnNao.Name){btnnao = false;}
            else if (btn.Name == btnSim.Name){btnsim = false;}
            else if (btn.Name == btnCancelar.Name){btncancelar = false;}
            else if (btn.Name == btnOk.Name){btnok = false;}
            timerCrescer.Start();
        }
        private void BotoesCrescer(Guna2Button nomeBotao)
        {

            // variaveis do valores dos botoes
            int Altura = nomeBotao.Height;
            int Largura = nomeBotao.Width;
            float FontSize = nomeBotao.Font.Size;

            var offset = nomeBotao.TextOffset;

            nomeBotao.FillColor = Color.FromArgb(50, 50, 50);
            nomeBotao.ShadowDecoration.Enabled = true;

            if (Altura <= 44)
            {
                nomeBotao.Height += 1;
                nomeBotao.Width += 2;

                nomeBotao.TextOffset = new Point(offset.X, offset.Y - 1);
                nomeBotao.Font = new Font("Segoe UI Semibold", nomeBotao.Font.Size + 1);
            }
            return;
        }
        private void BotoesDiminuir(Guna2Button nomeBotao)
        {
            // variaveis do valores dos botoes
            int Altura = nomeBotao.Height;
            int Largura = nomeBotao.Width;
            float FontSize = nomeBotao.Font.Size;

            var offset = nomeBotao.TextOffset;

            nomeBotao.FillColor = Color.FromArgb(40, 40, 40);
            nomeBotao.ShadowDecoration.Enabled = false;
            if (Altura >= 40)
            {
                nomeBotao.Height -= 1;
                nomeBotao.Width -= 2;

                nomeBotao.TextOffset = new Point(offset.X, offset.Y + 1);
                nomeBotao.Font = new Font("Segoe UI Semibold", nomeBotao.Font.Size - 1);
            }
            if (offset.Y >= 1)
            {
                nomeBotao.TextOffset = new Point(offset.X, 0);
            }
            return;

        }
        private void timerCrescer_Tick(object sender, EventArgs e)
        {
            if (btnsim){BotoesCrescer(btnSim);}
            else{BotoesDiminuir(btnSim);}

            if (btnnao){BotoesCrescer(btnNao);}
            else{BotoesDiminuir(btnNao);}

            if (btnok){BotoesCrescer(btnOk);}
            else{BotoesDiminuir(btnOk);}

            if (btncancelar){BotoesCrescer(btnCancelar);}
            else{BotoesDiminuir(btnCancelar);}
        }
    }
}
