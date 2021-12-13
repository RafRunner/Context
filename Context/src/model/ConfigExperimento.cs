using Context.src.arquivos;
using Context.src.services;
using System;
using System.Collections.Generic;

namespace Context.src.model {
	public class ConfigExperimento {

		public List<Estimulo> Estimulos { get; }

		public ConfigExperimento(List<Estimulo> estimulos) {
			if (estimulos.Count == 0) {
				throw new Exception("Para o experimento precisamos de pelo menos um trio Frase/Comando/Imagem!");
			}
			Estimulos = estimulos;
		}

		public static ConfigExperimento CriaPorArquivo(string arquivo) {
			if (string.IsNullOrEmpty(arquivo)) return null;

			var estimulos = new List<Estimulo>();
			var linhas = Ambiente.LerArquivo(arquivo).FindAll(linha => !string.IsNullOrWhiteSpace(linha));

			if (linhas.Count % 3 != 0) {
				throw new Exception("Arquivo de configuração inválido/corrompido! Selecione ou crie outro");
			}

			for (int i = 0; i < linhas.Count; i += 3) {
				string fraseModelo = null;
				if (linhas[i] != "-") {
					fraseModelo = linhas[i].Replace("\\n", "\r\n");
				}

				var instrucao = linhas[i + 1];

				string nomeImagem = null;
				if (linhas[i + 2] != "-") {
					nomeImagem = ImagemService.CopiaImagemParaPasta(linhas[i + 2]);
				}

				estimulos.Add(new Estimulo(fraseModelo, instrucao, nomeImagem));
			}

			return new ConfigExperimento(estimulos);
		}
	}
}
