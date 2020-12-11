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
    public partial class frmApresentacao : Form
    {
        
        public static ArvoreBinaria arvore;
        public frmApresentacao()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (arvore == null)
            {
                arvore = new ArvoreBinaria();
            }
            
            Confirm janela = new Confirm();
            janela.Show();
        }

    }
}
