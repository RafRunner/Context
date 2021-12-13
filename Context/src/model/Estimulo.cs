using Context.src.services;
using Context.src.utils;
using System;
using System.Drawing;

namespace Context.src.model {
	public class Estimulo {

		public string FraseModelo { get; }
		public string Instrucao { get; }
		public string NomeImagem { get; }

		private Image cache;
		public Image Imagem {
			get {
				if (NomeImagem == null) {
					return null;
				}
				if (cache == null) {
					cache = ImagemService.GetImageByName(NomeImagem);
				}
				return cache;
			}
		}

		public Estimulo(string fraseModelo, string instrucao, string nomeImagem) {
			FraseModelo = StringUtils.Normalize(fraseModelo);
			Instrucao = StringUtils.ValideNaoNuloNaoVazioENormalize(instrucao, "Instrução");
			NomeImagem = StringUtils.Normalize(nomeImagem);
		}
	}
}
