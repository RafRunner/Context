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
			this.tbResposta = new System.Windows.Forms.RichTextBox();
			this.btnGravarResposta = new System.Windows.Forms.Button();
			this.rtbFrase = new System.Windows.Forms.RichTextBox();
			this.rtbIntrucao = new System.Windows.Forms.RichTextBox();
			this.pictureImagem = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// tbResposta
			// 
			this.tbResposta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbResposta.Location = new System.Drawing.Point(113, 788);
			this.tbResposta.Name = "tbResposta";
			this.tbResposta.Size = new System.Drawing.Size(1694, 219);
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
			// rtbFrase
			// 
			this.rtbFrase.BackColor = System.Drawing.SystemColors.Control;
			this.rtbFrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbFrase.Cursor = System.Windows.Forms.Cursors.Default;
			this.rtbFrase.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbFrase.Location = new System.Drawing.Point(113, 41);
			this.rtbFrase.Name = "rtbFrase";
			this.rtbFrase.ReadOnly = true;
			this.rtbFrase.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.rtbFrase.Size = new System.Drawing.Size(1694, 159);
			this.rtbFrase.TabIndex = 4;
			this.rtbFrase.Text = "A praia parecia um formigueiro naquele dia";
			// 
			// rtbIntrucao
			// 
			this.rtbIntrucao.BackColor = System.Drawing.SystemColors.Control;
			this.rtbIntrucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbIntrucao.Cursor = System.Windows.Forms.Cursors.Default;
			this.rtbIntrucao.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIntrucao.Location = new System.Drawing.Point(113, 733);
			this.rtbIntrucao.Name = "rtbIntrucao";
			this.rtbIntrucao.ReadOnly = true;
			this.rtbIntrucao.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.rtbIntrucao.Size = new System.Drawing.Size(1694, 49);
			this.rtbIntrucao.TabIndex = 5;
			this.rtbIntrucao.Text = "Escreva no espaço abaixo o que você pensa quando lê a informação acima.";
			// 
			// pictureImagem
			// 
			this.pictureImagem.Location = new System.Drawing.Point(612, 206);
			this.pictureImagem.Name = "pictureImagem";
			this.pictureImagem.Size = new System.Drawing.Size(695, 505);
			this.pictureImagem.TabIndex = 6;
			this.pictureImagem.TabStop = false;
			// 
			// TelaFrase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.Controls.Add(this.pictureImagem);
			this.Controls.Add(this.rtbIntrucao);
			this.Controls.Add(this.rtbFrase);
			this.Controls.Add(this.btnGravarResposta);
			this.Controls.Add(this.tbResposta);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TelaFrase";
			this.Text = "TelaFrase";
			((System.ComponentModel.ISupportInitialize)(this.pictureImagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox tbResposta;
		private System.Windows.Forms.Button btnGravarResposta;
		private System.Windows.Forms.RichTextBox rtbFrase;
		private System.Windows.Forms.RichTextBox rtbIntrucao;
		private System.Windows.Forms.PictureBox pictureImagem;
	}
}