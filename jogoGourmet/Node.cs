using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoGourmet
{
    public class Node
    {
        public String Valor { get; set; }
        public Node Direito { get; set; }
        public Node Esquerdo { get; set; }
        public Node Pai { get; set; }
        public int Posicao { get; set; }

        public Node(String value)
           : this(value, null, null, null, 0)
        {
        }

        public Node(Node node)
        {
            Direito = node.Direito;
            Esquerdo = node.Esquerdo;
            Valor = node.Valor;
        }

        public Node(String valor, Node direito, Node esquerdo, Node pai, int posicao)
        {
            if (direito != null)
            {
                direito.Posicao = 1;
            }
            if (esquerdo != null)
            {
                esquerdo.Posicao = -1;
            }
            Direito = direito;
            Esquerdo = esquerdo;
            Pai = pai;
            Valor = valor;
            Posicao = posicao;
        }

        public void AdicionarNode(Node nodePai, Node nodeFilho, bool direcao)
        {
            var teste = Direito;
            if (direcao)
            {
                nodeFilho.Posicao = 1;
                nodePai.Direito = nodeFilho;
            }
            else
            {
                nodeFilho.Posicao = -1;
                nodePai.Esquerdo = nodeFilho;
            }    
        }

       
    }
}
