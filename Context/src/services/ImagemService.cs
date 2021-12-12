using Context.src.arquivos;
using Context.src.utils;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Context.src.services {
	public class ImagemService {

        private static readonly string PASTA_IMAGENS = "Imagens";

        public static string GetFullPath(string nomeImagem = "") {
            return Ambiente.GetCaminhoAbsoluto(PASTA_IMAGENS, nomeImagem);
        }

        private static void CreateDirectoryIfNotExists() {
            if (!Directory.Exists(GetFullPath())) {
                Directory.CreateDirectory(GetFullPath());
            }
        }

        public static Image GetImageByName(string nomeImagem) {
            string caminhoCompleto = GetFullPath(nomeImagem);
            return Image.FromFile(caminhoCompleto);
        }

        public static string CopiaImagemParaPasta(string caminhoImagem) {
            CreateDirectoryIfNotExists();
            // Se não é um caminho já está na pasta e o caminho já é o nome
            if (!caminhoImagem.Contains("\\")) {
                return caminhoImagem;
            }

            var nome = Ambiente.GetNomeArquivo(caminhoImagem);
            var novoCaminho = GetFullPath(nome);

            if (File.Exists(novoCaminho) && ImageUtils.ImageToByteArray(Image.FromFile(novoCaminho)).SequenceEqual(ImageUtils.ImageToByteArray(Image.FromFile(caminhoImagem)))) {
                return nome;
            }
            if (File.Exists(novoCaminho)) {
                throw new Exception($"Já existe uma imagem com o nome {nome}! Por favor, a renomeie");
            }

            File.Copy(caminhoImagem, novoCaminho);
            return nome;
        }
    }
}
