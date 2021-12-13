using Context.src.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.src.arquivos {
	public class GeradorRelatorio {

		private static string PASTA_RELATORIOS = "Relatorios";
		private static readonly string FORMATO_TIME = "HH:mm:ss";
		private static readonly string FORMATO_DATE_TIME = "dd/MM/yyyy HH:mm:ss";
		private static readonly string FORMATO_DATE_TIME_ARQUIVO = "yyyy-MM-dd HH-mm-ss";

		private readonly StringBuilder conteudoRelatorio = new StringBuilder();
		private readonly string nomeArquivo;

		public GeradorRelatorio(
			string nomePesquisador,
			string nomeParticipante,
			int idadeParticipante,
			string sexoParticipante,
			int numeroParticipante,
			ConfigExperimento config
			) {
			var horaInicio = DateTime.Now;

			nomeArquivo = $"{horaInicio.ToString(FORMATO_DATE_TIME_ARQUIVO)}-{nomePesquisador}-{numeroParticipante}-{nomeParticipante}.txt";

			conteudoRelatorio.AppendLine($"Iniciando novo experimento. Data: {horaInicio.ToString(FORMATO_DATE_TIME)}\n")
				.AppendLine("Experimentador: " + nomePesquisador)
				.AppendLine("Participante: " + nomeParticipante)
				.AppendLine("Idade participante: " + idadeParticipante)
				.AppendLine("Sexo participante: " + sexoParticipante)
				.AppendLine("Número participante: " + numeroParticipante)
				.AppendLine("\nFrases/Instruções/Imagens usadas:\n");

			for (int i = 0; i < config.Estimulos.Count; i++) {
				var estimulo = config.Estimulos[i];

				conteudoRelatorio.AppendLine(i + 1 + ":")
					.Append("Frase modelo: ").AppendLine(estimulo.FraseModelo)
					.Append("Instrução: ").AppendLine(estimulo.Instrucao)
					.Append("Nome imagem: ").AppendLine(estimulo.NomeImagem)
					.AppendLine();
			}

			conteudoRelatorio.AppendLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\n")
				.AppendLine("Respostas do participante:\n");
		}

		public void AdicionarEvento(string mensagem) {
			conteudoRelatorio.Append(DateTime.Now.ToString(FORMATO_TIME))
				.Append(" - ")
				.AppendLine(mensagem);
		}

		public void GerarRelatorio() {
			var horaFim = DateTime.Now;

			conteudoRelatorio.AppendLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
				.AppendLine("\nExperimento finalizado. Hora do fim: " + horaFim.ToString(FORMATO_TIME));

			var caminhoRelatorio = Ambiente.CriaPastaRelativa(PASTA_RELATORIOS) + "\\" + nomeArquivo;
			File.WriteAllText(caminhoRelatorio, conteudoRelatorio.ToString());
		}
	}
}
