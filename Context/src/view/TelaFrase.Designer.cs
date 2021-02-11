namespace Context.src.view {
	partial class TelaFrase {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblFrase = new System.Windows.Forms.Label();
			this.lblInstrucao = new System.Windows.Forms.Label();
			this.tbResposta = new System.Windows.Forms.RichTextBox();
			this.btnGravarResposta = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFrase
			// 
			this.lblFrase.AutoSize = true;
			this.lblFrase.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFrase.Location = new System.Drawing.Point(0, 100);
			this.lblFrase.Name = "lblFrase";
			this.lblFrase.Size = new System.Drawing.Size(1033, 62);
			this.lblFrase.TabIndex = 0;
			this.lblFrase.Text = "A praia parecia um formigueiro naquele dia";
			// 
			// lblInstrucao
			// 
			this.lblInstrucao.AutoSize = true;
			this.lblInstrucao.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstrucao.Location = new System.Drawing.Point(0, 592);
			this.lblInstrucao.Name = "lblInstrucao";
			this.lblInstrucao.Size = new System.Drawing.Size(1355, 48);
			this.lblInstrucao.TabIndex = 1;
			this.lblInstrucao.Text = "Escreva no espaço abaixo o que você pensa quando lê a informação acima.";
			// 
			// tbResposta
			// 
			this.tbResposta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbResposta.Location = new System.Drawing.Point(113, 643);
			this.tbResposta.Name = "tbResposta";
			this.tbResposta.Size = new System.Drawing.Size(1694, 364);
			this.tbResposta.TabIndex = 2;
			this.tbResposta.Text = "";
			// 
			// btnGravarResposta
			// 
			this.btnGravarResposta.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGravarResposta.Location = new System.Drawing.Point(864, 1013);
			this.btnGravarResposta.Name = "btnGravarResposta";
			this.btnGravarResposta.Size = new System.Drawing.Size(192, 55);
			this.btnGravarResposta.TabIndex = 3;
			this.btnGravarResposta.Text = "Gravar Resposta";
			this.btnGravarResposta.UseVisualStyleBackColor = true;
			this.btnGravarResposta.Click += new System.EventHandler(this.btnGravarResposta_Click);
			// 
			// TelaFrase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.Controls.Add(this.btnGravarResposta);
			this.Controls.Add(this.tbResposta);
			this.Controls.Add(this.lblInstrucao);
			this.Controls.Add(this.lblFrase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TelaFrase";
			this.Text = "TelaFrase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFrase;
		private System.Windows.Forms.Label lblInstrucao;
		private System.Windows.Forms.RichTextBox tbResposta;
		private System.Windows.Forms.Button btnGravarResposta;
	}
}