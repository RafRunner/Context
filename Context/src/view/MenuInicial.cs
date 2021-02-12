using Context.src.arquivos;
using Context.src.view;
using Context.src.view.helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Context {
	public partial class Form1 : Form {

		private List<string> frases = null;

		public Form1() {
			InitializeComponent();
			CarregarUltimaConfig();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			SalvarConfigAtual();
		}

		private void SalvarConfigAtual() {
			var configAtual = new StringBuilder();
			configAtual.AppendLine(tbNomePesquisador.Text)
				.AppendLine(tbNomeParticipante.Text)
				.AppendLine(numIdadeParticipante.Value.ToString())
				.AppendLine(cbSexoParticipante.SelectedIndex.ToString())
				.AppendLine(numNumeroParticipante.Value.ToString())
				.AppendLine(tbArquivoFrases.Text);

			var arquivoCache = Arquivos.CriaPastaRelativa("cache") + "\\ultima_config.txt";
			File.WriteAllText(arquivoCache, configAtual.ToString());
		}

		private void CarregarUltimaConfig() {
			if (!File.Exists(Arquivos.GetCaminhoAbsoluto("cache", "ultima_config.txt"))) {
				return;
			}

			var configAnterior = Arquivos.LerArquivoRelativo("cache", "ultima_config.txt");

			tbNomePesquisador.Text = configAnterior[0];
			tbNomeParticipante.Text = configAnterior[1];
			numIdadeParticipante.Value = int.Parse(configAnterior[2]);
			cbSexoParticipante.SelectedIndex = int.Parse(configAnterior[3]);
			numNumeroParticipante.Value = int.Parse(configAnterior[4]);
			tbArquivoFrases.Text = configAnterior[5];
		}

		private void CarregaFrasesArquivo(string arquivo) {
			if (string.IsNullOrEmpty(arquivo)) return;

			frases = new List<string>();
			Arquivos.LerArquivo(arquivo).FindAll(linha => !string.IsNullOrWhiteSpace(linha)).ForEach(frase => {
				frases.Add(frase.Replace("\\n", "\r\n"));
			});
		}

		private void btnSelecionarArquivo_Click(object sender, EventArgs e) {
			string nomeArquivoFrases = ViewHelper.SelecionaArquivoComFiltro(openFileDialog, "TXT|*.txt");
			if (string.IsNullOrEmpty(nomeArquivoFrases)) {
				return;
			}
			tbArquivoFrases.Text = nomeArquivoFrases;
		}

		private void btnIniciar_Click(object sender, EventArgs e) {
			CarregaFrasesArquivo(tbArquivoFrases.Text);
			if (frases == null) {
				MessageBox.Show("Nenhum arquivo de frases selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			if (frases.Count == 0) {
				MessageBox.Show("Arquivo de frases selecionado está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			if (frases.Count % 2 != 0) {
				MessageBox.Show("Arquivo de frases Deve ter um número par de linhas (pares de frases/instruções)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			var nomePesquisador = tbNomePesquisador.Text;
			if (nomePesquisador == "") {
				MessageBox.Show("O nome do pesquisador é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			var nomeParticipante = tbNomeParticipante.Text;
			if (nomeParticipante == "") {
				MessageBox.Show("O nome do participante é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			var idadeParticipante = numIdadeParticipante.Value;
			if (idadeParticipante == 0) {
				MessageBox.Show("A idade do participante é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			var sexoParticipante = cbSexoParticipante.SelectedItem;
			if (sexoParticipante == null) {
				MessageBox.Show("O sexo do participante é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			var numeroParticipante = numNumeroParticipante.Value;

			new TelaFrase(frases).ShowDialog();
		}
	}
}
