using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Context.src.utils {
	class ViewUtils {

        public static readonly double heightRatio = Screen.PrimaryScreen.Bounds.Height / 1080.0;
        public static readonly double widthRatio = Screen.PrimaryScreen.Bounds.Width / 1920.0;

        public static long GetIdSelecionadoInListView(ListView listView) {
            return Convert.ToInt64(listView.SelectedItems[0].SubItems[1].Text);
        }

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

        public static void CorrigeTamanhoPosicao(Control controle) {
            if (heightRatio == 1.0 && widthRatio == 1.0) {
                return;
            }

            controle.Height = Convert.ToInt32(controle.Height * heightRatio);
            controle.Width = Convert.ToInt32(controle.Width * widthRatio);
            controle.Location = new Point {
                X = Convert.ToInt32(controle.Location.X * widthRatio),
                Y = Convert.ToInt32(controle.Location.Y * heightRatio)
            };
        }

        public static void CorrigeTamanhoPosicaoFonte(Control controle) {
            if (heightRatio == 1.0 && widthRatio == 1.0) {
                return;
            }

            CorrigeTamanhoPosicao(controle);
            controle.Font = new Font(controle.Font.Name, Convert.ToInt32(controle.Font.Size * heightRatio), controle.Font.Style);
        }

        public static List<Control> GetAllFilhos(Control root) {
            var filhos = new List<Control>();

            StepGetAllFilhos(root, filhos);

            return filhos;
        }

        private static void StepGetAllFilhos(Control root, List<Control> filhos) {
            foreach (Control filho in root.Controls) {
                filhos.Add(filho);
                StepGetAllFilhos(filho, filhos);
            }
        }

        public static void CorrigeEscalaTodosOsFilhos(Control root) {
            if (heightRatio == 1.0 && widthRatio == 1.0) {
                return;
            }

            foreach (Control filho in GetAllFilhos(root)) {
                CorrigeTamanhoPosicaoFonte(filho);
            }
        }

        public static long GetIdColunaSelecionada(DataGridView dataGrid) {
            return long.Parse(dataGrid.SelectedRows[0].Cells["Id"].Value.ToString());
        }
    }
}
