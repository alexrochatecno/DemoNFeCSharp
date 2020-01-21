using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoNFeCSharp
{
    public partial class FrmNotaDistribuicaoDfeConteudo : Form
    {
        string conteudoOriginal = String.Empty;
        public FrmNotaDistribuicaoDfeConteudo()
        {
            InitializeComponent();
        }

        private void FrmNotaDistribuicaoDfeConteudo_Load(object sender, EventArgs e)
        {

        }

        public void ShowDialogWithResult(string xml)
        {
            conteudoOriginal = xml;
            txtConteudo.Text = conteudoOriginal;


            this.ShowDialog();

        }
    }
}
