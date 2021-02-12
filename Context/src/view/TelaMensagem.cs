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
	public partial class TelaMensagem : Form {

		private readonly int height = Screen.PrimaryScreen.Bounds.Height;
		private readonly int width = Screen.PrimaryScreen.Bounds.Width;

		private readonly bool fechaAoClicar;

		public TelaMensagem(string mensagem, bool fechaAoClicar) {
			InitializeComponent();

			this.fechaAoClicar = fechaAoClicar;

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
