using Context.src.arquivos;
using Context.src.model;
using Context.src.utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Context.src.view {
	public partial class TelaFrase : Form {

		private readonly int height = Screen.PrimaryScreen.Bounds.Height;
		private readonly int width = Screen.PrimaryScreen.Bounds.Width;

		private readonly ConfigExperimento configExperimento;
		private int indexEstimuloAtual = 0;

		private readonly GeradorRelatorio geradorRelatorio;

		public TelaFrase(ConfigExperimento configExperimento, GeradorRelatorio geradorRelatorio) {
			InitializeComponent();

			this.configExperimento = configExperimento;
			this.geradorRelatorio = geradorRelatorio;

			Location = new Point(0, 0);
			Size = new Size(width, height);

			ViewUtils.CorrigeEscalaTodosOsFilhos(this);

			MudarFrase();
		}

		private void MudarFrase() {
			var estimuloAtual = configExperimento.Estimulos[indexEstimuloAtual];
			ViewUtils.ChangeTextWithSpecialStyles(rtbFrase, estimuloAtual.FraseModelo);
			ViewUtils.ChangeTextWithSpecialStyles(rtbIntrucao, estimuloAtual.Instrucao);

			rtbFrase.SelectionAlignment = HorizontalAlignment.Center;
			rtbIntrucao.SelectionAlignment = HorizontalAlignment.Center;
			if (estimuloAtual.Imagem != null) {
				pictureImagem.Image = ImageUtils.Resize(estimuloAtual.Imagem, pictureImagem.Width, pictureImagem.Height);
			}
			else {
				pictureImagem.Image = null;
			}

			tbResposta.Text = "";
			tbResposta.Focus();

			indexEstimuloAtual++;
		}

		private void btnGravarResposta_Click(object sender, EventArgs e) {
			var resposta = tbResposta.Text;
			if (string.IsNullOrWhiteSpace(resposta)) {
				return;
			}

			geradorRelatorio.AdicionarEvento($"Resposta registrada para a {indexEstimuloAtual}ª frase/instrução/imagem:\n{tbResposta.Text}\n");

			if (indexEstimuloAtual == configExperimento.Estimulos.Count) {
				Close();
				return;
			}

			MudarFrase();
		}
	}
}
