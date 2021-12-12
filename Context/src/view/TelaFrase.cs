using Context.src.arquivos;
using Context.src.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Context.src.view {
	public partial class TelaFrase : Form {

		private readonly int height = Screen.PrimaryScreen.Bounds.Height;
		private readonly int width = Screen.PrimaryScreen.Bounds.Width;

		private readonly List<string> frases;
		private int indexFraseAtual = 0;

		private readonly GeradorRelatorio geradorRelatorio;

		public TelaFrase(List<string> frases, GeradorRelatorio geradorRelatorio) {
			InitializeComponent();

			this.frases = frases;
			this.geradorRelatorio = geradorRelatorio;

			Location = new Point(0, 0);
			Size = new Size(width, height);

			ViewUtils.CorrigeEscalaTodosOsFilhos(this);

			lblFrase.MaximumSize = new Size(tbResposta.Width, 0);
			lblFrase.AutoSize = true;

			lblInstrucao.MaximumSize = new Size(tbResposta.Width, 0);
			lblInstrucao.AutoSize = true;

			MudarFrase();
		}

		private void MudarFrase() {
			lblFrase.Text = frases[indexFraseAtual++];
			lblFrase.Location = new Point((width - lblFrase.Width) / 2, lblFrase.Location.Y);
			tbResposta.Text = "";

			MudarInstrucao();
			tbResposta.Focus();
		}

		private void MudarInstrucao() {
			var alturaAnterior = lblInstrucao.Height;
			lblInstrucao.Text = frases[indexFraseAtual++];
			lblInstrucao.Location = new Point((width - lblInstrucao.Width) / 2, lblInstrucao.Location.Y - lblInstrucao.Height + alturaAnterior);
			Size = new Size(width, height);
		}

		private void btnGravarResposta_Click(object sender, EventArgs e) {
			var resposta = tbResposta.Text;
			if (string.IsNullOrEmpty(resposta)) {
				return;
			}

			geradorRelatorio.AdicionarEvento($"Resposta registrada para a {indexFraseAtual / 2}ª frase/instrução:\n{tbResposta.Text}\n");

			if (indexFraseAtual == frases.Count) {
				Close();
				return;
			}

			MudarFrase();
		}
	}
}
