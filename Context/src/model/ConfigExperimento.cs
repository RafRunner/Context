using System;
using System.Collections.Generic;

namespace Context.src.model {
	public class ConfigExperimento {

		public List<string> FrasesModelo { get; }
		public List<string> Instrucoes { get; }
		public List<string> NomesImagens { get; }

		public ConfigExperimento(List<string> frasesModelo, List<string> instrucoes, List<string> nomesImagens) {
			// Nunca deve acontecer
			if (frasesModelo.Count != instrucoes.Count || frasesModelo.Count != nomesImagens.Count) {
				throw new Exception("Tamos de propriedades inconsistentes");
			}
			verifyList(frasesModelo, "frases modelo");
			verifyList(instrucoes, "instruções");
			verifyList(nomesImagens, "imagens");
			FrasesModelo = frasesModelo;
			Instrucoes = instrucoes;
			NomesImagens = nomesImagens;
		}

		private void verifyList(List<string> proprieties, string name) {
			foreach (var propriety in proprieties) {
				if (String.IsNullOrWhiteSpace(propriety)) {
					throw new Exception($"Nenhum valor de {name} pode ficar em branco!");
				}
			}
		}
	}
}
