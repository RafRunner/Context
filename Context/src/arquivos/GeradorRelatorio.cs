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
			List<string> frases
			) {
			var horaInicio = DateTime.Now;

			nomeArquivo = $"{horaInicio.ToString(FORMATO_DATE_TIME_ARQUIVO)}-{nomePesquisador}-{nomeParticipante}.txt";

			conteudoRelatorio.AppendLine($"Iniciando novo experimento. Data: {horaInicio.ToString(FORMATO_DATE_TIME)}\n")
				.AppendLine("Experimentador: " + nomePesquisador)
				.AppendLine("Participante: " + nomeParticipante)
				.AppendLine("Idade participante: " + idadeParticipante)
				.AppendLine("Sexo participante: " + sexoParticipante)
				.AppendLine("Número participante: " + numeroParticipante)
				.AppendLine("\nFrases/Instruções usadas:\n");

			for (int i = 0; i < frases.Count; i++) {
				if (i % 2 == 0) conteudoRelatorio.Append(i / 2 + 1 + " - ");
				conteudoRelatorio.AppendLine(frases[i].Replace("\r\n", "\\n"));
				if (i % 2 != 0) conteudoRelatorio.AppendLine();
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

			var caminhoRelatorio = Arquivos.CriaPastaRelativa(PASTA_RELATORIOS) + "\\" + nomeArquivo;
			File.WriteAllText(caminhoRelatorio, conteudoRelatorio.ToString());
		}
	}
}
