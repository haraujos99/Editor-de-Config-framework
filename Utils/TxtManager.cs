using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{

    public class TxtManager
    {

        public string Path;
        private DirectoryInfo Directory;
        private FileInfo[] FilesList;
        private FileInfo CurrentFile;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="path">Caminho do diretório desejado</param>
        public TxtManager(string path)
        {
            Path = path;
            Directory = new DirectoryInfo(Path);
            GetFilesList();
            if (IsFileInPath())
            {
                SetCurrentFile();
            }
        }

        /// <summary>
        /// Lista os arquivos no diretório.
        /// </summary>
        private void GetFilesList()
        {
            FilesList = Directory.GetFiles("*.json");
            if(FilesList.Length == 0) {
                FilesList = Directory.GetFiles("*.config");
            }
        }

        /// <summary>
        /// Atribui informação a variável CurrentFile
        /// </summary>
        /// <param name="FileName">Opcional, caso vazio passa o primeiro item da FilesList</param>
        private void SetCurrentFile(string FileName = "")
        {
            if (FileName != "" && FileExists($"{FileName}"))
            {
                CurrentFile = Directory.GetFiles($"{FileName}")[0];
            }
            else
            {
                CurrentFile = FilesList[0].Exists ? FilesList[0] : null;
            }
        }

        /// <summary>
        /// Confere se já existe arquivo .txt com o nome informado
        /// </summary>
        /// <param name="FileName">Nome do arquivo</param>
        /// <returns>
        /// <b>True:</b>Caso exista.
        /// <br></br>
        /// <b>False:</b> Caso não exista.
        /// </returns>
        private Boolean FileExists(string FileName)
        {
            foreach (var file in FilesList)
            {
                if (file.Name == FileName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checa se há arquivos no diretório.
        /// </summary>
        /// <returns>
        /// <b>True</b> se houver;
        /// <br></br>
        /// <b>False</b> se não houver;
        /// </returns>
        public Boolean IsFileInPath()
        {
            if (FilesList.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna uma lsita com os nomes dos arquivos .txt
        /// </summary>
        /// <returns>string[]</returns>
        public string[] ListFilesNames()
        {
            string[] FilesNames = new string[FilesList.Length];
            for (int i = 0; i < FilesList.Length; i++)
            {
                FilesNames[i] = FilesList[i].Name;
            }
            return FilesNames;

        }

        public string FirstFileName()
        {
            return FilesList[0].Name;
        }

        /// <summary>
        /// Cria um arquivo .txt no diretório com o nome informado no parâmetro.
        /// </summary>
        /// <param name="FileName">Nome do arquivo a ser criado</param>
        public void CreateFile(string FileName)
        {
            if (!FileExists($"{FileName}.txt"))
            {
                StreamWriter NewFile = File.CreateText($@"{Path}\{FileName}.txt");
                NewFile.Close();
                GetFilesList();
            }
        }

        /// <summary>
        /// Escreve uma linha no arquivo .txt
        /// </summary>
        /// <param name="text">Conteudo a ser escrito</param>
        /// <param name="FileName"><b>Opcional:</b>Se não preenchido escreve no primeiro arquivo do diretório</param>
        public void WriteLineInFile(string text, string FileName = "")
        {
            SetCurrentFile(FileName);
            StreamWriter input = File.AppendText(CurrentFile.FullName);
            input.WriteLine(text);
            input.Close();

        }

        /// <summary>
        /// Sobrescreve um arquivo .txt, por padrão o primeiro da lista.
        /// </summary>
        /// <param name="text">Texto para sobrescrever</param>
        /// <param name="FileName"><b>Opcional:</b>Arquivo para sobrescrever</param>
        public void OverwriteFile(string text, string FileName = "")
        {
            SetCurrentFile(FileName);
            StreamWriter input = File.CreateText(CurrentFile.FullName);
            input.WriteLine(text);
            input.Close();
        }

        private string fullText;
        public string ReadFile(string FileName = "") {
            if (IsFileInPath()) {
                SetCurrentFile(FileName);
                string[] readText = File.ReadAllLines($@"{Path}\{CurrentFile.Name}");
                if (readText.Length > 0) {
                    foreach( string line in readText) {
                        fullText += $@"{line}" + "\r\n";
                    }
                    return fullText;
                } else {
                    return "";
                }
            } else {
                return "Não há arquivos no diretório";
            }
        }
    

        /// <summary>
        /// Retorna a útima linha do arquivo
        /// </summary>
        /// <param name="FileName"><b>Opcional:</b>Caso não declado pega o primeiro item do diretório.</param>
        /// <returns>string da útima linha do arquivo</returns>
        public string ReadLastLine(string FileName = "")
        {
            if (IsFileInPath())
            {
                SetCurrentFile(FileName);
                string[] readText = File.ReadAllLines($@"{Path}\{CurrentFile.Name}");
                if (readText.Length > 0)
                {
                    return readText[readText.Length - 1];
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "Não há arquivos no diretório";
            }
        }

        /// <summary>
        /// Move o arquivo .txt para o diretório informado
        /// </summary>
        /// <param name="DestinyPath">Caminho do diretório de destino</param>
        /// <param name="Filename"><b>Opcional:</b>Se não preenchido move o primeiro arquivo do diretório</param>
        public void MoveFile(string DestinyPath, string FileName = "")
        {
            SetCurrentFile(FileName);
            CurrentFile.MoveTo($@"{DestinyPath}\{CurrentFile.Name}");
            GetFilesList();
        }

        /// <summary>
        /// Move todos os arquivos .txt do diretóriode origem para o diretório de destino
        /// </summary>
        /// <param name="DestinyPath">Diretório de destino</param>
        public void MoveAllFiles(string DestinyPath)
        {
            foreach (var file in FilesList)
            {
                File.Move(file.FullName, $@"{DestinyPath}\{file.Name}");
            }
            GetFilesList();
        }

        /// <summary>
        /// Retorna o tamanho em bytes do arquivo passado no parametro, caso não haja parametro retorna o tamanho do primeiro arquivo do diretório.
        /// </summary>
        /// <param name="FileName"><b>Opcional</b></param>
        /// <returns>long com o tamanho do arquivo em bytes</returns>
        public long FileSize(string FileName = "")
        {
            GetFilesList();
            SetCurrentFile(FileName);
            return CurrentFile.Length;
        }

        /// <summary>
        /// Deleta um arquivo do diretório
        /// </summary>
        /// <param name="FileName">Nome do arquivo, caso não preenchido deleta o primeiro.</param>
        public void DeleteFile(string FileName = "") {
            SetCurrentFile(FileName);
            File.Delete(CurrentFile.FullName);
            GetFilesList();
        }

        public int FileLinesCount(string FileName = "") {
            SetCurrentFile(FileName);
            string[] readText = File.ReadAllLines($@"{Path}\{CurrentFile.Name}");
            return readText.Length;
        }

        public string CurrentFilePath() {
            return IsFileInPath() ? CurrentFile.FullName : null;
        }
    }
}