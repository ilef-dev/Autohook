using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace brod
{
    internal static class OfficeActivation
    {
        public static int CreateMklink()
        {
            string linkPath = @"%ProgramFiles%\Microsoft Office\root\vfs\System\sppcs.dll"; // Путь к создаваемой ссылке
            string targetPath = @"%windir%\System32\sppc.dll"; // Путь к целевому файлу

            // Формируем команду
            string command = $"/C chcp 65001 & mklink \"{linkPath}\" \"{targetPath}\"";

            // Регистрация поставщика кодировок для поддержки CP866
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Настройка процесса
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = command,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(866), // Установка кодировки CP866 для OEM
                StandardErrorEncoding = Encoding.GetEncoding(866)   // Установка кодировки CP866 для OEM
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();

                    // Получаем вывод команды
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode == 0)
                    {
                        //Console.WriteLine("Символическая ссылка успешно создана.");
                    }
                    else
                    {
                        Logger.Err($"Ошибка создания символической ссылки.");
                    }
                }
            }
            catch (Exception ex)
            {
                //
            }

            // Проверяем сущесвтует ли уже ссылка
            if (!File.Exists(Environment.ExpandEnvironmentVariables(linkPath)))
            {
                Logger.Err("Не найден файл <sppcs.dll>");
                return 0;
            }

            return 1;
        }

        public static int UploadSppc()
        {
            string resourceName = "brod.Resources.sppc64.dll";
            string preOutputPath = @"%ProgramFiles%\Microsoft Office\root\vfs\System\sppc.dll";
            string outputPath = Environment.ExpandEnvironmentVariables(preOutputPath);

            try
            {
                // Получение текущего сборщика
                Assembly assembly = Assembly.GetExecutingAssembly();

                // Чтение встроенного ресурса
                using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (resourceStream == null)
                    {
                        Console.WriteLine("Ресурс не найден.");
                        return 0;
                    }

                    // Сохранение файла
                    using (FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }

                    Logger.Log($"Файл успешно сохранен в {outputPath}");
                }
            }
            catch (Exception ex)
            {
                Logger.Err("Ошибка: " + ex.Message);
                return 0;
            }

            return 1;
        }

        public static int InsertKey(string key)
        {
            // Формируем команду
            string command = $"/C slmgr /ipk " + key;

            // Регистрация поставщика кодировок для поддержки CP866
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // Настройка процесса
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = command,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(866), // Установка кодировки CP866 для OEM
                StandardErrorEncoding = Encoding.GetEncoding(866)   // Установка кодировки CP866 для OEM
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();

                    // Получаем вывод команды
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    if (process.ExitCode == 0)
                    {
                        //Console.WriteLine("Символическая ссылка успешно создана.");
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                //
            }

            return 0;
        }
    }
}
