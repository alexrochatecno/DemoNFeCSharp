using DemoNFeCSharp.Utils;
using Equin.ApplicationFramework;
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
    public partial class FrmListaNotasDistribuicaoDFe : Form
    {
        BindingListView<NotaDestinada> viewNotasDestinadas;
        PropertyDescriptor ordenacao;
        string result = String.Empty;
        public FrmListaNotasDistribuicaoDFe()
        {
            InitializeComponent();
        }


        public string ShowDialogWithResult(IList<NotaDestinada> notasDestinadas)
        {
            if (notasDestinadas != null)
            {
                var listNotasDestinadas = notasDestinadas.ToList();
                ordenacao = TypeDescriptor.GetProperties(typeof(NotaDestinada))["Nsu"];
                viewNotasDestinadas = new BindingListView<NotaDestinada>(listNotasDestinadas);
                dtgNotasDestinadas.DataSource = viewNotasDestinadas;

                viewNotasDestinadas.ApplySort(ordenacao, ListSortDirection.Ascending);
            }

            this.ShowDialog();
            return result;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            if (dtgNotasDestinadas.SelectedRows.Count > 0)
            {
                result = dtgNotasDestinadas.CurrentRow.Cells["Chave"].Value.ToString();
                this.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBuscaChave.Text.Trim()))
            {
                viewNotasDestinadas.ApplyFilter(x => x.Chave.Contains(txtBuscaChave.Text));
                viewNotasDestinadas.Refresh();
            }
            else
            {
                viewNotasDestinadas.RemoveFilter();
                viewNotasDestinadas.Refresh();
            }
        }

        private void DtgNotasDestinadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgNotasDestinadas.SelectedRows.Count > 0)
            {
                if (dtgNotasDestinadas.Columns[e.ColumnIndex].Name.Equals("Visualizar"))
                {
                    var viewCurrent = dtgNotasDestinadas.CurrentRow.DataBoundItem as ObjectView<NotaDestinada>;
                    var conteudo = viewCurrent.Object.ConteudoDescompactado;
                    var frmDistribuicaoConteudo = new FrmNotaDistribuicaoDfeConteudo();

                    frmDistribuicaoConteudo.ShowDialogWithResult(conteudo);
                }

                txtBuscaChave.Text = dtgNotasDestinadas.CurrentRow.Cells["Chave"].Value.ToString();
            }
        }
    }
}
