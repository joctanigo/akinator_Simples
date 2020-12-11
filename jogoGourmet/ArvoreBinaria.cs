using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoGourmet
{
    public class ArvoreBinaria
    {
        public Node Arvore { get; set; }

        public ArvoreBinaria()
        {
            Node esquerdo = new Node("Bolo");
            Node direito = new Node("Lasanha");
            Arvore = new Node("Massa",direito,esquerdo,null,0);
            esquerdo.Pai = Arvore;
            direito.Pai = Arvore;

        }
        public ArvoreBinaria(Node node)
        {
            Arvore = new Node(node.Valor, node.Direito, node.Esquerdo, node.Pai, node.Posicao);
        }

        public void AdicionarNode(Node nodePai, Node nodeFilho, bool direcao)
        {
            Arvore.AdicionarNode(nodePai, nodeFilho, direcao);
        }

        public Node getNodePai() {
            return Arvore;
        }

        public Node getNodeDireito()
        {
            return Arvore.Direito;
        }

        public Node getNodeEsquerdo()
        {
            return Arvore.Esquerdo;
        }

        public ArvoreBinaria move(Node node)
        {
            return new ArvoreBinaria(node);
        }

    }
}
