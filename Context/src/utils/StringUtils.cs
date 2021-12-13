using System;

namespace Context.src.utils {
	public class StringUtils {

		public static string Normalize(string sequencia) {
			return sequencia?.Trim();
		}

		public static string ValideNaoNuloNaoVazioENormalize(string sequencia, string nomeCampo) {
			string normalizada = Normalize(sequencia);
			if (string.IsNullOrEmpty(normalizada)) {
				throw new Exception($"O campo {nomeCampo} não pode ficar em branco! Por favor, insera um valor válido.");
			}
			return normalizada;
		}
	}
}
