using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Context.src.arquivos {
	public class Ambiente {
		public static List<string> LerArquivo(string caminhoArquivo) {
			var linhas = new List<string>();

			using (var sr = new StreamReader(caminhoArquivo)) {
				while (!sr.EndOfStream) {
					linhas.Add(sr.ReadLine());
				}
			}

			return linhas;
		}

		public static string GetCaminhoAbsoluto(string nomePasta, string nomeArquivo = "") {
			var diretorioPai = Directory.GetCurrentDirectory();

			var caminho = diretorioPai + "\\" + nomePasta;
			if (string.IsNullOrEmpty(nomeArquivo)) {
				return caminho;
			}

			return caminho + "\\" + nomeArquivo;
		}

		public static string GetNomeArquivo(string caminhoArquivo) {
			Match nome = Regex.Match(caminhoArquivo, @"[^\\]+$");
			return nome.Value;
		}

		public static List<string> LerArquivoRelativo(string nomePasta, string nomeArquivo) {
			return LerArquivo(GetCaminhoAbsoluto(nomePasta, nomeArquivo));
		}

		public static string CriaPastaRelativa(string nomePasta) {
			var caminhoTotal = GetCaminhoAbsoluto(nomePasta);

			Directory.CreateDirectory(caminhoTotal);
			return caminhoTotal;
		}
	}
}
