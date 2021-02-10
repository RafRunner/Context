using System;
using System.Drawing;
using System.Windows.Forms;

namespace Context.src.view.helpers {
	class ViewHelper {

		public static string SelecionaArquivoComFiltro(FileDialog fileDialog, string filter = null) {
			string retorno = string.Empty;
			if (filter != null) {
				fileDialog.Filter = filter;
			}

			DialogResult result = fileDialog.ShowDialog();
			if (result == DialogResult.OK) {
				retorno = fileDialog.FileName;
			}

			fileDialog.Filter = string.Empty;
			return retorno;
		}

		public static void CorrigeTamanhoEPosicao(Control controle, double heightRatio, double widthRatio) {
			controle.Height = Convert.ToInt32(controle.Height * heightRatio);
			controle.Width = Convert.ToInt32(controle.Width * widthRatio);
			controle.Location = new Point {
				X = Convert.ToInt32(controle.Location.X * widthRatio),
				Y = Convert.ToInt32(controle.Location.Y * heightRatio)
			};
		}

		public static void CorrigeFonte(Label label, double heightRatio) {
			label.Font = new Font(label.Font.Name, Convert.ToInt32(label.Font.Size * heightRatio));
		}
	}
}
