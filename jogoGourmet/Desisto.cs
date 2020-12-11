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
    public partial class Desisto : Form
    {
        
        public Desisto()
        {
            InitializeComponent();
            //node = nodeAtual;
        }


        private void btnOkDesisto_Click(object sender, EventArgs e)
        {
            var nomePrato = txtPratoPensado.Text;
            Node novoPrato = new Node(nomePrato);
            Determinar janela = new Determinar(novoPrato);
            janela.Show();
            this.Close();
        }
    }
}
