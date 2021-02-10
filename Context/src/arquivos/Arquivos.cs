using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.src.arquivos {
	public class Arquivos {
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

			var caminho = diretorioPai + "//" + nomePasta;
			if (string.IsNullOrEmpty(nomeArquivo)) {
				return caminho;
			}

			return caminho + "//" + nomeArquivo;
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
