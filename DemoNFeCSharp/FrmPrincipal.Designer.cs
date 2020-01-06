namespace DemoNFeCSharp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tbPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrirPastaXMLDestinatario = new System.Windows.Forms.Button();
            this.btnExportarCCe = new System.Windows.Forms.Button();
            this.btnDownloadNFe = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAuditarXML = new System.Windows.Forms.Button();
            this.btnGerarXMLCancelamentoDestinatario = new System.Windows.Forms.Button();
            this.btnDescompactarXML = new System.Windows.Forms.Button();
            this.btnConsultarCadastro = new System.Windows.Forms.Button();
            this.btnDownloadRegras = new System.Windows.Forms.Button();
            this.btnGerarXMLDestinatario = new System.Windows.Forms.Button();
            this.btnCancelarNFe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditarDanfe = new System.Windows.Forms.Button();
            this.btnPreverDanfe = new System.Windows.Forms.Button();
            this.btnAssinar = new System.Windows.Forms.Button();
            this.btnConsultaDFeChave = new System.Windows.Forms.Button();
            this.btnGerarViaREC = new System.Windows.Forms.Button();
            this.btnGetVencimento = new System.Windows.Forms.Button();
            this.btnGerarDS = new System.Windows.Forms.Button();
            this.btnConverterXMLDS = new System.Windows.Forms.Button();
            this.btnGerarTX2 = new System.Windows.Forms.Button();
            this.btnInutilizarNFe = new System.Windows.Forms.Button();
            this.btnVerificarStatus = new System.Windows.Forms.Button();
            this.btnConsultarNFe = new System.Windows.Forms.Button();
            this.btnSalvarConfig = new System.Windows.Forms.Button();
            this.btnConsultarRecibo = new System.Windows.Forms.Button();
            this.btnConfigurarIni = new System.Windows.Forms.Button();
            this.btnEnviarSincrono = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnEnviarNfe = new System.Windows.Forms.Button();
            this.txtNumeroProtocolo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroRecibo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.CNPJ = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboListaCertificado = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEPECDescompactarXML = new System.Windows.Forms.Button();
            this.btnEPECCancelar = new System.Windows.Forms.Button();
            this.gpEPECImpressao = new System.Windows.Forms.GroupBox();
            this.btnEPECPdf = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEPECImprimir = new System.Windows.Forms.Button();
            this.btnEPECEnviar = new System.Windows.Forms.Button();
            this.btnEPECAssinar = new System.Windows.Forms.Button();
            this.btnEPECMotarEPEC = new System.Windows.Forms.Button();
            this.btnEPECGerarViaDataSet = new System.Windows.Forms.Button();
            this.txtEPECNumeroProtocolo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEPECNumeroRecibo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEPECIdNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEPECCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEPECUf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cboModoEnvio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarRetornoLote = new System.Windows.Forms.Button();
            this.btnConverterXMLParaDataSet = new System.Windows.Forms.Button();
            this.tbPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpEPECImpressao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(430, 12);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(496, 544);
            this.txtXML.TabIndex = 1;
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.tabPage1);
            this.tbPrincipal.Controls.Add(this.tabPage2);
            this.tbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(412, 548);
            this.tbPrincipal.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cboListaCertificado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NFe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbrirPastaXMLDestinatario);
            this.panel1.Controls.Add(this.btnExportarCCe);
            this.panel1.Controls.Add(this.btnDownloadNFe);
            this.panel1.Controls.Add(this.btnEventos);
            this.panel1.Controls.Add(this.btnAuditarXML);
            this.panel1.Controls.Add(this.btnGerarXMLCancelamentoDestinatario);
            this.panel1.Controls.Add(this.btnDescompactarXML);
            this.panel1.Controls.Add(this.btnConsultarCadastro);
            this.panel1.Controls.Add(this.btnDownloadRegras);
            this.panel1.Controls.Add(this.btnGerarXMLDestinatario);
            this.panel1.Controls.Add(this.btnCancelarNFe);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAssinar);
            this.panel1.Controls.Add(this.btnConsultaDFeChave);
            this.panel1.Controls.Add(this.btnGerarViaREC);
            this.panel1.Controls.Add(this.btnGetVencimento);
            this.panel1.Controls.Add(this.btnGerarDS);
            this.panel1.Controls.Add(this.btnConverterXMLDS);
            this.panel1.Controls.Add(this.btnGerarTX2);
            this.panel1.Controls.Add(this.btnInutilizarNFe);
            this.panel1.Controls.Add(this.btnVerificarStatus);
            this.panel1.Controls.Add(this.btnConsultarNFe);
            this.panel1.Controls.Add(this.btnSalvarConfig);
            this.panel1.Controls.Add(this.btnConsultarRecibo);
            this.panel1.Controls.Add(this.btnConfigurarIni);
            this.panel1.Controls.Add(this.btnEnviarSincrono);
            this.panel1.Controls.Add(this.btnLoadConfig);
            this.panel1.Controls.Add(this.btnEnviarNfe);
            this.panel1.Controls.Add(this.txtNumeroProtocolo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumeroRecibo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIdNota);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCNPJ);
            this.panel1.Controls.Add(this.CNPJ);
            this.panel1.Controls.Add(this.txtUf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 483);
            this.panel1.TabIndex = 4;
            // 
            // btnAbrirPastaXMLDestinatario
            // 
            this.btnAbrirPastaXMLDestinatario.Location = new System.Drawing.Point(6, 449);
            this.btnAbrirPastaXMLDestinatario.Name = "btnAbrirPastaXMLDestinatario";
            this.btnAbrirPastaXMLDestinatario.Size = new System.Drawing.Size(122, 23);
            this.btnAbrirPastaXMLDestinatario.TabIndex = 43;
            this.btnAbrirPastaXMLDestinatario.Text = "Abrir XMLDestinatario";
            this.btnAbrirPastaXMLDestinatario.UseVisualStyleBackColor = true;
            this.btnAbrirPastaXMLDestinatario.Click += new System.EventHandler(this.BtnAbrirPastaXMLDestinatario_Click);
            // 
            // btnExportarCCe
            // 
            this.btnExportarCCe.Location = new System.Drawing.Point(134, 449);
            this.btnExportarCCe.Name = "btnExportarCCe";
            this.btnExportarCCe.Size = new System.Drawing.Size(122, 23);
            this.btnExportarCCe.TabIndex = 42;
            this.btnExportarCCe.Text = "Exportar CCe";
            this.btnExportarCCe.UseVisualStyleBackColor = true;
            this.btnExportarCCe.Click += new System.EventHandler(this.BtnExportarCCe_Click);
            // 
            // btnDownloadNFe
            // 
            this.btnDownloadNFe.Location = new System.Drawing.Point(262, 449);
            this.btnDownloadNFe.Name = "btnDownloadNFe";
            this.btnDownloadNFe.Size = new System.Drawing.Size(122, 23);
            this.btnDownloadNFe.TabIndex = 41;
            this.btnDownloadNFe.Text = "Donwload NF-e";
            this.btnDownloadNFe.UseVisualStyleBackColor = true;
            this.btnDownloadNFe.Click += new System.EventHandler(this.BtnDownloadNFe_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(6, 420);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(122, 23);
            this.btnEventos.TabIndex = 40;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.BtnEventos_Click);
            // 
            // btnAuditarXML
            // 
            this.btnAuditarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditarXML.Location = new System.Drawing.Point(134, 420);
            this.btnAuditarXML.Name = "btnAuditarXML";
            this.btnAuditarXML.Size = new System.Drawing.Size(122, 23);
            this.btnAuditarXML.TabIndex = 39;
            this.btnAuditarXML.Text = "AuditarXML";
            this.btnAuditarXML.UseVisualStyleBackColor = true;
            this.btnAuditarXML.Click += new System.EventHandler(this.BtnAuditarXML_Click);
            // 
            // btnGerarXMLCancelamentoDestinatario
            // 
            this.btnGerarXMLCancelamentoDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarXMLCancelamentoDestinatario.Location = new System.Drawing.Point(6, 391);
            this.btnGerarXMLCancelamentoDestinatario.Name = "btnGerarXMLCancelamentoDestinatario";
            this.btnGerarXMLCancelamentoDestinatario.Size = new System.Drawing.Size(250, 23);
            this.btnGerarXMLCancelamentoDestinatario.TabIndex = 38;
            this.btnGerarXMLCancelamentoDestinatario.Text = "Gerar XML Cancelamento Destinatario";
            this.btnGerarXMLCancelamentoDestinatario.UseVisualStyleBackColor = true;
            this.btnGerarXMLCancelamentoDestinatario.Click += new System.EventHandler(this.BtnGerarXMLCancelamentoDestinatario_Click);
            // 
            // btnDescompactarXML
            // 
            this.btnDescompactarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescompactarXML.Location = new System.Drawing.Point(262, 420);
            this.btnDescompactarXML.Name = "btnDescompactarXML";
            this.btnDescompactarXML.Size = new System.Drawing.Size(122, 23);
            this.btnDescompactarXML.TabIndex = 37;
            this.btnDescompactarXML.Text = "Descompactar XML";
            this.btnDescompactarXML.UseVisualStyleBackColor = true;
            this.btnDescompactarXML.Click += new System.EventHandler(this.BtnDescompactarXML_Click);
            // 
            // btnConsultarCadastro
            // 
            this.btnConsultarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCadastro.Location = new System.Drawing.Point(262, 391);
            this.btnConsultarCadastro.Name = "btnConsultarCadastro";
            this.btnConsultarCadastro.Size = new System.Drawing.Size(122, 23);
            this.btnConsultarCadastro.TabIndex = 36;
            this.btnConsultarCadastro.Text = "Consultar Cadastro";
            this.btnConsultarCadastro.UseVisualStyleBackColor = true;
            this.btnConsultarCadastro.Click += new System.EventHandler(this.BtnConsultarCadastro_Click);
            // 
            // btnDownloadRegras
            // 
            this.btnDownloadRegras.Location = new System.Drawing.Point(262, 362);
            this.btnDownloadRegras.Name = "btnDownloadRegras";
            this.btnDownloadRegras.Size = new System.Drawing.Size(122, 23);
            this.btnDownloadRegras.TabIndex = 35;
            this.btnDownloadRegras.Text = "Donwload Regras";
            this.btnDownloadRegras.UseVisualStyleBackColor = true;
            this.btnDownloadRegras.Click += new System.EventHandler(this.BtnDownloadRegras_Click);
            // 
            // btnGerarXMLDestinatario
            // 
            this.btnGerarXMLDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarXMLDestinatario.Location = new System.Drawing.Point(6, 362);
            this.btnGerarXMLDestinatario.Name = "btnGerarXMLDestinatario";
            this.btnGerarXMLDestinatario.Size = new System.Drawing.Size(250, 23);
            this.btnGerarXMLDestinatario.TabIndex = 34;
            this.btnGerarXMLDestinatario.Text = "Gerar XML Destinatário";
            this.btnGerarXMLDestinatario.UseVisualStyleBackColor = true;
            this.btnGerarXMLDestinatario.Click += new System.EventHandler(this.BtnGerarXMLDestinatario_Click);
            // 
            // btnCancelarNFe
            // 
            this.btnCancelarNFe.Location = new System.Drawing.Point(262, 333);
            this.btnCancelarNFe.Name = "btnCancelarNFe";
            this.btnCancelarNFe.Size = new System.Drawing.Size(122, 23);
            this.btnCancelarNFe.TabIndex = 33;
            this.btnCancelarNFe.Text = "Cancelar NF-e";
            this.btnCancelarNFe.UseVisualStyleBackColor = true;
            this.btnCancelarNFe.Click += new System.EventHandler(this.BtnCancelarNFe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviarEmail);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnExportarPDF);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnEditarDanfe);
            this.groupBox1.Controls.Add(this.btnPreverDanfe);
            this.groupBox1.Location = new System.Drawing.Point(262, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 197);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impressão";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(6, 164);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(110, 23);
            this.btnEnviarEmail.TabIndex = 44;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.BtnEnviarEmail_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(6, 135);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(110, 23);
            this.btnVisualizar.TabIndex = 43;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.Location = new System.Drawing.Point(6, 106);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(110, 23);
            this.btnExportarPDF.TabIndex = 42;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.BtnExportarPDF_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(6, 77);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 23);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnEditarDanfe
            // 
            this.btnEditarDanfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDanfe.Location = new System.Drawing.Point(6, 48);
            this.btnEditarDanfe.Name = "btnEditarDanfe";
            this.btnEditarDanfe.Size = new System.Drawing.Size(110, 23);
            this.btnEditarDanfe.TabIndex = 40;
            this.btnEditarDanfe.Text = "Editar DANFE";
            this.btnEditarDanfe.UseVisualStyleBackColor = true;
            this.btnEditarDanfe.Click += new System.EventHandler(this.BtnEditarDanfe_Click);
            // 
            // btnPreverDanfe
            // 
            this.btnPreverDanfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreverDanfe.Location = new System.Drawing.Point(6, 19);
            this.btnPreverDanfe.Name = "btnPreverDanfe";
            this.btnPreverDanfe.Size = new System.Drawing.Size(110, 23);
            this.btnPreverDanfe.TabIndex = 39;
            this.btnPreverDanfe.Text = "Prever DANFE";
            this.btnPreverDanfe.UseVisualStyleBackColor = true;
            this.btnPreverDanfe.Click += new System.EventHandler(this.BtnPreverDanfe_Click);
            // 
            // btnAssinar
            // 
            this.btnAssinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssinar.Location = new System.Drawing.Point(6, 333);
            this.btnAssinar.Name = "btnAssinar";
            this.btnAssinar.Size = new System.Drawing.Size(122, 23);
            this.btnAssinar.TabIndex = 31;
            this.btnAssinar.Text = "3. Assinar XML";
            this.btnAssinar.UseVisualStyleBackColor = true;
            this.btnAssinar.Click += new System.EventHandler(this.BtnAssinar_Click);
            // 
            // btnConsultaDFeChave
            // 
            this.btnConsultaDFeChave.Location = new System.Drawing.Point(134, 333);
            this.btnConsultaDFeChave.Name = "btnConsultaDFeChave";
            this.btnConsultaDFeChave.Size = new System.Drawing.Size(122, 23);
            this.btnConsultaDFeChave.TabIndex = 30;
            this.btnConsultaDFeChave.Text = "ConsultaDFe Chave";
            this.btnConsultaDFeChave.UseVisualStyleBackColor = true;
            this.btnConsultaDFeChave.Click += new System.EventHandler(this.BtnConsultaDFeChave_Click);
            // 
            // btnGerarViaREC
            // 
            this.btnGerarViaREC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarViaREC.Location = new System.Drawing.Point(6, 304);
            this.btnGerarViaREC.Name = "btnGerarViaREC";
            this.btnGerarViaREC.Size = new System.Drawing.Size(122, 23);
            this.btnGerarViaREC.TabIndex = 29;
            this.btnGerarViaREC.Text = "2.3. Gerar REC";
            this.btnGerarViaREC.UseVisualStyleBackColor = true;
            this.btnGerarViaREC.Click += new System.EventHandler(this.BtnGerarViaREC_Click);
            // 
            // btnGetVencimento
            // 
            this.btnGetVencimento.Location = new System.Drawing.Point(134, 304);
            this.btnGetVencimento.Name = "btnGetVencimento";
            this.btnGetVencimento.Size = new System.Drawing.Size(122, 23);
            this.btnGetVencimento.TabIndex = 28;
            this.btnGetVencimento.Text = "GetVencimento";
            this.btnGetVencimento.UseVisualStyleBackColor = true;
            this.btnGetVencimento.Click += new System.EventHandler(this.BtnGetVencimento_Click);
            // 
            // btnGerarDS
            // 
            this.btnGerarDS.Location = new System.Drawing.Point(6, 275);
            this.btnGerarDS.Name = "btnGerarDS";
            this.btnGerarDS.Size = new System.Drawing.Size(122, 23);
            this.btnGerarDS.TabIndex = 27;
            this.btnGerarDS.Text = "2.2. Gerar DS NFe 4.00";
            this.btnGerarDS.UseVisualStyleBackColor = true;
            this.btnGerarDS.Click += new System.EventHandler(this.BtnGerarDS_Click);
            // 
            // btnConverterXMLDS
            // 
            this.btnConverterXMLDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverterXMLDS.Location = new System.Drawing.Point(134, 275);
            this.btnConverterXMLDS.Name = "btnConverterXMLDS";
            this.btnConverterXMLDS.Size = new System.Drawing.Size(122, 23);
            this.btnConverterXMLDS.TabIndex = 26;
            this.btnConverterXMLDS.Text = "8.Convert XML DS";
            this.btnConverterXMLDS.UseVisualStyleBackColor = true;
            this.btnConverterXMLDS.Click += new System.EventHandler(this.BtnConverterXMLDS_Click);
            // 
            // btnGerarTX2
            // 
            this.btnGerarTX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTX2.Location = new System.Drawing.Point(6, 246);
            this.btnGerarTX2.Name = "btnGerarTX2";
            this.btnGerarTX2.Size = new System.Drawing.Size(122, 23);
            this.btnGerarTX2.TabIndex = 25;
            this.btnGerarTX2.Text = "2.1. Gerar TX2 4.00";
            this.btnGerarTX2.UseVisualStyleBackColor = true;
            this.btnGerarTX2.Click += new System.EventHandler(this.BtnGerarTX2_Click);
            // 
            // btnInutilizarNFe
            // 
            this.btnInutilizarNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInutilizarNFe.Location = new System.Drawing.Point(134, 246);
            this.btnInutilizarNFe.Name = "btnInutilizarNFe";
            this.btnInutilizarNFe.Size = new System.Drawing.Size(122, 23);
            this.btnInutilizarNFe.TabIndex = 24;
            this.btnInutilizarNFe.Text = "7. Inutilizar NF-e";
            this.btnInutilizarNFe.UseVisualStyleBackColor = true;
            this.btnInutilizarNFe.Click += new System.EventHandler(this.BtnInutilizarNFe_Click);
            // 
            // btnVerificarStatus
            // 
            this.btnVerificarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarStatus.Location = new System.Drawing.Point(6, 217);
            this.btnVerificarStatus.Name = "btnVerificarStatus";
            this.btnVerificarStatus.Size = new System.Drawing.Size(122, 23);
            this.btnVerificarStatus.TabIndex = 23;
            this.btnVerificarStatus.Text = "1. Verificar Status";
            this.btnVerificarStatus.UseVisualStyleBackColor = true;
            this.btnVerificarStatus.Click += new System.EventHandler(this.BtnVerificarStatus_Click);
            // 
            // btnConsultarNFe
            // 
            this.btnConsultarNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNFe.Location = new System.Drawing.Point(134, 217);
            this.btnConsultarNFe.Name = "btnConsultarNFe";
            this.btnConsultarNFe.Size = new System.Drawing.Size(122, 23);
            this.btnConsultarNFe.TabIndex = 22;
            this.btnConsultarNFe.Text = "6. Consultar NF-e";
            this.btnConsultarNFe.UseVisualStyleBackColor = true;
            this.btnConsultarNFe.Click += new System.EventHandler(this.BtnConsultarNFe_Click);
            // 
            // btnSalvarConfig
            // 
            this.btnSalvarConfig.Location = new System.Drawing.Point(6, 188);
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.Size = new System.Drawing.Size(122, 23);
            this.btnSalvarConfig.TabIndex = 21;
            this.btnSalvarConfig.Text = "Salvar Config";
            this.btnSalvarConfig.UseVisualStyleBackColor = true;
            this.btnSalvarConfig.Click += new System.EventHandler(this.BtnSalvarConfig_Click);
            // 
            // btnConsultarRecibo
            // 
            this.btnConsultarRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRecibo.Location = new System.Drawing.Point(134, 188);
            this.btnConsultarRecibo.Name = "btnConsultarRecibo";
            this.btnConsultarRecibo.Size = new System.Drawing.Size(122, 23);
            this.btnConsultarRecibo.TabIndex = 20;
            this.btnConsultarRecibo.Text = "5. Consultar Rec.";
            this.btnConsultarRecibo.UseVisualStyleBackColor = true;
            this.btnConsultarRecibo.Click += new System.EventHandler(this.BtnConsultarRecibo_Click);
            // 
            // btnConfigurarIni
            // 
            this.btnConfigurarIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarIni.Location = new System.Drawing.Point(6, 159);
            this.btnConfigurarIni.Name = "btnConfigurarIni";
            this.btnConfigurarIni.Size = new System.Drawing.Size(122, 23);
            this.btnConfigurarIni.TabIndex = 19;
            this.btnConfigurarIni.Text = "Configurar .ini";
            this.btnConfigurarIni.UseVisualStyleBackColor = true;
            this.btnConfigurarIni.Click += new System.EventHandler(this.BtnConfigurarIni_Click);
            // 
            // btnEnviarSincrono
            // 
            this.btnEnviarSincrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarSincrono.Location = new System.Drawing.Point(134, 159);
            this.btnEnviarSincrono.Name = "btnEnviarSincrono";
            this.btnEnviarSincrono.Size = new System.Drawing.Size(122, 23);
            this.btnEnviarSincrono.TabIndex = 18;
            this.btnEnviarSincrono.Text = "4.1 Enviar Síncr.";
            this.btnEnviarSincrono.UseVisualStyleBackColor = true;
            this.btnEnviarSincrono.Click += new System.EventHandler(this.BtnEnviarSincrono_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConfig.Location = new System.Drawing.Point(6, 130);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(122, 23);
            this.btnLoadConfig.TabIndex = 17;
            this.btnLoadConfig.Text = "LoadConfig";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.BtnLoadConfig_Click);
            // 
            // btnEnviarNfe
            // 
            this.btnEnviarNfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarNfe.Location = new System.Drawing.Point(134, 130);
            this.btnEnviarNfe.Name = "btnEnviarNfe";
            this.btnEnviarNfe.Size = new System.Drawing.Size(122, 23);
            this.btnEnviarNfe.TabIndex = 16;
            this.btnEnviarNfe.Text = "4. Enviar NF-e";
            this.btnEnviarNfe.UseVisualStyleBackColor = true;
            this.btnEnviarNfe.Click += new System.EventHandler(this.BtnEnviarNfe_Click);
            // 
            // txtNumeroProtocolo
            // 
            this.txtNumeroProtocolo.Location = new System.Drawing.Point(6, 104);
            this.txtNumeroProtocolo.Name = "txtNumeroProtocolo";
            this.txtNumeroProtocolo.Size = new System.Drawing.Size(383, 20);
            this.txtNumeroProtocolo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "NumeroProtocolo";
            // 
            // txtNumeroRecibo
            // 
            this.txtNumeroRecibo.Location = new System.Drawing.Point(6, 65);
            this.txtNumeroRecibo.Name = "txtNumeroRecibo";
            this.txtNumeroRecibo.Size = new System.Drawing.Size(383, 20);
            this.txtNumeroRecibo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nº Recibo";
            // 
            // txtIdNota
            // 
            this.txtIdNota.Location = new System.Drawing.Point(194, 26);
            this.txtIdNota.Name = "txtIdNota";
            this.txtIdNota.Size = new System.Drawing.Size(195, 20);
            this.txtIdNota.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id Nota";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(74, 26);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(114, 20);
            this.txtCNPJ.TabIndex = 5;
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSize = true;
            this.CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJ.Location = new System.Drawing.Point(71, 10);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(38, 13);
            this.CNPJ.TabIndex = 4;
            this.CNPJ.Text = "CNPJ";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(6, 26);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(62, 20);
            this.txtUf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF";
            // 
            // cboListaCertificado
            // 
            this.cboListaCertificado.FormattingEnabled = true;
            this.cboListaCertificado.Location = new System.Drawing.Point(6, 6);
            this.cboListaCertificado.Name = "cboListaCertificado";
            this.cboListaCertificado.Size = new System.Drawing.Size(392, 21);
            this.cboListaCertificado.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEPECDescompactarXML);
            this.tabPage2.Controls.Add(this.btnEPECCancelar);
            this.tabPage2.Controls.Add(this.gpEPECImpressao);
            this.tabPage2.Controls.Add(this.btnEPECEnviar);
            this.tabPage2.Controls.Add(this.btnEPECAssinar);
            this.tabPage2.Controls.Add(this.btnEPECMotarEPEC);
            this.tabPage2.Controls.Add(this.btnEPECGerarViaDataSet);
            this.tabPage2.Controls.Add(this.txtEPECNumeroProtocolo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEPECNumeroRecibo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtEPECIdNota);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtEPECCnpj);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtEPECUf);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EPEC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEPECDescompactarXML
            // 
            this.btnEPECDescompactarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECDescompactarXML.Location = new System.Drawing.Point(261, 339);
            this.btnEPECDescompactarXML.Name = "btnEPECDescompactarXML";
            this.btnEPECDescompactarXML.Size = new System.Drawing.Size(131, 23);
            this.btnEPECDescompactarXML.TabIndex = 27;
            this.btnEPECDescompactarXML.Text = "Descompactar XML";
            this.btnEPECDescompactarXML.UseVisualStyleBackColor = true;
            this.btnEPECDescompactarXML.Click += new System.EventHandler(this.BtnEPECDescompactarXML_Click);
            // 
            // btnEPECCancelar
            // 
            this.btnEPECCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECCancelar.Location = new System.Drawing.Point(261, 310);
            this.btnEPECCancelar.Name = "btnEPECCancelar";
            this.btnEPECCancelar.Size = new System.Drawing.Size(131, 23);
            this.btnEPECCancelar.TabIndex = 3;
            this.btnEPECCancelar.Text = "Cancelar NF";
            this.btnEPECCancelar.UseVisualStyleBackColor = true;
            this.btnEPECCancelar.Click += new System.EventHandler(this.BtnEPECCancelar_Click);
            // 
            // gpEPECImpressao
            // 
            this.gpEPECImpressao.Controls.Add(this.btnEPECPdf);
            this.gpEPECImpressao.Controls.Add(this.button6);
            this.gpEPECImpressao.Controls.Add(this.btnEPECImprimir);
            this.gpEPECImpressao.Location = new System.Drawing.Point(249, 153);
            this.gpEPECImpressao.Name = "gpEPECImpressao";
            this.gpEPECImpressao.Size = new System.Drawing.Size(143, 101);
            this.gpEPECImpressao.TabIndex = 26;
            this.gpEPECImpressao.TabStop = false;
            this.gpEPECImpressao.Text = "groupBox2";
            // 
            // btnEPECPdf
            // 
            this.btnEPECPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECPdf.Location = new System.Drawing.Point(6, 73);
            this.btnEPECPdf.Name = "btnEPECPdf";
            this.btnEPECPdf.Size = new System.Drawing.Size(131, 23);
            this.btnEPECPdf.TabIndex = 2;
            this.btnEPECPdf.Text = "PDF EPEC";
            this.btnEPECPdf.UseVisualStyleBackColor = true;
            this.btnEPECPdf.Click += new System.EventHandler(this.BtnEPECPdf_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 44);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Visualizar EPEC";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnEPECImprimir
            // 
            this.btnEPECImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECImprimir.Location = new System.Drawing.Point(6, 17);
            this.btnEPECImprimir.Name = "btnEPECImprimir";
            this.btnEPECImprimir.Size = new System.Drawing.Size(131, 23);
            this.btnEPECImprimir.TabIndex = 0;
            this.btnEPECImprimir.Text = "Imprimir EPEC";
            this.btnEPECImprimir.UseVisualStyleBackColor = true;
            this.btnEPECImprimir.Click += new System.EventHandler(this.BtnEPECImprimir_Click);
            // 
            // btnEPECEnviar
            // 
            this.btnEPECEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECEnviar.Location = new System.Drawing.Point(9, 246);
            this.btnEPECEnviar.Name = "btnEPECEnviar";
            this.btnEPECEnviar.Size = new System.Drawing.Size(234, 35);
            this.btnEPECEnviar.TabIndex = 25;
            this.btnEPECEnviar.Text = "Enviar EPEC";
            this.btnEPECEnviar.UseVisualStyleBackColor = true;
            this.btnEPECEnviar.Click += new System.EventHandler(this.BtnEPECEnviar_Click);
            // 
            // btnEPECAssinar
            // 
            this.btnEPECAssinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECAssinar.Location = new System.Drawing.Point(9, 205);
            this.btnEPECAssinar.Name = "btnEPECAssinar";
            this.btnEPECAssinar.Size = new System.Drawing.Size(234, 35);
            this.btnEPECAssinar.TabIndex = 24;
            this.btnEPECAssinar.Text = "Assinar EPEC";
            this.btnEPECAssinar.UseVisualStyleBackColor = true;
            this.btnEPECAssinar.Click += new System.EventHandler(this.BtnEPECAssinar_Click);
            // 
            // btnEPECMotarEPEC
            // 
            this.btnEPECMotarEPEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECMotarEPEC.Location = new System.Drawing.Point(9, 164);
            this.btnEPECMotarEPEC.Name = "btnEPECMotarEPEC";
            this.btnEPECMotarEPEC.Size = new System.Drawing.Size(234, 35);
            this.btnEPECMotarEPEC.TabIndex = 23;
            this.btnEPECMotarEPEC.Text = "Montar EPEC";
            this.btnEPECMotarEPEC.UseVisualStyleBackColor = true;
            this.btnEPECMotarEPEC.Click += new System.EventHandler(this.BtnEPECMotarEPEC_Click);
            // 
            // btnEPECGerarViaDataSet
            // 
            this.btnEPECGerarViaDataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEPECGerarViaDataSet.Location = new System.Drawing.Point(9, 123);
            this.btnEPECGerarViaDataSet.Name = "btnEPECGerarViaDataSet";
            this.btnEPECGerarViaDataSet.Size = new System.Drawing.Size(234, 35);
            this.btnEPECGerarViaDataSet.TabIndex = 22;
            this.btnEPECGerarViaDataSet.Text = "Gerar Via DataSet";
            this.btnEPECGerarViaDataSet.UseVisualStyleBackColor = true;
            this.btnEPECGerarViaDataSet.Click += new System.EventHandler(this.BtnEPECGerarViaDataSet_Click);
            // 
            // txtEPECNumeroProtocolo
            // 
            this.txtEPECNumeroProtocolo.Location = new System.Drawing.Point(9, 97);
            this.txtEPECNumeroProtocolo.Name = "txtEPECNumeroProtocolo";
            this.txtEPECNumeroProtocolo.Size = new System.Drawing.Size(383, 20);
            this.txtEPECNumeroProtocolo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "NumeroProtocolo";
            // 
            // txtEPECNumeroRecibo
            // 
            this.txtEPECNumeroRecibo.Location = new System.Drawing.Point(9, 58);
            this.txtEPECNumeroRecibo.Name = "txtEPECNumeroRecibo";
            this.txtEPECNumeroRecibo.Size = new System.Drawing.Size(383, 20);
            this.txtEPECNumeroRecibo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nº Recibo";
            // 
            // txtEPECIdNota
            // 
            this.txtEPECIdNota.Location = new System.Drawing.Point(197, 19);
            this.txtEPECIdNota.Name = "txtEPECIdNota";
            this.txtEPECIdNota.Size = new System.Drawing.Size(195, 20);
            this.txtEPECIdNota.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id Nota";
            // 
            // txtEPECCnpj
            // 
            this.txtEPECCnpj.Location = new System.Drawing.Point(77, 19);
            this.txtEPECCnpj.Name = "txtEPECCnpj";
            this.txtEPECCnpj.Size = new System.Drawing.Size(114, 20);
            this.txtEPECCnpj.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "CNPJ";
            // 
            // txtEPECUf
            // 
            this.txtEPECUf.Location = new System.Drawing.Point(9, 19);
            this.txtEPECUf.Name = "txtEPECUf";
            this.txtEPECUf.Size = new System.Drawing.Size(62, 20);
            this.txtEPECUf.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "UF";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(541, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // cboModoEnvio
            // 
            this.cboModoEnvio.FormattingEnabled = true;
            this.cboModoEnvio.Items.AddRange(new object[] {
            "NORMAL",
            "EPEC",
            "SVC-AN",
            "SVC-RS",
            "FS-DA"});
            this.cboModoEnvio.Location = new System.Drawing.Point(14, 579);
            this.cboModoEnvio.Name = "cboModoEnvio";
            this.cboModoEnvio.Size = new System.Drawing.Size(136, 21);
            this.cboModoEnvio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modo de Envio";
            // 
            // btnCarregarRetornoLote
            // 
            this.btnCarregarRetornoLote.Location = new System.Drawing.Point(156, 577);
            this.btnCarregarRetornoLote.Name = "btnCarregarRetornoLote";
            this.btnCarregarRetornoLote.Size = new System.Drawing.Size(122, 23);
            this.btnCarregarRetornoLote.TabIndex = 44;
            this.btnCarregarRetornoLote.Text = "Carregar Retorno Lote";
            this.btnCarregarRetornoLote.UseVisualStyleBackColor = true;
            this.btnCarregarRetornoLote.Click += new System.EventHandler(this.BtnCarregarRetornoLote_Click);
            // 
            // btnConverterXMLParaDataSet
            // 
            this.btnConverterXMLParaDataSet.Location = new System.Drawing.Point(284, 577);
            this.btnConverterXMLParaDataSet.Name = "btnConverterXMLParaDataSet";
            this.btnConverterXMLParaDataSet.Size = new System.Drawing.Size(122, 35);
            this.btnConverterXMLParaDataSet.TabIndex = 45;
            this.btnConverterXMLParaDataSet.Text = "Converter XML para DataSet";
            this.btnConverterXMLParaDataSet.UseVisualStyleBackColor = true;
            this.btnConverterXMLParaDataSet.Click += new System.EventHandler(this.BtnConverterXMLParaDataSet_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 625);
            this.Controls.Add(this.btnConverterXMLParaDataSet);
            this.Controls.Add(this.btnCarregarRetornoLote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboModoEnvio);
            this.Controls.Add(this.tbPrincipal);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo_NFe";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tbPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gpEPECImpressao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TabControl tbPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAbrirPastaXMLDestinatario;
        private System.Windows.Forms.Button btnExportarCCe;
        private System.Windows.Forms.Button btnDownloadNFe;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAuditarXML;
        private System.Windows.Forms.Button btnGerarXMLCancelamentoDestinatario;
        private System.Windows.Forms.Button btnDescompactarXML;
        private System.Windows.Forms.Button btnConsultarCadastro;
        private System.Windows.Forms.Button btnDownloadRegras;
        private System.Windows.Forms.Button btnGerarXMLDestinatario;
        private System.Windows.Forms.Button btnCancelarNFe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditarDanfe;
        private System.Windows.Forms.Button btnPreverDanfe;
        private System.Windows.Forms.Button btnAssinar;
        private System.Windows.Forms.Button btnConsultaDFeChave;
        private System.Windows.Forms.Button btnGerarViaREC;
        private System.Windows.Forms.Button btnGetVencimento;
        private System.Windows.Forms.Button btnGerarDS;
        private System.Windows.Forms.Button btnConverterXMLDS;
        private System.Windows.Forms.Button btnGerarTX2;
        private System.Windows.Forms.Button btnInutilizarNFe;
        private System.Windows.Forms.Button btnVerificarStatus;
        private System.Windows.Forms.Button btnConsultarNFe;
        private System.Windows.Forms.Button btnSalvarConfig;
        private System.Windows.Forms.Button btnConsultarRecibo;
        private System.Windows.Forms.Button btnConfigurarIni;
        private System.Windows.Forms.Button btnEnviarSincrono;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnEnviarNfe;
        private System.Windows.Forms.TextBox txtNumeroProtocolo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroRecibo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label CNPJ;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboListaCertificado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cboModoEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarregarRetornoLote;
        private System.Windows.Forms.Button btnConverterXMLParaDataSet;
        private System.Windows.Forms.Button btnEPECDescompactarXML;
        private System.Windows.Forms.Button btnEPECCancelar;
        private System.Windows.Forms.GroupBox gpEPECImpressao;
        private System.Windows.Forms.Button btnEPECPdf;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEPECImprimir;
        private System.Windows.Forms.Button btnEPECEnviar;
        private System.Windows.Forms.Button btnEPECAssinar;
        private System.Windows.Forms.Button btnEPECMotarEPEC;
        private System.Windows.Forms.Button btnEPECGerarViaDataSet;
        private System.Windows.Forms.TextBox txtEPECNumeroProtocolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEPECNumeroRecibo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEPECIdNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEPECCnpj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEPECUf;
        private System.Windows.Forms.Label label10;
    }
}

