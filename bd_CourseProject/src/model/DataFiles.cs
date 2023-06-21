using SharpCompress.Archives.Rar;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_CourseProject.src.model
{
    public static class DataFiles
    {
        public static async Task DownloadFilesAsync(string outputDirectory, IProgress<int> progress)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var urls = await Rosstat.FindLinkedPagesAsync();

                    int totalFiles = urls.Count;
                    int completedFiles = 0;

                    foreach (var url in urls)
                    {
                        // Асинхронная загрузка файла в виде байтового массива
                        byte[] fileData = await client.GetByteArrayAsync(url);

                        // Получение имени файла из URL
                        string filename = GetFilename(url);
                        string rarFilePath = Path.Combine(outputDirectory, filename);

                        // Создание каталога для распакованных файлов
                        string extractionPath = CreateExtractionDirectory(outputDirectory, filename);

                        // Асинхронная запись байтового массива на диск
                        using (FileStream fileStream = new FileStream(rarFilePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                        {
                            await fileStream.WriteAsync(fileData, 0, fileData.Length);
                            await fileStream.FlushAsync();
                        }

                        // Распаковка .rar файла
                        await UnpackRarFile(rarFilePath, extractionPath);

                        // Удаление лишних Excel таблиц
                        DeleteUnwantedFiles(extractionPath);

                        // Удаление .rar файла
                        File.Delete(rarFilePath);

                        // Обновление прогресса
                        completedFiles++;
                        int progressPercentage = (int)((completedFiles / (double)totalFiles) * 100);
                        progress?.Report(progressPercentage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка обработки .rar файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task UnpackRarFile(string rarFilePath, string extractionPath)
        {
            await Task.Run(() =>
            {
                using (var archive = RarArchive.Open(rarFilePath))
                {
                    foreach (var entry in archive.Entries.Where(e => !e.IsDirectory))
                    {
                        string entryPath = Path.Combine(extractionPath, entry.Key);

                        // Создание директории распаковки, если она не существует
                        Directory.CreateDirectory(Path.GetDirectoryName(entryPath));

                        using (var entryStream = entry.OpenEntryStream())
                        using (var outputStream = new FileStream(entryPath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            entryStream.CopyTo(outputStream);
                        }
                    }
                }
            });
        }

        private static string CreateExtractionDirectory(string outputDirectory, string filename)
        {
            string extractionPath = Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(filename));
            Directory.CreateDirectory(extractionPath);
            return extractionPath;
        }

        private static string GetFilename(string hreflink)
        {
            Uri uri = new Uri(hreflink);
            string filename = Path.GetFileName(uri.LocalPath);
            return filename;
        }

        private static void DeleteUnwantedFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);

                if (fileName != "tab12.xlsx" && fileName != "Средняя заработная плата отдельных категорий работников социальной сферы и науки.xlsx")
                {
                    File.Delete(file);
                }
            }
        }
    }
}

