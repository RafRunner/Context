namespace Context {
	partial class Form1 {
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.tbNomePesquisador = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbSexoParticipante = new System.Windows.Forms.ComboBox();
			this.tbNomeParticipante = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbArquivoFrases = new System.Windows.Forms.TextBox();
			this.btnSelecionarArquivo = new System.Windows.Forms.Button();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.numIdadeParticipante = new System.Windows.Forms.NumericUpDown();
			this.numNumeroParticipante = new System.Windows.Forms.NumericUpDown();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.numIdadeParticipante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numNumeroParticipante)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome do pesquisador(a)";
			// 
			// tbNomePesquisador
			// 
			this.tbNomePesquisador.Location = new System.Drawing.Point(23, 44);
			this.tbNomePesquisador.Name = "tbNomePesquisador";
			this.tbNomePesquisador.Size = new System.Drawing.Size(654, 27);
			this.tbNomePesquisador.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 181);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sexo";
			// 
			// cbSexoParticipante
			// 
			this.cbSexoParticipante.FormattingEnabled = true;
			this.cbSexoParticipante.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
			this.cbSexoParticipante.Location = new System.Drawing.Point(23, 205);
			this.cbSexoParticipante.Name = "cbSexoParticipante";
			this.cbSexoParticipante.Size = new System.Drawing.Size(477, 28);
			this.cbSexoParticipante.TabIndex = 3;
			// 
			// tbNomeParticipante
			// 
			this.tbNomeParticipante.Location = new System.Drawing.Point(23, 149);
			this.tbNomeParticipante.Name = "tbNomeParticipante";
			this.tbNomeParticipante.Size = new System.Drawing.Size(477, 27);
			this.tbNomeParticipante.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 125);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nome do participante";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(502, 125);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Idade";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(502, 182);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "N.° do participante";
			// 
			// tbArquivoFrases
			// 
			this.tbArquivoFrases.Location = new System.Drawing.Point(23, 334);
			this.tbArquivoFrases.Name = "tbArquivoFrases";
			this.tbArquivoFrases.ReadOnly = true;
			this.tbArquivoFrases.Size = new System.Drawing.Size(477, 27);
			this.tbArquivoFrases.TabIndex = 10;
			// 
			// btnSelecionarArquivo
			// 
			this.btnSelecionarArquivo.Location = new System.Drawing.Point(23, 294);
			this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
			this.btnSelecionarArquivo.Size = new System.Drawing.Size(235, 34);
			this.btnSelecionarArquivo.TabIndex = 11;
			this.btnSelecionarArquivo.Text = "Selecionar arquivo de frases";
			this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
			this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(507, 330);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(170, 34);
			this.btnIniciar.TabIndex = 12;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// numIdadeParticipante
			// 
			this.numIdadeParticipante.Location = new System.Drawing.Point(507, 149);
			this.numIdadeParticipante.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.numIdadeParticipante.Name = "numIdadeParticipante";
			this.numIdadeParticipante.Size = new System.Drawing.Size(170, 27);
			this.numIdadeParticipante.TabIndex = 13;
			// 
			// numNumeroParticipante
			// 
			this.numNumeroParticipante.Location = new System.Drawing.Point(507, 205);
			this.numNumeroParticipante.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numNumeroParticipante.Name = "numNumeroParticipante";
			this.numNumeroParticipante.Size = new System.Drawing.Size(170, 27);
			this.numNumeroParticipante.TabIndex = 14;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 373);
			this.Controls.Add(this.numNumeroParticipante);
			this.Controls.Add(this.numIdadeParticipante);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.btnSelecionarArquivo);
			this.Controls.Add(this.tbArquivoFrases);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbNomeParticipante);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbSexoParticipante);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNomePesquisador);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Context: Menu Principal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numIdadeParticipante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numNumeroParticipante)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNomePesquisador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbSexoParticipante;
		private System.Windows.Forms.TextBox tbNomeParticipante;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbArquivoFrases;
		private System.Windows.Forms.Button btnSelecionarArquivo;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.NumericUpDown numIdadeParticipante;
		private System.Windows.Forms.NumericUpDown numNumeroParticipante;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

