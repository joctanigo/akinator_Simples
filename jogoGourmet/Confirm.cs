using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogoGourmet
{
    public partial class Confirm : Form
    {
       
        
        public Confirm()
        {

            InitializeComponent();
            while (frmApresentacao.arvore.getNodePai().Pai != null)
            {
                frmApresentacao.arvore = frmApresentacao.arvore.move(frmApresentacao.arvore.getNodePai().Pai);
            }
            TipoPrato.Text += frmApresentacao.arvore.getNodePai().Valor + " ?";

        }


        private void btnConfirmSim_Click(object sender, EventArgs e)
        {
          
            if (frmApresentacao.arvore.getNodeDireito() == null)
            {
                this.Close();
                Acerto janela = new Acerto();
                janela.Show();
            }
            else
            {
                TipoPrato.Text = "O prato que você pensou é " + frmApresentacao.arvore.getNodeDireito().Valor + " ?";
            frmApresentacao.arvore = frmApresentacao.arvore.move(frmApresentacao.arvore.getNodeDireito());
            }
        }

        private void btnConfirmNao_Click(object sender, EventArgs e)
        {
            
            if (frmApresentacao.arvore.getNodeEsquerdo() == null)
            {
                this.Close();
                Desisto janela = new Desisto();
                janela.Show();
            }
            else
            {
                TipoPrato.Text = "O prato que você pensou é " + frmApresentacao.arvore.getNodeEsquerdo().Valor + " ?";
                frmApresentacao.arvore = frmApresentacao.arvore.move(frmApresentacao.arvore.getNodeEsquerdo());
            }
        }


    }
}
