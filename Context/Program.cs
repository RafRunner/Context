using System;
using System.Threading;
using System.Windows.Forms;

namespace Context {
	static class Program {
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main() {
            Application.ThreadException += new ThreadExceptionEventHandler(ThreadExceptionHandler);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
        private static void ThreadExceptionHandler(object sender, ThreadExceptionEventArgs t) {
            ShowThreadExceptionDialog("Erro", true, t.Exception);
        }

        private static void ShowThreadExceptionDialog(string title, bool debug, Exception e) {
            string errorMsg;
            if (debug) {
                errorMsg = "Ocorreu um erro! Mensagem:\n\n";
                errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            }
            else {
                errorMsg = e.Message;
            }
            MessageBox.Show(errorMsg, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
