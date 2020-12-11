using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoGourmet
{
    public partial class Determinar : Form
    {
        Node NodeAtual;
        Node NodeFolha;
        public Determinar( Node nodeFolha)
        {
            InitializeComponent();
            NodeAtual = frmApresentacao.arvore.getNodePai();
            NodeFolha = nodeFolha;
            lblDeterminar.Text = NodeFolha.Valor + " é ______ mas " + NodeAtual.Valor + " não.";

        }

        private void btnOkDeterminar_Click(object sender, EventArgs e)
        {
            var valorTipo = txtDeterminar.Text;
            Node novoTipoNode = new Node(valorTipo);

            novoTipoNode.Pai = NodeAtual.Pai;
            novoTipoNode.Posicao = NodeAtual.Posicao;
            NodeFolha.Pai = novoTipoNode;
            NodeFolha.Posicao = 1;
            novoTipoNode.Direito = NodeFolha;
            if (novoTipoNode.Posicao == -1)
            {
                NodeAtual.Pai.Esquerdo = novoTipoNode;
            }
            else
            {
                NodeAtual.Pai.Direito = novoTipoNode;
            }
            NodeAtual.Posicao = -1;
            NodeAtual.Pai = novoTipoNode;
            novoTipoNode.Esquerdo = NodeAtual;

            frmApresentacao.arvore = new ArvoreBinaria(novoTipoNode);

            this.Close();
            

            

        }
    }
}
