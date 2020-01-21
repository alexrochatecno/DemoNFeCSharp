using Microsoft.VisualBasic;
using NFeDataSetX;
using NFeX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValidadorClientX;
using System.Xml;
using DemoNFeCSharp.Properties;
using DemoNFeCSharp.Utils;

namespace DemoNFeCSharp
{
    public partial class FrmPrincipal : Form
    {
        spdNFeX spdNFe = Program.spdNFe;
        spdNFeDataSetX spdNFeDataSet;
        string _ModoEnvio = String.Empty;
        string _NumeroLote = String.Empty;
        string _NumeroSerie = String.Empty;
        string _Motivos = String.Empty;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            spdNFe.ConfigurarSoftwareHouse("08187168000160", String.Empty);

            //NORMAL
            cboModoEnvio.SelectedIndex = 0;

            tbPrincipal.SelectTab(0);

            this.Text = "Demo NF-e - " + spdNFe.Versao;

            btnLoadConfig.PerformClick();
            var listaCertificados = spdNFe.ListarCertificados("\n");


            listaCertificados.Split('\n')
                             .Where(cert => !String.IsNullOrEmpty(cert.Trim()))
                             .ToList()
                             .ForEach(cert => { cboListaCertificado.Items.Add(cert); });


            cboListaCertificado.SelectedItem = spdNFe.NomeCertificado
                                                     .Replace("\r\n", String.Empty);

            _ModoEnvio = cboModoEnvio.Text;
            _ModoEnvio = _ModoEnvio.Equals("normal") ? "NFE" : _ModoEnvio;

        }

        private void BtnLoadConfig_Click(object sender, EventArgs e)
        {
            VerificarExistenciaNfeConfigIni();
            spdNFe.LoadConfig("nfeconfig.ini");
            cboListaCertificado.SelectedItem = spdNFe.NomeCertificado;

            txtUf.Text = spdNFe.UF;
            txtCNPJ.Text = spdNFe.CNPJ;

            txtEPECUf.Text = spdNFe.UF;
            txtEPECCnpj.Text = spdNFe.CNPJ;

            spdNFe.MaxSizeLoteEnvio = 500;
            spdNFe.DiagnosticMode = false;
        }

        private void BtnConfigurarIni_Click(object sender, EventArgs e)
        {
            VerificarExistenciaNfeConfigIni();
            Process.Start("notepad.exe", "nfeConfig.ini");
        }

