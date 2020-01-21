namespace DemoNFeCSharp
{
    partial class FrmListaNotasDistribuicaoDFe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaNotasDistribuicaoDFe));
            this.dtgNotasDestinadas = new System.Windows.Forms.DataGridView();
            this.NSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConteudoOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConteudoDescompactado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscaChave = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotasDestinadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgNotasDestinadas
            // 
            this.dtgNotasDestinadas.AllowUserToAddRows = false;
            this.dtgNotasDestinadas.AllowUserToDeleteRows = false;
            this.dtgNotasDestinadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotasDestinadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NSU,
            this.Schema,
            this.Chave,
            this.ConteudoOriginal,
            this.ConteudoDescompactado,
            this.Visualizar});
            this.dtgNotasDestinadas.Location = new System.Drawing.Point(12, 64);
            this.dtgNotasDestinadas.MultiSelect = false;
            this.dtgNotasDestinadas.Name = "dtgNotasDestinadas";
            this.dtgNotasDestinadas.RowHeadersVisible = false;
            this.dtgNotasDestinadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNotasDestinadas.Size = new System.Drawing.Size(777, 329);
            this.dtgNotasDestinadas.TabIndex = 0;
            this.dtgNotasDestinadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgNotasDestinadas_CellContentClick);
            // 
            // NSU
            // 
            this.NSU.DataPropertyName = "Nsu";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NSU.DefaultCellStyle = dataGridViewCellStyle1;
            this.NSU.HeaderText = "NSU";
            this.NSU.Name = "NSU";
            this.NSU.ReadOnly = true;
            this.NSU.Width = 130;
            // 
            // Schema
            // 
            this.Schema.DataPropertyName = "Schema";
            this.Schema.HeaderText = "Schema";
            this.Schema.Name = "Schema";
            this.Schema.ReadOnly = true;
            this.Schema.Width = 150;
            // 
            // Chave
            // 
            this.Chave.DataPropertyName = "Chave";
            this.Chave.HeaderText = "Chave";
            this.Chave.Name = "Chave";
            this.Chave.ReadOnly = true;
            this.Chave.Width = 430;
            // 
            // ConteudoOriginal
            // 
            this.ConteudoOriginal.DataPropertyName = "ConteudoOriginal";
            this.ConteudoOriginal.HeaderText = "ConteudoOriginal";
            this.ConteudoOriginal.Name = "ConteudoOriginal";
            this.ConteudoOriginal.ReadOnly = true;
            this.ConteudoOriginal.Visible = false;
            // 
            // ConteudoDescompactado
            // 
            this.ConteudoDescompactado.DataPropertyName = "ConteudoDescompactado";
            this.ConteudoDescompactado.HeaderText = "ConteudoDescompactado";
            this.ConteudoDescompactado.Name = "ConteudoDescompactado";
            this.ConteudoDescompactado.ReadOnly = true;
            this.ConteudoDescompactado.Visible = false;
            // 
            // Visualizar
            // 
            this.Visualizar.HeaderText = "";
            this.Visualizar.Image = global::DemoNFeCSharp.Properties.Resources.notepad_5121;
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Width = 40;
            // 
            // txtBuscaChave
            // 
            this.txtBuscaChave.Location = new System.Drawing.Point(12, 38);
            this.txtBuscaChave.Name = "txtBuscaChave";
            this.txtBuscaChave.Size = new System.Drawing.Size(411, 20);
            this.txtBuscaChave.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(676, 399);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(113, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busca pela Chave:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(429, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmListaNotasDistribuicaoDFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 427);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtBuscaChave);
            this.Controls.Add(this.dtgNotasDestinadas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaNotasDistribuicaoDFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Notas Destinadas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotasDestinadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNotasDestinadas;
        private System.Windows.Forms.TextBox txtBuscaChave;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConteudoOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConteudoDescompactado;
        private System.Windows.Forms.DataGridViewImageColumn Visualizar;
    }
}