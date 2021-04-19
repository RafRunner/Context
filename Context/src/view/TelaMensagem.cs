using Context.src.view.helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Context.src.view {
	public partial class TelaMensagem : Form {

		private readonly int height = Screen.PrimaryScreen.Bounds.Height;
		private readonly int width = Screen.PrimaryScreen.Bounds.Width;

		private readonly bool fechaAoClicar;

		public TelaMensagem(string mensagem, bool fechaAoClicar) {
			InitializeComponent();

			this.fechaAoClicar = fechaAoClicar;

			Location = new Point(0, 0);
			Size = new Size(width, height);

			var heightRatio = height / 1080.0;
			var widthRatio = width / 1920.0;

			ViewHelper.CorrigeTamanhoEPosicao(lblMensagem, heightRatio, widthRatio);
			ViewHelper.CorrigeFonte(lblMensagem, heightRatio);

			lblMensagem.MaximumSize = new Size((int)(width * 0.8), 0);
			lblMensagem.AutoSize = true;

			lblMensagem.Text = mensagem;
			lblMensagem.Location = new Point((width - lblMensagem.Width) / 2, lblMensagem.Location.Y);
		}

		private void TelaMensagem_Click(object sender, EventArgs e) {
			if (fechaAoClicar) {
				Close();
			}
		}
	}
}