        private void VerificarExistenciaNfeConfigIni()
        {
            string nfeConfigFile = $@"{Application.StartupPath}\nfeConfig.ini";

            if (!File.Exists(nfeConfigFile))
            {
                var mensagem1 = "O arquivo nfeConfig.ini não foi encontrado. Deseja criá-lo configurações pré-estabelecidades?";
                var mensagem2 = "O arquivo nfeConfig.ini será criado contendo as configurações da instância do componente.";

                if (MessageBox.Show(mensagem1, "nfeConfig.ini", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //O arquivo informado aqui está definido em Properties Project -> Resources -> Strings
                    File.WriteAllText(nfeConfigFile, Resources.nfeConfig);
                }
                else
                {
                    spdNFe.SaveConfig("nfeConfig.ini");
                    MessageBox.Show(mensagem2, "nfeConfig.ini", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void BtnSalvarConfig_Click(object sender, EventArgs e)
        {
            spdNFe.CNPJ = txtCNPJ.Text;
            spdNFe.UF = txtUf.Text;
            spdNFe.SaveConfig("nfeConfig.ini");
            spdNFe.DiagnosticMode = false;
        }

        private void BtnVerificarStatus_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.StatusDoServico();
        }

        private void BtnGerarTX2_Click(object sender, EventArgs e)
        {
            spdNFe.VersaoManual = "6.0";
            _NumeroLote = "1";

            if (!String.IsNullOrEmpty(txtXML.Text.Trim()))
            {
                txtXML.Text = spdNFe.ConverterLoteParaXML(txtXML.Text, LayoutConv.lkDic, "pl_009");
            }
            else
            {
                openFileDialog.InitialDirectory = Application.StartupPath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fullPath = openFileDialog.FileName;
                    txtXML.Text = File.ReadAllText(fullPath);
                    txtXML.Text = spdNFe.ConverterLoteParaXML(txtXML.Text, LayoutConv.lkDic, "pl_009");
                }
            }

            //mmXml.Text = spdNFe.ConverterLoteParaXml(_XML, lkTXTDataSet, pl_009);
        }

        private void BtnGerarDS_Click(object sender, EventArgs e)
        {
            if (spdNFeDataSet == null)
                spdNFeDataSet = new spdNFeDataSetX();

            txtNumeroRecibo.Clear();
            txtNumeroProtocolo.Clear();
            _NumeroLote = "1";
            _NumeroSerie = "1";
            spdNFe.VersaoManual = "6.0";
            spdNFeDataSet.VersaoEsquema = "pl_009";

            spdNFeDataSet.DicionarioXML = spdNFe.DiretorioTemplates + @"Conversor\NFeDataSets.xml";

            #region Preenchimento dos dados da NF-e

            var aDataHoraAtual = DateTime.Now.ToString("s");
            spdNFeDataSet.Incluir();
            spdNFeDataSet.SetCampo("versao_A02=4.00");
            spdNFeDataSet.SetCampo("cUF_B02=41");
            spdNFeDataSet.SetCampo("cNF_B03=999785212");
            spdNFeDataSet.SetCampo("natOp_B04=VENDA DE MERCADORIA ADQ. DE TERCEIRO - PF E PJ NAO CONTRIBUI");
            spdNFeDataSet.SetCampo("mod_B06=55");
            spdNFeDataSet.SetCampo("serie_B07=12");
            spdNFeDataSet.SetCampo("nNF_B08=898397");
            spdNFeDataSet.SetCampo($"DHEMI_B09={aDataHoraAtual}-03:00");
            spdNFeDataSet.SetCampo($"DHSAIENT_B10={aDataHoraAtual}-03:00");
            spdNFeDataSet.SetCampo("tpNF_B11=1");
            spdNFeDataSet.SetCampo("IDDEST_B11A=2");
            spdNFeDataSet.SetCampo("cMunFG_B12=4115200");
            spdNFeDataSet.SetCampo("tpImp_B21=1");
            spdNFeDataSet.SetCampo("tpEmis_B22=1");

            spdNFeDataSet.SetCampo("cDV_B23=0");
            spdNFeDataSet.SetCampo("tpAmb_B24=2");
            spdNFeDataSet.SetCampo("finNFe_B25=1");
            spdNFeDataSet.SetCampo("INDFINAL_B25A=1");
            spdNFeDataSet.SetCampo("INDPRES_B25B=1");
            spdNFeDataSet.SetCampo("procEmi_B26=0");
            spdNFeDataSet.SetCampo("verProc_B27=SomaERP - 1.2.5");

            spdNFeDataSet.SetCampo("CRT_C21=3");
            spdNFeDataSet.SetCampo("CNPJ_C02=08187168000160");
            spdNFeDataSet.SetCampo("xNome_C03=TECNOSPEED E TECNOLOGIA");
            spdNFeDataSet.SetCampo("xFant_C04=TECNOSPEED E TECNOLOGIA");
            spdNFeDataSet.SetCampo("xLgr_C06=RUA DO POVO");
            spdNFeDataSet.SetCampo("nro_C07=711");
            spdNFeDataSet.SetCampo("xBairro_C09=parque petrobrás");
            spdNFeDataSet.SetCampo("cMun_C10=4115200");
            spdNFeDataSet.SetCampo("xMun_C11=MARINGA");
            spdNFeDataSet.SetCampo("UF_C12=PR");
            spdNFeDataSet.SetCampo("CEP_C13=79415000");
            spdNFeDataSet.SetCampo("cPais_C14=1058");
            spdNFeDataSet.SetCampo("xPais_C15=BRASIL");
            spdNFeDataSet.SetCampo("fone_C16=4432222222");
            spdNFeDataSet.SetCampo("IE_C17=9044016688");

            spdNFeDataSet.SetCampo("CNPJ_E02=08187168000160");
            spdNFeDataSet.SetCampo("IDESTRANGEIRO_E03A=");
            spdNFeDataSet.SetCampo("xNome_E04=NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL");
            spdNFeDataSet.SetCampo("xLgr_E06=RUA DO CENTRO");
            spdNFeDataSet.SetCampo("nro_E07=897");
            spdNFeDataSet.SetCampo("xBairro_E09=CENTRAL");
            spdNFeDataSet.SetCampo("cMun_E10=4115200 ");
            spdNFeDataSet.SetCampo("xMun_E11=MARINGÁ");
            spdNFeDataSet.SetCampo("UF_E12=PR");
            spdNFeDataSet.SetCampo("CEP_E13=87500000");
            spdNFeDataSet.SetCampo("cPais_E14=1058");
            spdNFeDataSet.SetCampo("xPais_E15=BRASIL");
            spdNFeDataSet.SetCampo("fone_E16=445555555");
            spdNFeDataSet.SetCampo("INDIEDEST_E16A=1");
            spdNFeDataSet.SetCampo("IE_E17=9044016688");
            spdNFeDataSet.SetCampo("IM_E18A=");

            spdNFeDataSet.SetCampo("email_e19=");

            spdNFeDataSet.SetCampo("CNPJ_GA02=");

            spdNFeDataSet.IncluirItem();
            spdNFeDataSet.SetCampo("nItem_H02=1");
            spdNFeDataSet.SetCampo("cProd_I02=0999");
            spdNFeDataSet.SetCampo("cEAN_I03=SEM GTIN");
            spdNFeDataSet.SetCampo("xProd_I04=MELAO");
            spdNFeDataSet.SetCampo("NCM_I05=11081200");
            spdNFeDataSet.SetCampo("CEST_I05c=0123456");
            spdNFeDataSet.SetCampo("indEscala_I05d=S");
            spdNFeDataSet.SetCampo("CFOP_I08=6102");
            spdNFeDataSet.SetCampo("uCom_I09=CX");
            spdNFeDataSet.SetCampo("qCom_I10=1");
            spdNFeDataSet.SetCampo("vUnCom_I10a=0.0100");
            spdNFeDataSet.SetCampo("vProd_I11=0.01");
            spdNFeDataSet.SetCampo("cEANTrib_I12=SEM GTIN");
            spdNFeDataSet.SetCampo("uTrib_I13=CX");
            spdNFeDataSet.SetCampo("qTrib_I14=1");
            spdNFeDataSet.SetCampo("vUnTrib_I14a=0.0100");
            spdNFeDataSet.SetCampo("indTot_I17b=1");
            spdNFeDataSet.SetCampo("orig_N11=0");
            spdNFeDataSet.SetCampo("CST_N12=00");
            spdNFeDataSet.SetCampo("modBC_N13=0");
            spdNFeDataSet.SetCampo("vBC_N15=0.01");
            spdNFeDataSet.SetCampo("pICMS_N16=12.00");
            spdNFeDataSet.SetCampo("vICMS_N17=0.01");
            spdNFeDataSet.SetCampo("VICMSDESON_N28A=0.00");

            spdNFeDataSet.SetCampo("CST_Q06=01");
            spdNFeDataSet.SetCampo("vBC_Q07=0.01");
            spdNFeDataSet.SetCampo("pPIS_Q08=1.65");
            spdNFeDataSet.SetCampo("vPIS_Q09=0.00");

            spdNFeDataSet.SetCampo("CST_S06=01");
            spdNFeDataSet.SetCampo("vBC_S07=0.01");
            spdNFeDataSet.SetCampo("pCOFINS_S08=7.60");
            spdNFeDataSet.SetCampo("vCOFINS_S11=0.01");

            spdNFeDataSet.SetCampo("nLote_I81=123");
            spdNFeDataSet.SetCampo("qLote_I82=5565.000");
            spdNFeDataSet.SetCampo("dFab_I83=2017-07-23");
            spdNFeDataSet.SetCampo("dVal_I84=2018-07-23");

            spdNFeDataSet.SetCampo("cProdANVISA_k01a=1234567890123");
            spdNFeDataSet.SetCampo("vPMC_k06=1.00");

            spdNFeDataSet.SalvarItem();

            spdNFeDataSet.SetCampo("vBC_W03=0.01");
            spdNFeDataSet.SetCampo("vICMS_W04=0.01");
            spdNFeDataSet.SetCampo("vICMSDeson_W04a=0.00");
            spdNFeDataSet.SetCampo("vFCP_W04h=0.00");
            spdNFeDataSet.SetCampo("vBCST_W05=0.00");
            spdNFeDataSet.SetCampo("vST_W06=0.00");
            spdNFeDataSet.SetCampo("vFCPST_W06a=0.00");
            spdNFeDataSet.SetCampo("vFCPSTRet_W06b=0.00");
            spdNFeDataSet.SetCampo("vST_W06=0.00");
            spdNFeDataSet.SetCampo("vFCPST_W06a=0.00");
            spdNFeDataSet.SetCampo("vFCPSTRet_W06b=0.00");
            spdNFeDataSet.SetCampo("vProd_W07=0.01");
            spdNFeDataSet.SetCampo("vFrete_W08=0.00");
            spdNFeDataSet.SetCampo("vSeg_W09=0.00");
            spdNFeDataSet.SetCampo("vDesc_W10=0.00");
            spdNFeDataSet.SetCampo("vII_W11=0.00");
            spdNFeDataSet.SetCampo("vIPI_W12=0.00");
            spdNFeDataSet.SetCampo("vIPIDevol_W12a=0.00");
            spdNFeDataSet.SetCampo("vPIS_W13=0.00");
            spdNFeDataSet.SetCampo("vCOFINS_W14=0.01");
            spdNFeDataSet.SetCampo("vOutro_W15=0.00");
            spdNFeDataSet.SetCampo("vNF_W16=0.01");

            spdNFeDataSet.SetCampo("modFrete_X02=0");

            spdNFeDataSet.SetCampo("nFat_Y03=2000");
            spdNFeDataSet.SetCampo("vOrig_Y04=1000.00");
            spdNFeDataSet.SetCampo("vDesc_Y05=100.00");
            spdNFeDataSet.SetCampo("vLiq_Y06=900.00");

            spdNFeDataSet.SetCampo("vTroco_YA09=6.04");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=1.01");
            spdNFeDataSet.SetCampo("tPag_YA02=03");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=1");
            spdNFeDataSet.SetCampo("CNPJ_YA05=01234567890123");
            spdNFeDataSet.SetCampo("tBand_YA06=01");
            spdNFeDataSet.SetCampo("cAut_YA07=123456");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=2.01");
            spdNFeDataSet.SetCampo("tPag_YA02=04");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=2");
            spdNFeDataSet.SetCampo("CNPJ_YA05=99999999999999");
            spdNFeDataSet.SetCampo("tBand_YA06=02");
            spdNFeDataSet.SetCampo("cAut_YA07=654321");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=3.01");
            spdNFeDataSet.SetCampo("tPag_YA02=010");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=1");
            spdNFeDataSet.SetCampo("CNPJ_YA05=91234567890123");
            spdNFeDataSet.SetCampo("tBand_YA06=99");
            spdNFeDataSet.SetCampo("cAut_YA07=987654");
            spdNFeDataSet.SalvarParte("YA");


            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("tPag_YA02=15");
            spdNFeDataSet.SetCampo("vPag_YA03=0.01");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("tPag_YA02=15");
            spdNFeDataSet.SetCampo("vPag_YA03=0.01");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("I80");
            spdNFeDataSet.SetCampo("nLote_I81=");
            spdNFeDataSet.SetCampo("qLote_I82=");
            spdNFeDataSet.SetCampo("dFab_I83=");
            spdNFeDataSet.SetCampo("dVal_I84=");
            spdNFeDataSet.SetCampo("cAgreg_I85=");
            spdNFeDataSet.SalvarParte("I80");

            spdNFeDataSet.SetCampo("CNPJ_ZD02=08187168000160");
            spdNFeDataSet.SetCampo("xContato_ZD04=CONSULTORIA TÉCNICA");
            spdNFeDataSet.SetCampo("email_ZD05=contato@tecnospeed.com.br");
            spdNFeDataSet.SetCampo("fone_ZD06=4430379500");

            spdNFeDataSet.Salvar();

            #endregion

            txtXML.Text = spdNFeDataSet.LoteNFe;
            txtIdNota.Text = GetAttributeTagValueXML(txtXML.Text, "infNFe", "Id").Substring(3, 44);
        }

        private void BtnGerarViaREC_Click(object sender, EventArgs e)
        {
            try
            {
                _NumeroLote = "1";

                openFileDialog.InitialDirectory = Application.StartupPath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fullPath = openFileDialog.FileName;
                    txtXML.Text = File.ReadAllText(fullPath);
                }

                txtXML.Text = spdNFe.ConverterLoteParaXML(txtXML.Text, LayoutConv.lkRec, "pl_009");
                txtIdNota.Text = GetAttributeTagValueXML(txtXML.Text, "infNFe", "Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAssinar_Click(object sender, EventArgs e)
        {
            spdNFeDataSet.DiretorioTemplates = spdNFe.DiretorioTemplates;
            txtXML.Text = spdNFe.AssinarNota(@txtXML.Text);

            txtIdNota.Text = GetAttributeTagValueXML(txtXML.Text, "infNFe", "Id").Substring(3, 44);
        }

        private void BtnEnviarNfe_Click(object sender, EventArgs e)
        {
            try
            {
                spdNFe.ModoOperacao = ModoOperacaoNFe.moNormal;
                txtXML.Text = spdNFe.EnviarNF("1", txtXML.Text, false);
                txtNumeroRecibo.Text = GetTagValueXml(txtXML.Text, "nRec");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEnviarSincrono_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.EnviarNFSincrono("1", txtXML.Text, false);
            txtNumeroRecibo.Text = GetTagValueXml(txtXML.Text, "nRec");
        }

        private void BtnConsultarRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                txtXML.Text = spdNFe.ConsultarRecibo(txtNumeroRecibo.Text);
                txtNumeroProtocolo.Text = GetTagValueXml(txtXML.Text, "nProt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConsultarNFe_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.ConsultarNF(txtIdNota.Text);
            txtNumeroProtocolo.Text = GetTagValueXml(txtXML.Text, "nProt");
        }

        private void BtnInutilizarNFe_Click(object sender, EventArgs e)
        {
            try
            {
                var aAno = Interaction.InputBox("Insira o ano da NFe a ser inutilizada (Ano):", "Inutilização", "20");
                var aModelo = Interaction.InputBox("Insira o modelo da NFe a ser inutilizada (modelo)", "NFe", "55");
                var aSerie = Interaction.InputBox("Insira a série da NFe a ser inutilizada", "NFe", "0");
                var aIni = Interaction.InputBox("Insira o número da NFe inicial a ser inutilizada", "NFe", "4");
                var aFim = Interaction.InputBox("Insira o número da NFe final a ser inutilizada", "NFe", "9");
                var txJustificativa = Interaction.InputBox("Insira a justificativa (min. 15 caracteres)", "NFe", "Exemplo de inutilizacao da NFe");

                txtXML.Text = spdNFe.InutilizarNF("", aAno, txtCNPJ.Text, aModelo, aSerie, aIni, aFim, txJustificativa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConverterXMLDS_Click(object sender, EventArgs e)
        {

            if (spdNFeDataSet == null)
            {
                spdNFeDataSet = new spdNFeDataSetX();
            }

            spdNFeDataSet.ConverterXmlParaDataSet(txtXML.Text, "pl_009");
        }

        private void BtnGetVencimento_Click(object sender, EventArgs e)
        {
            MessageBox.Show(spdNFe.GetVencimentoCertificado());
        }

        private void BtnConsultaDFeChave_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.ConsultarDistribuicaoDFeChave("51", spdNFe.CNPJ, txtIdNota.Text);
        }

        private void BtnPreverDanfe_Click(object sender, EventArgs e)
        {
            spdNFe.PreverDanfe(txtXML.Text, "");
        }

        private void BtnEditarDanfe_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdNota.Text.Trim()))
            {
                txtXML.Text = LoadXmlDestinatario(txtIdNota.Text);
                spdNFe.EditarModeloDanfe("1", txtXML.Text, String.Empty);
            }
            else
            {
                spdNFe.EditarModeloDanfe("1", txtXML.Text, String.Empty);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var fullPath = $"{spdNFe.DiretorioXmlDestinatario}{txtIdNota.Text}.pdf";

                if (!String.IsNullOrEmpty(txtIdNota.Text.Trim()))
                {
                    txtXML.Text = LoadXmlDestinatario(txtIdNota.Text);
                }
                spdNFe.ImprimirDanfe("1", txtXML.Text, String.Empty, "doPDF v7");
                //spdNFe.ImprimirDanfe("1", txtXML.Text, String.Empty, String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var fullPath = $"{spdNFe.DiretorioXmlDestinatario}{txtIdNota.Text}.pdf";

                if (!String.IsNullOrEmpty(txtIdNota.Text.Trim()))
                {
                    txtXML.Text = LoadXmlDestinatario(txtIdNota.Text);
                }

                spdNFe.ExportarDanfe("1", txtXML.Text, String.Empty, 1, fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIdNota.Text.Trim()))
            {
                txtXML.Text = LoadXmlDestinatario(txtIdNota.Text);
            }

            spdNFe.LogotipoEmitente = $@"{Application.StartupPath}\Logotipo.jpg";
            spdNFe.ImprimirLocalRetiradaEntrega = true;
            spdNFe.VisualizarDanfe("1", txtXML.Text, String.Empty);
        }

        private void BtnEnviarEmail_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.TestarEmailConfig();
        }

        private void BtnCancelarNFe_Click(object sender, EventArgs e)
        {
            var aJustificativa = Interaction.InputBox("Informe a justificativa do cancelamento:");
            var aDateTimeCancelamento = DateTime.Now.ToString("s"); //s é igual a YYYY-mm-ddThh:nn:ss
            var aUTC = "-3:00";

            txtXML.Text = spdNFe.CancelarNFeEvento(txtIdNota.Text,
                                                   txtNumeroProtocolo.Text,
                                                   aJustificativa,
                                                   aDateTimeCancelamento,
                                                   1,
                                                   aUTC);

        }

        private void BtnGerarXMLDestinatario_Click(object sender, EventArgs e)
        {
            var xmlAssinado = String.Empty;
            var xmlRecibo = String.Empty;
            var pathXMLDestinatario = String.Empty;

            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Selecione o XML assinado";
            xmlAssinado = openFileDialog.ShowDialog() == DialogResult.OK
                       ? openFileDialog.FileName
                       : String.Empty;

            openFileDialog.Title = "Selecione o arquivo de recibo ou retorno da consulta XML";
            xmlRecibo = openFileDialog.ShowDialog() == DialogResult.OK
                       ? openFileDialog.FileName
                       : String.Empty;

            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Title = "Informe o local para Salvar o XML destinatário";

            pathXMLDestinatario = saveFileDialog.ShowDialog() == DialogResult.OK
                                  ? saveFileDialog.FileName
                                  : $@"{spdNFe.DiretorioXmlDestinatario}{txtIdNota.Text}-env.xml";

            if (!String.IsNullOrEmpty(xmlAssinado.Trim())
                && !String.IsNullOrEmpty(xmlRecibo.Trim())
                && !String.IsNullOrEmpty(pathXMLDestinatario.Trim()))
            {
                txtXML.Text = spdNFe.GeraXMLEnvioDestinatario(txtIdNota.Text, xmlAssinado, xmlRecibo, pathXMLDestinatario);
            }
        }

        private void BtnDownloadRegras_Click(object sender, EventArgs e)
        {
            var validador = new spdValidadorClientX();

            validador.Servidor = "http://validadornfe.tecnospeed.com.br:8181/validadorgui/validar";
            validador.DiretorioRegras = spdNFe.DiretorioTemplates + @"\..\Auditor\Regras";
            validador.DiretorioTemplates = spdNFe.DiretorioTemplates + @"\..\Auditor\";
            validador.DiretorioEsquemas = spdNFe.DiretorioEsquemas + @"\..\Auditor\";

            validador.TimeOut = 180000;
            validador.ModoOperacao = TModoOperacao.moLocal;
            validador.DownloadRegras();
            //mmXml.Text := Validador.ValidarXml(mmXML.Text,'|');
        }

        private void BtnGerarXMLCancelamentoDestinatario_Click(object sender, EventArgs e)
        {
            var logEnvio = @"C:\Users\alexandre.requena\Downloads\2017-05-08-10-20-30-719-31170522407451000180550010000000011000000239-caneve-env.xml";
            var logRetorno = @"C:\Users\alexandre.requena\Downloads\2017-05-08-10-27-33-841-31170522407451000180550010000000011000000239-sit.xml";
            spdNFe.GerarXmlCancelamentoDestinatario(txtIdNota.Text, logEnvio, logRetorno, spdNFe.DiretorioXmlDestinatario + txtIdNota.Text + "-can.xml");
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            var frmEventos = new FrmEventos();
            frmEventos.CarregarInformacoes(txtIdNota.Text, txtNumeroProtocolo.Text);
            frmEventos.ShowDialog();
        }

        private void BtnAuditarXML_Click(object sender, EventArgs e)
        {
            var validador = new spdValidadorClientX();

            validador.Servidor = "http://validadornfe.tecnospeed.com.br:8181/validadorgui/validar";
            validador.DiretorioRegras = spdNFe.DiretorioTemplates + @"\..\Auditor\Regras";
            validador.DiretorioTemplates = spdNFe.DiretorioTemplates + @"\..\Auditor\";
            validador.DiretorioEsquemas = spdNFe.DiretorioEsquemas + @"\..\Auditor\";

            validador.TimeOut = 180000;
            validador.ModoOperacao = TModoOperacao.moLocal;
            validador.ExibirRegrasValidacao = true;
            validador.CodigoProduto = 1;
            validador.Estagio = TEstagio.esProducao;
            validador.TipoResposta = TResposta.trTexto;
            validador.LinguagemResposta = TLinguagem.tlHTML;
            validador.DiretorioTemplates = @"C:\Program Files\TecnoSpeed\NFe\arquivos";
            validador.DiretorioEsquemas = @"C:\Program Files\TecnoSpeed\NFe\arquivos\Esquemas";
            validador.DiretorioRegras = @"C:\Program Files\TecnoSpeed\NFe\arquivos\Templates\auditor\Regras";
            validador.DiretorioLogErro = @"\LogErro\";
            validador.WidthHtml = 700;
            validador.HeigthHtml = 500;
            validador.DownloadRegras();

            txtXML.Text = validador.ValidarXml(txtXML.Text, "|");
            validador.ShowHtml(txtXML.Text);
        }

        private void BtnDescompactarXML_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.DescompactarXMLZip(txtXML.Text);
        }

        private void BtnExportarCCe_Click(object sender, EventArgs e)
        {
            spdNFe.VisualizarCCe(txtXML.Text);
        }

        private void BtnDownloadNFe_Click(object sender, EventArgs e)
        {
            try
            {
                //txtXML.Text = spdNFe.ConsultarDistribuicaoDFeChave("43", txtCNPJ.Text, txtIdNota.Text);
                var listaNotasDestinadas = ConsultaNotasDestinadas();
                var frmListaNotasDestinadas = new FrmListaNotasDistribuicaoDFe();

                txtIdNota.Text = frmListaNotasDestinadas.ShowDialogWithResult(listaNotasDestinadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IList<NotaDestinada> ConsultaNotasDestinadas()
        {
            var aCodigoUf = Interaction.InputBox("Informe o código da UF", "ConsultarDistribuicaoDFe", "41");
            var aNSU = Interaction.InputBox("Informe o inicio da sequencia NSU", "ConsultarDistribuicaoDFe", "000000000000000");

            var aTipoNSU = MessageBox.Show("aNSU é específico",
                                           "ConsultarDistribuicaoDFe",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question) == DialogResult.Yes ? TipoNSU.nkEspecifico : TipoNSU.nkUltimo;

            var xml = String.Empty;
            var ultimoNSU = String.Empty;
            var cStat = String.Empty;
            var ultNSU = String.Empty;
            var maxNSU = String.Empty;
            var proximaConsulta = true;
            var listaNotasDestinadas = new List<NotaDestinada>();

            do
            {
                xml = spdNFe.ConsultarDistribuicaoDFe(aCodigoUf, spdNFe.CNPJ, aNSU, aTipoNSU);
                cStat = GetTagValueXml(xml, "cStat");

                if (!cStat.Equals("138"))
                {
                    proximaConsulta = false;
                    break;
                }

                ultNSU = GetTagValueXml(xml, "ultNSU");
                maxNSU = GetTagValueXml(xml, "maxNSU");
                proximaConsulta = cStat.Equals("138") && aNSU != maxNSU;

                aNSU = ultNSU;

                var documentXml = new XmlDocument();
                documentXml.LoadXml(xml);
                var xmlNodes = documentXml.GetElementsByTagName("docZip");

                foreach (XmlNode node in xmlNodes)
                {
                    var conteudoDocZip = node.InnerText;
                    var conteudoDescompactado = spdNFe.DescompactarXMLZip(conteudoDocZip);
                    var schema = node.Attributes["schema"].InnerText;
                    var chaveNfe = ObterChaveNFe(schema, conteudoDescompactado);

                    var notaDestinada = new NotaDestinada();
                    notaDestinada.Nsu = node.Attributes["NSU"].InnerText;
                    notaDestinada.Schema = schema;
                    notaDestinada.ConteudoOriginal = conteudoDocZip;
                    notaDestinada.ConteudoDescompactado = conteudoDescompactado;
                    notaDestinada.Chave = chaveNfe;

                    listaNotasDestinadas.Add(notaDestinada);
                }

            } while (proximaConsulta);

            return listaNotasDestinadas;
        }

        private string ObterChaveNFe(string schema, string conteudoDescompactado)
        {
            schema = schema.ToUpper();
            var result = String.Empty;

            switch (schema)
            {
                case "PROCEVENTONFE_V1.00.XSD":
                    result = GetAttributeTagValueXML(conteudoDescompactado, "infEvento", "Id").Substring(2, 44);
                    break;

                case "RESEVENTO_V1.01.XSD":
                    result = GetTagValueXml(conteudoDescompactado, "chNFe");
                    break;

                case "RESNFE_V1.01.XSD":
                    result = GetTagValueXml(conteudoDescompactado, "chNFe");
                    break;

                case "PROCNFE_V4.00.XSD":
                    result = GetAttributeTagValueXML(conteudoDescompactado, "infNFe", "Id").Substring(3, 44);
                    break;
            }

            return result;
        }

        private void BtnEPECGerarViaDataSet_Click(object sender, EventArgs e)
        {
            if (spdNFeDataSet == null)
            {
                spdNFeDataSet = new spdNFeDataSetX();
            }

            txtEPECNumeroRecibo.Clear();
            txtEPECNumeroProtocolo.Clear();
            _NumeroLote = "1";
            _NumeroSerie = "1";

            spdNFe.VersaoManual = "6.0";
            spdNFeDataSet.VersaoEsquema = "pl_009";

            spdNFeDataSet.DicionarioXML = $@"{spdNFe.DiretorioTemplates}Conversor\NFeDataSets.xml";
            spdNFeDataSet.LoteNFe = String.Empty;

            #region Preenchimento dos dados do EPEC

            var aDataHoraAtual = DateTime.Now.ToString("s");
            spdNFeDataSet.Incluir();
            spdNFeDataSet.SetCampo("versao_A02=4.00");
            spdNFeDataSet.SetCampo("cUF_B02=41");
            spdNFeDataSet.SetCampo("cNF_B03=999785212");
            spdNFeDataSet.SetCampo("natOp_B04=VENDA DE MERCADORIA ADQ. DE TERCEIRO - PF E PJ NAO CONTRIBUI");
            spdNFeDataSet.SetCampo("mod_B06=55");
            spdNFeDataSet.SetCampo("serie_B07=12");
            spdNFeDataSet.SetCampo("nNF_B08=898397");
            spdNFeDataSet.SetCampo($"DHEMI_B09={aDataHoraAtual}-03:00");
            spdNFeDataSet.SetCampo($"DHSAIENT_B10={aDataHoraAtual}-03:00");
            spdNFeDataSet.SetCampo("tpNF_B11=1");
            spdNFeDataSet.SetCampo("IDDEST_B11A=2");
            spdNFeDataSet.SetCampo("cMunFG_B12=4115200");
            spdNFeDataSet.SetCampo("tpImp_B21=");
            spdNFeDataSet.SetCampo("tpEmis_B22=4");

            spdNFeDataSet.SetCampo("cDV_B23=0");
            spdNFeDataSet.SetCampo("tpAmb_B24=2");
            spdNFeDataSet.SetCampo("finNFe_B25=1");
            spdNFeDataSet.SetCampo("INDFINAL_B25A=1");
            spdNFeDataSet.SetCampo("INDPRES_B25B=1");
            spdNFeDataSet.SetCampo("procEmi_B26=0");
            spdNFeDataSet.SetCampo("verProc_B27=SomaERP - 1.2.5");

            spdNFeDataSet.SetCampo("CRT_C21=3");
            spdNFeDataSet.SetCampo("CNPJ_C02=08187168000160");
            spdNFeDataSet.SetCampo("xNome_C03=TECNOSPEED E TECNOLOGIA");
            spdNFeDataSet.SetCampo("xFant_C04=TECNOSPEED E TECNOLOGIA");
            spdNFeDataSet.SetCampo("xLgr_C06=RUA DO POVO");
            spdNFeDataSet.SetCampo("nro_C07=711");
            spdNFeDataSet.SetCampo("xBairro_C09=parque petrobrás");
            spdNFeDataSet.SetCampo("cMun_C10=4115200");
            spdNFeDataSet.SetCampo("xMun_C11=MARINGA");
            spdNFeDataSet.SetCampo("UF_C12=PR");
            spdNFeDataSet.SetCampo("CEP_C13=79415000");
            spdNFeDataSet.SetCampo("cPais_C14=1058");
            spdNFeDataSet.SetCampo("xPais_C15=BRASIL");
            spdNFeDataSet.SetCampo("fone_C16=4432222222");
            spdNFeDataSet.SetCampo("IE_C17=9044016688");

            spdNFeDataSet.SetCampo("CNPJ_E02=08187168000160");
            spdNFeDataSet.SetCampo("IDESTRANGEIRO_E03A=");
            spdNFeDataSet.SetCampo("xNome_E04=NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL");
            spdNFeDataSet.SetCampo("xLgr_E06=RUA DO CENTRO");
            spdNFeDataSet.SetCampo("nro_E07=897");
            spdNFeDataSet.SetCampo("xBairro_E09=CENTRAL");
            spdNFeDataSet.SetCampo("cMun_E10=4115200 ");
            spdNFeDataSet.SetCampo("xMun_E11=MARINGÁ");
            spdNFeDataSet.SetCampo("UF_E12=PR");
            spdNFeDataSet.SetCampo("CEP_E13=87500000");
            spdNFeDataSet.SetCampo("cPais_E14=1058");
            spdNFeDataSet.SetCampo("xPais_E15=BRASIL");
            spdNFeDataSet.SetCampo("fone_E16=445555555");
            spdNFeDataSet.SetCampo("INDIEDEST_E16A=1");
            spdNFeDataSet.SetCampo("IE_E17=9044016688");
            spdNFeDataSet.SetCampo("IM_E18A=");

            spdNFeDataSet.SetCampo("email_e19=");

            spdNFeDataSet.SetCampo("CNPJ_GA02=");

            spdNFeDataSet.IncluirItem();
            spdNFeDataSet.SetCampo("nItem_H02=1");
            spdNFeDataSet.SetCampo("cProd_I02=0999");
            spdNFeDataSet.SetCampo("cEAN_I03=SEM GTIN");
            spdNFeDataSet.SetCampo("xProd_I04=MELAO");
            spdNFeDataSet.SetCampo("NCM_I05=11081200");
            spdNFeDataSet.SetCampo("CEST_I05c=0123456");
            spdNFeDataSet.SetCampo("indEscala_I05d=S");
            spdNFeDataSet.SetCampo("CFOP_I08=6102");
            spdNFeDataSet.SetCampo("uCom_I09=CX");
            spdNFeDataSet.SetCampo("qCom_I10=1");
            spdNFeDataSet.SetCampo("vUnCom_I10a=0.0100");
            spdNFeDataSet.SetCampo("vProd_I11=0.01");
            spdNFeDataSet.SetCampo("cEANTrib_I12=SEM GTIN");
            spdNFeDataSet.SetCampo("uTrib_I13=CX");
            spdNFeDataSet.SetCampo("qTrib_I14=1");
            spdNFeDataSet.SetCampo("vUnTrib_I14a=0.0100");
            spdNFeDataSet.SetCampo("indTot_I17b=1");
            spdNFeDataSet.SetCampo("orig_N11=0");
            spdNFeDataSet.SetCampo("CST_N12=00");
            spdNFeDataSet.SetCampo("modBC_N13=0");
            spdNFeDataSet.SetCampo("vBC_N15=0.01");
            spdNFeDataSet.SetCampo("pICMS_N16=12.00");
            spdNFeDataSet.SetCampo("vICMS_N17=0.01");
            spdNFeDataSet.SetCampo("VICMSDESON_N28A=0.00");

            spdNFeDataSet.SetCampo("CST_Q06=01");
            spdNFeDataSet.SetCampo("vBC_Q07=0.01");
            spdNFeDataSet.SetCampo("pPIS_Q08=1.65");
            spdNFeDataSet.SetCampo("vPIS_Q09=0.00");

            spdNFeDataSet.SetCampo("CST_S06=01");
            spdNFeDataSet.SetCampo("vBC_S07=0.01");
            spdNFeDataSet.SetCampo("pCOFINS_S08=7.60");
            spdNFeDataSet.SetCampo("vCOFINS_S11=0.01");

            spdNFeDataSet.SetCampo("nLote_I81=123");
            spdNFeDataSet.SetCampo("qLote_I82=5565.000");
            spdNFeDataSet.SetCampo("dFab_I83=2017-07-23");
            spdNFeDataSet.SetCampo("dVal_I84=2018-07-23");

            spdNFeDataSet.SetCampo("cProdANVISA_k01a=1234567890123");
            spdNFeDataSet.SetCampo("vPMC_k06=1.00");

            spdNFeDataSet.SalvarItem();

            spdNFeDataSet.SetCampo("vBC_W03=0.01");
            spdNFeDataSet.SetCampo("vICMS_W04=0.01");
            spdNFeDataSet.SetCampo("vICMSDeson_W04a=0.00");
            spdNFeDataSet.SetCampo("vFCP_W04h=0.00");
            spdNFeDataSet.SetCampo("vBCST_W05=0.00");
            spdNFeDataSet.SetCampo("vST_W06=0.00");
            spdNFeDataSet.SetCampo("vFCPST_W06a=0.00");
            spdNFeDataSet.SetCampo("vFCPSTRet_W06b=0.00");
            spdNFeDataSet.SetCampo("vST_W06=0.00");
            spdNFeDataSet.SetCampo("vFCPST_W06a=0.00");
            spdNFeDataSet.SetCampo("vFCPSTRet_W06b=0.00");
            spdNFeDataSet.SetCampo("vProd_W07=0.01");
            spdNFeDataSet.SetCampo("vFrete_W08=0.00");
            spdNFeDataSet.SetCampo("vSeg_W09=0.00");
            spdNFeDataSet.SetCampo("vDesc_W10=0.00");
            spdNFeDataSet.SetCampo("vII_W11=0.00");
            spdNFeDataSet.SetCampo("vIPI_W12=0.00");
            spdNFeDataSet.SetCampo("vIPIDevol_W12a=0.00");
            spdNFeDataSet.SetCampo("vPIS_W13=0.00");
            spdNFeDataSet.SetCampo("vCOFINS_W14=0.01");
            spdNFeDataSet.SetCampo("vOutro_W15=0.00");
            spdNFeDataSet.SetCampo("vNF_W16=0.01");

            spdNFeDataSet.SetCampo("modFrete_X02=0");

            spdNFeDataSet.SetCampo("nFat_Y03=2000");
            spdNFeDataSet.SetCampo("vOrig_Y04=1000.00");
            spdNFeDataSet.SetCampo("vDesc_Y05=100.00");
            spdNFeDataSet.SetCampo("vLiq_Y06=900.00");

            spdNFeDataSet.SetCampo("vTroco_YA09=6.04");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=1.01");
            spdNFeDataSet.SetCampo("tPag_YA02=03");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=1");
            spdNFeDataSet.SetCampo("CNPJ_YA05=01234567890123");
            spdNFeDataSet.SetCampo("tBand_YA06=01");
            spdNFeDataSet.SetCampo("cAut_YA07=123456");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=2.01");
            spdNFeDataSet.SetCampo("tPag_YA02=04");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=2");
            spdNFeDataSet.SetCampo("CNPJ_YA05=99999999999999");
            spdNFeDataSet.SetCampo("tBand_YA06=02");
            spdNFeDataSet.SetCampo("cAut_YA07=654321");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("vPag_YA03=3.01");
            spdNFeDataSet.SetCampo("tPag_YA02=010");
            spdNFeDataSet.SetCampo("tpIntegra_YA04a=1");
            spdNFeDataSet.SetCampo("CNPJ_YA05=91234567890123");
            spdNFeDataSet.SetCampo("tBand_YA06=99");
            spdNFeDataSet.SetCampo("cAut_YA07=987654");
            spdNFeDataSet.SalvarParte("YA");


            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("tPag_YA02=15");
            spdNFeDataSet.SetCampo("vPag_YA03=0.01");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("YA");
            spdNFeDataSet.SetCampo("tPag_YA02=15");
            spdNFeDataSet.SetCampo("vPag_YA03=0.01");
            spdNFeDataSet.SalvarParte("YA");

            spdNFeDataSet.IncluirParte("I80");
            spdNFeDataSet.SetCampo("nLote_I81=");
            spdNFeDataSet.SetCampo("qLote_I82=");
            spdNFeDataSet.SetCampo("dFab_I83=");
            spdNFeDataSet.SetCampo("dVal_I84=");
            spdNFeDataSet.SetCampo("cAgreg_I85=");
            spdNFeDataSet.SalvarParte("I80");

            spdNFeDataSet.SetCampo("CNPJ_ZD02=08187168000160");
            spdNFeDataSet.SetCampo("xContato_ZD04=CONSULTORIA TÉCNICA");
            spdNFeDataSet.SetCampo("email_ZD05=contato@tecnospeed.com.br");
            spdNFeDataSet.SetCampo("fone_ZD06=4430379500");

            spdNFeDataSet.Salvar();

            #endregion

            txtXML.Text = spdNFeDataSet.LoteNFe;
            txtEPECIdNota.Text = spdNFeDataSet.GetCampo("Id_A03").Substring(3, 44);
            txtIdNota.Text = spdNFeDataSet.GetCampo("Id_A03").Substring(3, 44);
        }

        private void BtnEPECMotarEPEC_Click(object sender, EventArgs e)
        {
            spdNFe.ModoOperacao = ModoOperacaoNFe.moEPEC;

            var aDataHoraEvento = DateTime.Now.ToString("s");
            var aUTC = "-03:00";
            txtXML.Text = spdNFe.MontarEPEC(_NumeroLote, txtXML.Text, aDataHoraEvento, aUTC);
        }

        private void BtnEPECAssinar_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.AssinarEPEC(txtXML.Text);
        }

        private void BtnEPECEnviar_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.EnviarEPEC(txtXML.Text);
        }

        private void BtnEPECImprimir_Click(object sender, EventArgs e)
        {
            //spdNFe.ImprimirEPEC(_NumeroLote(*'1'*),edtNumProtEpec.Text,'');
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //spdNFe.VisualizarEPEC(mmXML.Text, edtNumProtEpec.Text, '');
        }

        private void BtnEPECPdf_Click(object sender, EventArgs e)
        {
            //spdNFe.ExportarEPEC(mmXML.Text, edtNumProtEpec.Text, '');
        }

        private void BtnEPECCancelar_Click(object sender, EventArgs e)
        {
            var aJustificativa = Interaction.InputBox("Informe o motivo do cancelamento");
            var aDataHoraEvento = DateTime.Now.ToString("s");
            var aUTC = "-03:00";
            txtXML.Text = spdNFe.CancelarNFeEvento(txtEPECIdNota.Text,
                                                   txtEPECNumeroProtocolo.Text,
                                                   aJustificativa,
                                                   aDataHoraEvento,
                                                   1,
                                                   aUTC);
        }

        private void BtnEPECDescompactarXML_Click(object sender, EventArgs e)
        {
            txtXML.Text = spdNFe.DescompactarXMLZip(txtXML.Text);
        }

        private void BtnCarregarRetornoLote_Click(object sender, EventArgs e)
        {
            _Motivos = GetTagValueXml(txtXML.Text, "xMotivo");
            txtXML.Text = _Motivos;
        }

        private void BtnConverterXMLParaDataSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (spdNFeDataSet == null)
                {
                    spdNFeDataSet = new spdNFeDataSetX();
                }

                if (!String.IsNullOrEmpty(txtXML.Text.Trim()))
                {
                    spdNFeDataSet.ConverterXmlParaDataSet(txtXML.Text, "pl_009");
                }
                else if (!String.IsNullOrEmpty(txtIdNota.Text.Trim()))
                {
                    var fullpath = $@"{spdNFe.DiretorioXmlDestinatario}{txtIdNota}-nfe.xml";
                    var xml = File.ReadAllText(fullpath);

                    txtXML.Text = xml;
                    spdNFeDataSet.ConverterXmlParaDataSet(xml, "pl_009");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private string GetTagValueXml(string xml, string tagName, int numeroOcorrencia = 1)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var xmlNode = xmlDocument.GetElementsByTagName(tagName);

            if (xmlNode.Count >= numeroOcorrencia)
                return xmlNode[numeroOcorrencia - 1].InnerText;

            return String.Empty;
        }

        private string GetAttributeTagValueXML(string xml, string tagName, string attributeName, int numeroOcorrencia = 1)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);

            var xmlNode = xmlDocument.GetElementsByTagName(tagName);

            if (xmlNode.Count >= numeroOcorrencia)
                return xmlNode[numeroOcorrencia - 1].Attributes[attributeName].InnerText;

            return String.Empty;
        }

        private string LoadXmlDestinatario(string aChaveNFe)
        {
            string xmlDestinario = String.Empty;
            string path = $@"{spdNFe.DiretorioXmlDestinatario}{txtIdNota.Text}-nfe.xml";

            if (!File.Exists(path))
            {
                throw new Exception("Arquivo inexistente");
            }

            xmlDestinario = File.ReadAllText(path);

            return xmlDestinario;
        }

        private void BtnAbrirPastaXMLDestinatario_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", spdNFe.DiretorioXmlDestinatario);
        }

        private void BtnConsultarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                var aDocumento = Interaction.InputBox("Informe o documento", "Consulta Cadastro", spdNFe.CNPJ);
                var aTipoDocumento = Interaction.InputBox("Informe o tipo de documento", "Consulta Cadastro", "CNPJ");
                var aUF = Interaction.InputBox("Informe a UF", "Consulta Cadastro", spdNFe.UF);

                txtXML.Text = spdNFe.ConsultarCadastro(aDocumento, aTipoDocumento, aUF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
