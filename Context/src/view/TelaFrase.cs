using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Context.src.view {
	public partial class TelaFrase : Form {

		private readonly int height = Screen.PrimaryScreen.Bounds.Height;
		private readonly int width = Screen.PrimaryScreen.Bounds.Width;

		private readonly List<string> frases;
		private int indexFraseAtual = 0;

		public TelaFrase(List<string> frases) {
			InitializeComponent();

			this.frases = frases;

			Location = new Point(0, 0);
			Size = new Size(width, height);

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

			if (indexFraseAtual == frases.Count) {
				Close();
				return;
			}

			MudarFrase();
		}
	}
}
