using NFeDataSetX;
using NFeX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoNFeCSharp
{
    public partial class FrmEventos : Form
    {
        spdNFeX spdNFe = Program.spdNFe;
        spdNFeDataSetX spdNFeDataSet;
        public FrmEventos()
        {
            InitializeComponent();
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {

        }

        public void CarregarInformacoes(string idNota, string numeroProtocolo)
        {
            txtCCeIdNota.Text = idNota;
            txtCancelamentoIdNota.Text = idNota;
            txtCancelamentoProtocolo.Text = numeroProtocolo;
        }

        private void BtnManifestacaoGerarData_Click(object sender, EventArgs e)
        {
            txtManifestacaoDataEvento.Text = DateTime.Now.ToString("s");
        }

        private void BtnManifestacaoEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var aSequenciaEvento = 1;
                var aCOrgao = "91";
                txtManifestacaoRetorno.Text = spdNFe.EnviarManifestacaoDestinatario(cboManifestacaoTipoEvento.SelectedIndex,
                                                                                    txtManifestacaoIdNota.Text,
                                                                                    txtManifestacaoCNPJDest.Text,
                                                                                    txtManifestacaoJustificativa.Text,
                                                                                    txtManifestacaoDataEvento.Text,
                                                                                    aSequenciaEvento,
                                                                                    cboManifestacaoFuso.Text,
                                                                                    aCOrgao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCCeGerarDataEvento_Click(object sender, EventArgs e)
        {
            txtCCeDataEvento.Text = DateTime.Now.ToString("s");
        }

        private void BtnCCeEnviarCarta_Click(object sender, EventArgs e)
        {
            try
            {
                var aSequenciaEvento = 1;
                txtCCeXml.Text = spdNFe.EnviarCCe(txtCCeIdNota.Text,
                                                  txtCCeJustificativa.Text,
                                                  txtCCeDataEvento.Text,
                                                  txtCCeCodigoUF.Text,
                                                  txtCCeIdLote.Text,
                                                  aSequenciaEvento,
                                                  cboCCeFuso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCCeEditarCCe_Click(object sender, EventArgs e)
        {
            var aXmlCCe = LoadXmlCCe(txtCCeIdNota.Text);
            spdNFe.EditarModeloCCe(aXmlCCe);
        }

        private string LoadXmlCCe(string aChaveCCe)
        {
            string fileName = $@"{Application.StartupPath}\XmlDestinatario\{aChaveCCe}-cce.xml";

            if (!File.Exists(fileName))
                throw new FileNotFoundException("arquivo não encontrado.", fileName);

            string file = File.ReadAllText(fileName);

            return file;
        }

        private void BtnCCeVisualizar_Click(object sender, EventArgs e)
        {
            var aXmlCCe = LoadXmlCCe(txtCCeIdNota.Text);
            spdNFe.VisualizarCCe(aXmlCCe);
        }

        private void BtnCCeExportarPDF_Click(object sender, EventArgs e)
        {
            var aXmlCCe = LoadXmlCCe(txtCCeIdNota.Text);
            spdNFe.ExportarCCe(aXmlCCe, String.Empty);
        }

        private void BtnCCeImprimir_Click(object sender, EventArgs e)
        {
            var aXmlCCe = LoadXmlCCe(txtCCeIdNota.Text);
            spdNFe.ImprimirCCe(aXmlCCe, String.Empty);
        }

        private void BtnCCeEnviarEmail_Click(object sender, EventArgs e)
        {
            spdNFe.EnviarCCeDestinatario(txtCCeIdNota.Text);
        }

        private void BtnCancelamentoGerarDataEvento_Click(object sender, EventArgs e)
        {
            txtCancelamentoDataEvento.Text = DateTime.Now.ToString("s");
        }

        private void BtnCancelamentoEnviar_Click(object sender, EventArgs e)
        {
            var aSequenciaEvento = 1;
            txtCancelamentoRetorno.Text = spdNFe.CancelarNFeEvento(txtCancelamentoIdNota.Text,
                                                                   txtCancelamentoProtocolo.Text,
                                                                   txtCancelamentoJustificativa.Text,
                                                                   txtCancelamentoDataEvento.Text,
                                                                   aSequenciaEvento,
                                                                   cboCancelamentoFuso.Text);
        }
    }
}
